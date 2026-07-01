using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formAsignarGestorA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly GestorConsorcioBLL _gestorBLL = new GestorConsorcioBLL();
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private readonly PermisoBLL _permisoBLL = new PermisoBLL();

        public formAsignarGestorA()
        {
            InitializeComponent();
            this.Load += formAsignarGestorA_Load;
            buttonAsignarGestorgroupBoxAsignarGestor_FormAsignarGestor.Click += buttonAsignar_Click;
        }

        private void formAsignarGestorA_Load(object sender, EventArgs e)
        {
            try
            {
                AsignarTags();
                SessionManager.SuscribirObservador(this);
                Traducir();
                CargarCombos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCombos()
        {
            var consorcios = _consorcioBLL.ObtenerTodos();
            comboBoxEdificio.DataSource = null;
            comboBoxEdificio.DataSource = consorcios;
            comboBoxEdificio.DisplayMember = "Nombre";
            comboBoxEdificio.ValueMember = "Id_Consorcio";
            comboBoxEdificio.SelectedIndex = -1;

            var gestores = new List<UsuarioBE>();
            foreach (var user in _usuarioBLL.ObtenerTodos())
            {
                if (_permisoBLL.TieneAlgunaPatenteDeFamilia(user.Id, "GE200"))
                    gestores.Add(user);
            }
            comboBoxGestor.DataSource = null;
            comboBoxGestor.DataSource = gestores;
            comboBoxGestor.DisplayMember = "Usuario";
            comboBoxGestor.ValueMember = "Id";
            comboBoxGestor.SelectedIndex = -1;
        }

        private void CargarGrilla()
        {
            var consorcios = _consorcioBLL.ObtenerTodos();
            var filas = consorcios.Select(c => new
            {
                Edificio = c.Nombre,
                Codigo = c.Id_Consorcio,
                Gestores = c.gestorConsorcios != null && c.gestorConsorcios.Count > 0
                    ? string.Join(", ", c.gestorConsorcios
                        .Select(g => g.usuarioBE?.Usuario ?? g.Id_Usuario.ToString()))
                    : "(sin gestor)"
            }).ToList();

            dataGridEdificios.DataSource = null;
            dataGridEdificios.DataSource = filas;
        }

        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificio.SelectedItem is not ConsorcioBE consorcio)
                    throw new Exception("Seleccione un edificio.");
                if (comboBoxGestor.SelectedItem is not UsuarioBE gestor)
                    throw new Exception("Seleccione un gestor.");

                _gestorBLL.CrearGestor(gestor.Id.ToString(), consorcio.Id_Consorcio);

                MessageBox.Show("Gestor asignado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            groupBoxAsignarGestor_FormAsignarGestor.Tag = "groupBoxAsignarGestor_FormAsignarGestor";
            labelGestorgroupBoxAsignarGestor_FormAsignarGestor.Tag = "labelGestorgroupBoxAsignarGestor_FormAsignarGestor";
            buttonAsignarGestorgroupBoxAsignarGestor_FormAsignarGestor.Tag = "buttonAsignarGestorgroupBoxAsignarGestor_FormAsignarGestor";
            labelEdificiogroupBoxAsignarGestor_FormAsignarGestor.Tag = "labelEdificiogroupBoxAsignarGestor_FormAsignarGestor";
            groupBoxEdificiosgroupBoxAsignarGestor_FormAsignarGestor.Tag = "groupBoxEdificiosgroupBoxAsignarGestor_FormAsignarGestor";
        }

        private void formAsignarGestorA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado

        }
    }
}
