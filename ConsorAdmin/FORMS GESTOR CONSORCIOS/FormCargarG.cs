using BE;
using BLL;
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
    public partial class FormCargarG : Form
    {
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly ServicioBLL _servicioBLL = new ServicioBLL();
        public FormCargarG()
        {
            InitializeComponent();
        }
        private void FormCargarG_Load(object sender, EventArgs e)
        {
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


    }
}
