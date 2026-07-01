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

        private List<ComponentePermisoBE> _arbolPermisos = new();
        private UsuarioBE _usuarioSeleccionado = null;

        // Controles de Email/Teléfono y Revertir campo (se inicializan en Load)
        private TextBox textBoxEmailModificar;
        private TextBox textBoxTelefonoModificar;
        private ComboBox cboAtributoRevertir;
        private Button btnRevertirAtributo_FormGestionUsuariosA;

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
            InicializarControlesExtra();
            SessionManager.SuscribirObservador(this);
            Traducir();
            CargarDatos();
        }

        private void formGestionUsuariosA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        private void InicializarControlesExtra()
        {
            // Mover botones actuales hacia abajo para hacer lugar a Email y Teléfono
            buttonRMUsuario_FormGestionUsuariosA.Location = new Point(130, 262);
            buttonLimpiarCampos_FormGestionUsuariosA.Location = new Point(361, 262);
            groupBoxModificar_FormGestionUsuariosA.Size = new Size(655, 307);

            // Desplazar secciones inferiores
            groupBoxEliminar_FormGestionUsuariosA.Location = new Point(15, 335);
            groupBoxUsuarios_FormGestionUsuariosA.Location = new Point(15, 440);
            grpHistorial_FormGestionUsuariosA.Location = new Point(15, 641);

            var estiloTexto = new Action<TextBox>(tb =>
            {
                tb.BackColor = Color.FromArgb(13, 22, 40);
                tb.ForeColor = SystemColors.ControlLight;
            });

            // Campo Email
            var lblEmail = new Label { AutoSize = true, ForeColor = SystemColors.ControlLight, Location = new Point(7, 190), Text = "Email:" };
            textBoxEmailModificar = new TextBox { Location = new Point(129, 187), Size = new Size(177, 22) };
            estiloTexto(textBoxEmailModificar);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(lblEmail);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(textBoxEmailModificar);

            // Campo Teléfono
            var lblTelefono = new Label { AutoSize = true, ForeColor = SystemColors.ControlLight, Location = new Point(7, 217), Text = "Teléfono:" };
            textBoxTelefonoModificar = new TextBox { Location = new Point(129, 214), Size = new Size(177, 22) };
            estiloTexto(textBoxTelefonoModificar);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(lblTelefono);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(textBoxTelefonoModificar);

            // Expandir GroupBox historial y ajustar botón existente
            grpHistorial_FormGestionUsuariosA.Size = new Size(655, 250);
            btnRestaurarEstado_FormGestionUsuariosA.Location = new Point(455, 90);
            btnRestaurarEstado_FormGestionUsuariosA.Size = new Size(190, 35);
            lblInfoRestaurar_FormGestionUsuariosA.Size = new Size(190, 65);

            // Label "Campo a revertir:"
            var lblCampo = new Label { AutoSize = true, ForeColor = SystemColors.ControlLight, Location = new Point(455, 133), Text = "Campo a revertir:" };
            grpHistorial_FormGestionUsuariosA.Controls.Add(lblCampo);

            // ComboBox de atributos
            cboAtributoRevertir = new ComboBox
            {
                BackColor = Color.FromArgb(13, 22, 40),
                ForeColor = SystemColors.ControlLight,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(455, 152),
                Size = new Size(190, 22)
            };
            cboAtributoRevertir.Items.AddRange(new object[] { "Email", "Telefono", "Username" });
            cboAtributoRevertir.SelectedIndex = 0;
            grpHistorial_FormGestionUsuariosA.Controls.Add(cboAtributoRevertir);

            // Botón "Revertir campo seleccionado"
            btnRevertirAtributo_FormGestionUsuariosA = new Button
            {
                BackColor = Color.FromArgb(255, 140, 0),
                FlatStyle = FlatStyle.Flat,
                ForeColor = SystemColors.ControlLight,
                Location = new Point(455, 180),
                Size = new Size(190, 40),
                Text = "Revertir campo seleccionado"
            };
            btnRevertirAtributo_FormGestionUsuariosA.FlatAppearance.BorderSize = 0;
            btnRevertirAtributo_FormGestionUsuariosA.Click += btnRevertirAtributo_Click;
            grpHistorial_FormGestionUsuariosA.Controls.Add(btnRevertirAtributo_FormGestionUsuariosA);

            this.ClientSize = new Size(682, 911);
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

                comboBoxUsuarios.Items.Add(new ItemCombo { Display = "(nuevo usuario)", Value = null });

                foreach (var u in usuarios)
                {
                    var item = new ItemCombo { Display = u.Usuario, Value = u };
                    comboBoxUsuarios.Items.Add(item);
                    comboBoxUsuarioEliminar.Items.Add(new ItemCombo { Display = u.Usuario, Value = u });
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


        private void ComboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedItem is not ItemCombo item) return;

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
            textBoxContraseñaModificar.Text = string.Empty;
            checkBoxActivoModificar_FormGestionUsuariosA.Checked = !_usuarioSeleccionado.Baja;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Checked = _usuarioSeleccionado.Bloqueado;
            textBoxEmailModificar.Text = _usuarioSeleccionado.Email ?? string.Empty;
            textBoxTelefonoModificar.Text = _usuarioSeleccionado.Telefono ?? string.Empty;

            // Marcar permisos que ya tiene (cargados via BLL, no desde el objeto en memoria)
            var permisosActivos = _permisoBLL
                .ObtenerArbolDeUsuario(_usuarioSeleccionado.Id)
                .Select(c => c.Id_Permiso)
                .ToHashSet();
            PopularTreeView(permisosActivos);

            CargarHistorial(_usuarioSeleccionado.Id);
        }

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
                    Email = m.EmailGuardado ?? "",
                    Telefono = m.TelefonoGuardado ?? "",
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
                    Bloqueado = bloqueado,
                    Email = textBoxEmailModificar.Text.Trim(),
                    Telefono = textBoxTelefonoModificar.Text.Trim()
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


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarioEliminar.SelectedItem is not ItemCombo item || item.Value is not UsuarioBE usuario)
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
            textBoxEmailModificar.Clear();
            textBoxTelefonoModificar.Clear();
            checkBoxActivoModificar_FormGestionUsuariosA.Checked = true;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Checked = false;
            PopularTreeView(new HashSet<int>());
        }


        private void btnRevertirAtributo_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Seleccioná una fila del historial.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string atributo = cboAtributoRevertir.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(atributo))
                {
                    MessageBox.Show("Seleccioná el campo a revertir.", "Atención",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idHistorial = (int)dgvHistorial.SelectedRows[0].Cells["IdHistorial"].Value;
                string fechaRegistro = dgvHistorial.SelectedRows[0].Cells["Fecha"].Value?.ToString() ?? "";
                Guid idUsuarioRevertir = _usuarioSeleccionado.Id;

                var confirm = MessageBox.Show(
                    $"¿Revertir el campo '{atributo}' al valor que tenía en:\n{fechaRegistro}\n\n" +
                    "Se generará un nuevo registro en el historial con la acción 'REVERSION'.",
                    "Confirmar reversión de campo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes) return;

                _bll.RevertirAtributo(idUsuarioRevertir, idHistorial, atributo);

                MessageBox.Show($"Campo '{atributo}' revertido correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos();
                CargarHistorial(idUsuarioRevertir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al revertir",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class ItemCombo
        {
            public string Display { get; set; }
            public object Value { get; set; }
            public override string ToString() => Display;
        }
    }
}
