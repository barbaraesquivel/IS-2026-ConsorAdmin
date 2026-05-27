using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formGestionUsuariosA : Form
    {
        private readonly UsuarioBLL _bll = new UsuarioBLL();
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();

        // Lista completa de permisos como árbol Composite
        private List<ComponentePermisoBE> _arbolPermisos = new();

        // Usuario actualmente seleccionado para modificar (null = alta)
        private UsuarioBE _usuarioSeleccionado = null;

        public formGestionUsuariosA()
        {
            InitializeComponent();

            // Eventos
            comboBoxUsuarios.SelectedIndexChanged += ComboBoxUsuarios_SelectedIndexChanged;
            buttonRMUsuario.Click += BtnRegistrarModificar_Click;
            buttonLimpiarCampos.Click += BtnLimpiar_Click;
            buttonEliminar.Click += BtnEliminar_Click;

            CargarDatos();
        }

        // ── Carga inicial ─────────────────────────────────────────────────────

        private void CargarDatos()
        {
            CargarArbolPermisos();
            CargarComboBoxUsuarios();
            CargarDGV();
        }

        private void CargarArbolPermisos()
        {
            try
            {
                _arbolPermisos = _bll.ObtenerArbolPermisos();
                PopularTreeView(new HashSet<int>());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar permisos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarComboBoxUsuarios()
        {
            try
            {
                var usuarios = _bll.ObtenerTodos();

                comboBoxUsuarios.Items.Clear();
                comboBoxUsuarioEliminar.Items.Clear();

                comboBoxUsuarios.Items.Add(new ComboItem { Display = "(nuevo usuario)", Value = null });

                foreach (var u in usuarios)
                {
                    var item = new ComboItem { Display = u.Usuario, Value = u };
                    comboBoxUsuarios.Items.Add(item);
                    comboBoxUsuarioEliminar.Items.Add(new ComboItem { Display = u.Usuario, Value = u });
                }

                comboBoxUsuarios.DisplayMember = "Display";
                comboBoxUsuarioEliminar.DisplayMember = "Display";

                comboBoxUsuarios.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDGV()
        {
            try
            {
                var usuarios = _bll.ObtenerTodos();

                var tabla = usuarios.Select(u => new
                {
                    Id = u.Id,
                    Username = u.Usuario,
                    Activo = !u.Baja,
                    Bloqueado = u.Bloqueado
                }).ToList();

                dataGridUsuarios.DataSource = tabla;
                dataGridUsuarios.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tabla: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── TreeView de permisos ──────────────────────────────────────────────

        private void PopularTreeView(HashSet<int> permisosActivos)
        {
            tvwPermisos.BeginUpdate();
            tvwPermisos.Nodes.Clear();

            foreach (var comp in _arbolPermisos)
            {
                var nodo = CrearNodo(comp, permisosActivos);
                tvwPermisos.Nodes.Add(nodo);
            }

            tvwPermisos.ExpandAll();
            tvwPermisos.EndUpdate();
        }

        private TreeNode CrearNodo(ComponentePermisoBE comp, HashSet<int> activos)
        {
            string prefijo = comp.Tipo == "F" ? "[F] " : "[P] ";
            var nodo = new TreeNode(prefijo + comp.Nombre)
            {
                Tag = comp,
                Checked = activos.Contains(comp.Id_Permiso)
            };

            foreach (var hijo in comp.ObtenerHijos)
                nodo.Nodes.Add(CrearNodo((ComponentePermisoBE)hijo, activos));

            return nodo;
        }

        private List<int> ObtenerPermisosCheckeados()
        {
            var resultado = new List<int>();
            RecolectarCheckeados(tvwPermisos.Nodes, resultado);
            return resultado;
        }

        private void RecolectarCheckeados(TreeNodeCollection nodos, List<int> lista)
        {
            foreach (TreeNode n in nodos)
            {
                if (n.Checked && n.Tag is ComponentePermisoBE comp)
                    lista.Add(comp.Id_Permiso);
                RecolectarCheckeados(n.Nodes, lista);
            }
        }

        // ── Selección de usuario para modificar ───────────────────────────────

        private void ComboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem is not ComboItem item) return;

            _usuarioSeleccionado = item.Value as UsuarioBE;

            if (_usuarioSeleccionado == null)
            {
                // Alta: limpiar campos
                LimpiarCamposRM();
                return;
            }

            // Modificación: poblar campos
            textBoxNombreModificar.Text = _usuarioSeleccionado.Usuario;
            textBoxContraseñaModificar.Text = string.Empty; // no mostrar hash
            checkBoxActivoModificar.Checked = !_usuarioSeleccionado.Baja;
            checkBoxBloqueadoModificar.Checked = _usuarioSeleccionado.Bloqueado;

            // Marcar permisos que ya tiene (cargados via BLL, no desde el objeto en memoria)
            var permisosActivos = _permisoBLL
                .ObtenerArbolDeUsuario(_usuarioSeleccionado.Id)
                .Select(c => c.Id_Permiso)
                .ToHashSet();
            PopularTreeView(permisosActivos);
        }

        // ── Registrar / Modificar ─────────────────────────────────────────────

        private void BtnRegistrarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombreModificar.Text.Trim();
                string contraseña = textBoxContraseñaModificar.Text;
                bool activo = !checkBoxActivoModificar.Checked;
                bool bloqueado = checkBoxBloqueadoModificar.Checked;
                var permisos = ObtenerPermisosCheckeados();

                var usuario = new UsuarioBE
                {
                    Usuario = nombre,
                    Contraseña = contraseña,
                    Baja = activo,
                    Bloqueado = bloqueado
                };

                if (_usuarioSeleccionado == null)
                {
                    // ALTA
                    _bll.Registrar(usuario, permisos);
                    MessageBox.Show("Usuario registrado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MODIFICACIÓN
                    usuario.Id = _usuarioSeleccionado.Id;
                    _bll.Modificar(usuario, permisos);
                    MessageBox.Show("Usuario modificado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimpiarCamposRM();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ── Eliminar (baja lógica) ────────────────────────────────────────────

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarioEliminar.SelectedItem is not ComboItem item || item.Value is not UsuarioBE usuario)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                $"¿Confirma dar de baja al usuario '{usuario.Usuario}'?\nEsta acción es una baja lógica (no se elimina físicamente).",
                "Confirmar baja",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            try
            {
                _bll.Inactivar(usuario.Id);
                MessageBox.Show("Usuario dado de baja correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Limpiar ───────────────────────────────────────────────────────────

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposRM();
            comboBoxUsuarios.SelectedIndex = 0;
        }

        private void LimpiarCamposRM()
        {
            _usuarioSeleccionado = null;
            textBoxNombreModificar.Clear();
            textBoxContraseñaModificar.Clear();
            checkBoxActivoModificar.Checked = true;
            checkBoxBloqueadoModificar.Checked = false;
            PopularTreeView(new HashSet<int>());
        }

        // ── Clase auxiliar para ComboBox ──────────────────────────────────────

        private class ComboItem
        {
            public string Display { get; set; }
            public object Value { get; set; }
            public override string ToString() => Display;
        }
    }
}
