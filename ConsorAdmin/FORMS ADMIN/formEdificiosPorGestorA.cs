using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formEdificiosPorGestorA : Form
    {
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly GestorConsorcioBLL _gestorBLL = new GestorConsorcioBLL();
        private readonly UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private readonly PermisoBLL _permisoBLL = new PermisoBLL();

        public formEdificiosPorGestorA()
        {
            InitializeComponent();
            this.Load += formAsignarGestorA_Load;
            buttonVerEdificios.Click += buttonAsignar_Click;
        }

        private void formAsignarGestorA_Load(object sender, EventArgs e)
        {
            try
            {
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
            /*
            var consorcios = _consorcioBLL.ObtenerTodos();
            comboBoxEdificio.DataSource = null;
            comboBoxEdificio.DataSource = consorcios;
            comboBoxEdificio.DisplayMember = "Nombre";
            comboBoxEdificio.ValueMember = "Id_Consorcio";
            comboBoxEdificio.SelectedIndex = -1;
            */
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
                /*
                if (comboBoxEdificio.SelectedItem is not ConsorcioBE consorcio)
                    throw new Exception("Seleccione un edificio.");
                if (comboBoxGestor.SelectedItem is not UsuarioBE gestor)
                    throw new Exception("Seleccione un gestor.");

                _gestorBLL.CrearGestor(gestor.Id.ToString(), consorcio.Id_Consorcio);
                */
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
    }
}
