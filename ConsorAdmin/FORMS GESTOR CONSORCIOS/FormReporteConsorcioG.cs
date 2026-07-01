using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    public partial class FormReporteConsorcioG : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private ConsorcioBE _consorcioSeleccionado = null;

        public FormReporteConsorcioG()
        {
            InitializeComponent();
        }

        private void FormEdificiosG_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();

            try
            {
                CargarGrilla();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReporteConsorcioG_FormClosing(object sender, FormClosingEventArgs e)
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
            groupBoxEdificio_FormReporteConsorcioG.Tag = "groupBoxEdificio_FormReporteConsorcioG";
            groupBoxEditarEdificios_FormReporteConsorcioG.Tag = "groupBoxEditarEdificios_FormReporteConsorcioG";
            buttonGuardar_FormReporteConsorcioG.Tag = "buttonGuardar_FormReporteConsorcioG";
            labelCantUnid_FormReporteConsorcioG.Tag = "labelCantUnid_FormReporteConsorcioG";
            labelNombre_FormReporteConsorcioG.Tag = "labelNombre_FormReporteConsorcioG";
            labelDireccion_FormReporteConsorcioG.Tag = "labelDireccion_FormReporteConsorcioG";
            labelEdificio_FormReporteConsorcioG.Tag = "labelEdificio_FormReporteConsorcioG";
        }

        private void CargarGrilla()
        {
            try
            {
                
                var consorcios = _consorcioBLL.ObtenerConsorcios();
                dataGridViewEdificios.DataSource = null;
                dataGridViewEdificios.DataSource = consorcios.Select(c => new
                {
                    ID = c.Id_Consorcio,
                    Nombre = c.Nombre,
                    Direccion = c.Direccion,
                    Unidades = c.CantUnidades
                }).ToList();

                // Cargar combo para edición
                comboBoxEdificios.DataSource = null;
                comboBoxEdificios.DataSource = consorcios;
                comboBoxEdificios.DisplayMember = "Nombre";
                comboBoxEdificios.ValueMember = "Id_Consorcio";
                comboBoxEdificios.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar consorcios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEdificios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificios.SelectedItem is ConsorcioBE seleccionado)
                {
                    _consorcioSeleccionado = seleccionado;
                    textBoxNombre.Text = seleccionado.Nombre;
                    textBoxDireccion.Text = seleccionado.Direccion;
                    textBoxCantUnid.Text = seleccionado.CantUnidades.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxCantUnid.Text.Trim(), out int cantUnidades))
                    throw new Exception("La cantidad de unidades debe ser un número entero.");

                var consorcioBE = new ConsorcioBE
                {
                    Nombre = textBoxNombre.Text.Trim(),
                    Direccion = textBoxDireccion.Text.Trim(),
                    CantUnidades = cantUnidades
                };

                // Editar existente
                consorcioBE.Id_Consorcio = _consorcioSeleccionado.Id_Consorcio;
                _consorcioBLL.Actualizar(consorcioBE);
                MessageBox.Show("Consorcio actualizado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarFormulario()
        {
            _consorcioSeleccionado = null;
            textBoxNombre.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxCantUnid.Text = string.Empty;
            comboBoxEdificios.SelectedIndex = -1;
        }
    }


}

