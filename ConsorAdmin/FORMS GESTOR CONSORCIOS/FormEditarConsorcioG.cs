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
    public partial class FormEditarConsorcioG : Form
    {
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private ConsorcioBE _consorcioSeleccionado = null;
        
        public FormEditarConsorcioG()
        {
            InitializeComponent();
        }

        private void FormEdificiosG_Load(object sender, EventArgs e)
        {
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

        // ── Cargar grilla con los consorcios del gestor ──────────────────────
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

        // ── Seleccionar consorcio del combo para editar ─────────────────────
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

        // ── Guardar: crea o edita según si hay uno seleccionado ──────────────
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
            comboBoxEdificios.SelectedIndex = -1;
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxCantUnid.Text = "";
        }
    }


}

