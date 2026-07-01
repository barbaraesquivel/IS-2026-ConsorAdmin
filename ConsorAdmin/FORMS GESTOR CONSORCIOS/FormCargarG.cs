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
    public partial class FormCargarG : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly ServicioBLL _servicioBLL = new ServicioBLL();
        public FormCargarG()
        {
            InitializeComponent();
        }
        private void FormCargarG_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();

            try
            {
                // Cargar consorcios del gestor
                var consorcios = _consorcioBLL.ObtenerConsorcios();
                comboBoxEdificios.DataSource = consorcios;
                comboBoxEdificios.DisplayMember = "Nombre";
                comboBoxEdificios.ValueMember = "Id_Consorcio";
                comboBoxEdificios.SelectedIndex = -1;

                // Cargar rubros fijos
                comboBoxRubro.Items.Clear();
                comboBoxRubro.Items.AddRange(new[]
                    { "Limpieza", "Mantenimiento", "Seguridad", "Reparaciones", "Servicios", "Otros" });

                // Tipo de gasto
                comboBoxTipo.Items.Clear();
                comboBoxTipo.Items.AddRange(new[] { "Ordinario", "Extraordinario" });

                // Estado inicial del servicio
                comboBoxSituacion.Items.Clear();
                comboBoxSituacion.Items.AddRange(new[] { "Pendiente", "Aprobado", "Rechazado" });

                dateTimeFechaActual.Value = DateTime.Today;
                dateTimePickerVencimiento.Value = DateTime.Today.AddDays(10);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCargarG_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this);
        }

        private void buttonGuard_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificios.SelectedItem is not ConsorcioBE consorcio)
                    throw new Exception("Debe seleccionar un consorcio.");
                if (comboBoxSituacion.SelectedItem == null)
                    throw new Exception("Debe seleccionar una situacion.");
                if (!decimal.TryParse(textBoxImporte.Text.Trim(), out decimal monto))
                    throw new Exception("El importe debe ser un número válido.");

                var servicioBE = new ServicioBE
                {
                    Id_Consorcio = Guid.Parse(consorcio.Id_Consorcio),
                    Descripcion = $"{comboBoxTipo.SelectedItem} - {comboBoxRubro.SelectedItem} / {comboBoxSubrubro.Text}".Trim(' ', '-', '/'),
                    Fecha = dateTimeFechaActual.Value,
                    Monto = monto,
                    Estado = comboBoxSituacion.SelectedItem.ToString()
                };

                _servicioBLL.Crear(servicioBE);

                MessageBox.Show("Gasto registrado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar gasto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            comboBoxEdificios.SelectedIndex = -1;
            comboBoxRubro.SelectedIndex = -1;
            comboBoxSubrubro.Text = string.Empty;
            comboBoxTipo.SelectedIndex = -1;
            comboBoxSituacion.SelectedIndex = -1;
            textBoxImporte.Text = string.Empty;
            dateTimeFechaActual.Value = DateTime.Today;
            dateTimePickerVencimiento.Value = DateTime.Today.AddDays(10);
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
            groupBoxNuevaExp_FormCargarG.Tag = "groupBoxNuevaExp_FormCargarG";
            buttonGuard_FormCargarG.Tag = "buttonGuard_FormCargarG";
            buttonCancelar_FormCargarG.Tag = "buttonCancelar_FormCargarG";
            labelSituacion_FormCargarG.Tag = "labelSituacion_FormCargarG";
            labelFechaVencimiento_FormCargarG.Tag = "labelFechaVencimiento_FormCargarG";
            labelFecha_FormCargarG.Tag = "labelFecha_FormCargarG";
            labelImporte_FormCargarG.Tag = "labelImporte_FormCargarG";
            labelSubRubro_FormCargarG.Tag = "labelSubRubro_FormCargarG";
            labelRubro_FormCargarG.Tag = "labelRubro_FormCargarG";
            labelTipoExp_FormCargarG.Tag = "labelTipoExp_FormCargarG";
            labelEdificio_FormCargarG.Tag = "labelEdificio_FormCargarG";
        }

    }
}
