using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formGestionUsuariosA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly UsuarioBLL _bll = new UsuarioBLL();
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();
        private readonly HistorialUsuarioBLL _histBLL = new HistorialUsuarioBLL();

        // Lista completa de permisos como árbol Composite
        private List<ComponentePermisoBE> _arbolPermisos = new();

        // Usuario actualmente seleccionado para modificar (null = alta)
        private UsuarioBE _usuarioSeleccionado = null;

        public formGestionUsuariosA()
        {
            InitializeComponent();

            // Eventos
            comboBoxUsuarios.SelectedIndexChanged += ComboBoxUsuarios_SelectedIndexChanged;
            buttonRMUsuario_FormGestionUsuariosA.Click += BtnRegistrarModificar_Click;
            buttonLimpiarCampos_FormGestionUsuariosA.Click += BtnLimpiar_Click;
            buttonEliminar_FormGestionUsuariosA.Click += BtnEliminar_Click;
            btnRestaurarEstado_FormGestionUsuariosA.Click += btnRestaurarEstado_Click;
            this.Load += formGestionUsuariosA_Load;
            this.FormClosing += formGestionUsuariosA_FormClosing;
        }

        private void formGestionUsuariosA_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
            CargarDatos();
        }

        private void formGestionUsuariosA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        public void ActualizarIdioma(IdiomaBE idioma)
        {
            if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
            else Traducir(idioma);
        }

        private void Traducir(IdiomaBE idioma = null)
        {
            idioma ??= SessionManager.IdiomaActual ?? _traductorBLL.ObtenerIdiomaDefault();
            var t = _traductorBLL.ObtenerTraducciones(idioma);
            TraducirControles(this.Controls, t);
        }

        private void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> t)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl.Tag is string clave && t.ContainsKey(clave))
                    ctrl.Text = t[clave];
                if (ctrl.Controls.Count > 0)
                    TraducirControles(ctrl.Controls, t);
            }
        }

        private void AsignarTags()
        {
            groupBoxUsuarios_FormGestionUsuariosA.Tag = "groupBoxUsuarios_FormGestionUsuariosA";
            groupBoxModificar_FormGestionUsuariosA.Tag = "groupBoxModificar_FormGestionUsuariosA";
            buttonLimpiarCampos_FormGestionUsuariosA.Tag = "buttonLimpiarCampos_FormGestionUsuariosA";
            buttonRMUsuario_FormGestionUsuariosA.Tag = "buttonRMUsuario_FormGestionUsuariosA";
            labelUsuario_FormGestionUsuariosA.Tag = "labelUsuario_FormGestionUsuariosA";
            labelPermisos_FormGestionUsuariosA.Tag = "labelPermisos_FormGestionUsuariosA";
            labelBloqueado_FormGestionUsuariosA.Tag = "labelBloqueado_FormGestionUsuariosA";
            labelActivo_FormGestionUsuariosA.Tag = "labelActivo_FormGestionUsuariosA";
            labelContraseña_FormGestionUsuariosA.Tag = "labelContraseña_FormGestionUsuariosA";
            labelNombre_FormGestionUsuariosA.Tag = "labelNombre_FormGestionUsuariosA";
            groupBoxEliminar_FormGestionUsuariosA.Tag = "groupBoxEliminar_FormGestionUsuariosA";
            buttonEliminar_FormGestionUsuariosA.Tag = "buttonEliminar_FormGestionUsuariosA";
            labelUsuarioEliminar_FormGestionUsuariosA.Tag = "labelUsuarioEliminar_FormGestionUsuariosA";
            grpHistorial_FormGestionUsuariosA.Tag = "grpHistorial_FormGestionUsuariosA";
            lblInfoRestaurar_FormGestionUsuariosA.Tag = "lblInfoRestaurar_FormGestionUsuariosA";
            btnRestaurarEstado_FormGestionUsuariosA.Tag = "btnRestaurarEstado_FormGestionUsuariosA";
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
                dgvHistorial.DataSource = null;
                return;
            }

            // Modificación: poblar campos
            textBoxNombreModificar.Text = _usuarioSeleccionado.Usuario;
            textBoxContraseñaModificar.Text = string.Empty; // no mostrar hash
            checkBoxActivoModificar_FormGestionUsuariosA.Checked = !_usuarioSeleccionado.Baja;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Checked = _usuarioSeleccionado.Bloqueado;

            // Marcar permisos que ya tiene (cargados via BLL, no desde el objeto en memoria)
            var permisosActivos = _permisoBLL
                .ObtenerArbolDeUsuario(_usuarioSeleccionado.Id)
                .Select(c => c.Id_Permiso)
                .ToHashSet();
            PopularTreeView(permisosActivos);

            CargarHistorial(_usuarioSeleccionado.Id);
        }

        // ── Historial (Memento) ───────────────────────────────────────────────

        private void CargarHistorial(Guid idUsuario)
        {
            try
            {
                var historial = _histBLL.ObtenerHistorial(idUsuario);
                dgvHistorial.DataSource = historial.Select(m => new
                {
                    m.IdHistorial,
                    Fecha = m.FechaCambio.ToString("dd/MM/yyyy HH:mm:ss"),
                    m.Accion,
                    Username = m.UsernameSnap,
                    Activo = m.ActivoSnap,
                    Bloqueado = m.BloqueadoSnap,
                    Permisos = m.PermisosSnap ?? "(ninguno)"
                }).ToList();

                dgvHistorial.Columns["IdHistorial"].Visible = false; // ocultar la PK
                dgvHistorial.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestaurarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (_usuarioSeleccionado == null)
                {
                    MessageBox.Show("Seleccioná un usuario primero.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvHistorial.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccioná una fila del historial para restaurar.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Leer los datos del snapshot seleccionado
                var fila = dgvHistorial.SelectedRows[0];
                string usernameSnap = fila.Cells["Username"].Value?.ToString() ?? "";
                bool activoSnap = (bool)(fila.Cells["Activo"].Value ?? true);
                bool bloqueadoSnap = (bool)(fila.Cells["Bloqueado"].Value ?? false);
                string permisosStr = fila.Cells["Permisos"].Value?.ToString() ?? "";

                // Parsear permisos
                List<int> permisosIds = new();
                if (!string.IsNullOrWhiteSpace(permisosStr) && permisosStr != "(ninguno)")
                {
                    permisosIds = permisosStr.Split(',')
                        .Select(p => int.TryParse(p.Trim(), out int id) ? id : -1)
                        .Where(id => id > 0)
                        .ToList();
                }

                var confirm = MessageBox.Show(
                    $"¿Restaurar el usuario '{_usuarioSeleccionado.Usuario}' al estado:\n" +
                    $"Username: {usernameSnap}\nActivo: {activoSnap}\nBloqueado: {bloqueadoSnap}\nPermisos: {permisosStr}\n\n" +
                    "NOTA: la contraseña actual NO se modifica.",
                    "Confirmar restauración",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                // Armar el UsuarioBE con el estado a restaurar
                var usuarioRestaurado = new UsuarioBE
                {
                    Id = _usuarioSeleccionado.Id,
                    Usuario = usernameSnap,
                    Contraseña = string.Empty,   // vacío = mantener contraseña actual
                    Baja = !activoSnap,
                    Bloqueado = bloqueadoSnap
                };

                _bll.Modificar(usuarioRestaurado, permisosIds);

                MessageBox.Show("Estado restaurado correctamente. Se generó un nuevo registro en el historial con acción 'MODIFICACION'.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposRM();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al restaurar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Registrar / Modificar ─────────────────────────────────────────────

        private void BtnRegistrarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombreModificar.Text.Trim();
                string contraseña = textBoxContraseñaModificar.Text;
                bool activo = !checkBoxActivoModificar_FormGestionUsuariosA.Checked;
                bool bloqueado = checkBoxBloqueadoModificar_FormGestionUsuariosA.Checked;
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
            checkBoxActivoModificar_FormGestionUsuariosA.Checked = true;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Checked = false;
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
