using BE;
using BLL;
using DAL;
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
    public partial class FormGestionarUnidadesG : Form
    {
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly UnidadBLL _unidadBLL = new UnidadBLL();
        private readonly ConsorcistaBLL consorcistaBLL = new ConsorcistaBLL();
        private readonly UnidadConsorcistaBLL _ucBLL = new UnidadConsorcistaBLL();

        public FormGestionarUnidadesG()
        {
            InitializeComponent();
        }
        private void FormGestionarUnidadesG_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            LimpiarFormularioUnidad();
        }
        private void buttonGuardarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificioAgregar.SelectedItem is not ConsorcioBE consorcio)
                    throw new Exception("Debe seleccionar un consorcio.");
                if (textBoxPisoModificar.Text == null || textBoxDptoModificar == null )
                {
                    throw new Exception("Debe llenar los campos.");
                }
                decimal? superficie = null;
                if (!string.IsNullOrWhiteSpace(textBoxSuperficieAgregar.Text))
                {
                    if (!decimal.TryParse(textBoxSuperficieAgregar.Text.Trim(), out decimal sup))
                        throw new Exception("La superficie debe ser un número válido.");
                    superficie = sup;
                }

                var unidadBE = new UnidadBE
                {
                    Piso = textBoxPisoAgregar.Text.Trim(),
                    Depto = textBoxDptoAgregar.Text.Trim(),
                    Superficie = superficie,
                    Id_Consorcio = consorcio.Id_Consorcio
                };


                _unidadBLL.Crear(unidadBE);
                MessageBox.Show("Unidad creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                Unidad_ConsorcistaBE unidad_ConsorcistaBE = new Unidad_ConsorcistaBE();
                unidad_ConsorcistaBE.Id_Unidad = Convert.ToString(unidadBE.Id_Unidad);
                unidad_ConsorcistaBE.Id_Consorcista = Convert.ToString(comboBoxConsorcista.SelectedValue);
                unidad_ConsorcistaBE.TipoVinculo = comboBoxTipoVinculoModificar.SelectedItem.ToString();

                _ucBLL.Asociar(unidadBE.Id_Unidad, unidad_ConsorcistaBE.Id_Consorcista, unidad_ConsorcistaBE.TipoVinculo);


                LimpiarFormularioUnidad();
                CargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar unidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LimpiarFormularioUnidad()
        {
            textBoxPisoAgregar.Text = string.Empty;
            textBoxDptoAgregar.Text = string.Empty;
            textBoxSuperficieAgregar.Text = string.Empty;

            textBoxPisoModificar.Text = string.Empty;
            textBoxSuperficieModificar.Text = string.Empty;
            textBoxDptoAgregar.Text = string.Empty;
            if (dataGridUnidades != null)
                dataGridUnidades.DataSource = null;
            dataGridUnidades.DataSource = null;
            dataGridUnidades.DataSource = _unidadBLL.ObtenerTodas();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificioAgregar.SelectedItem is not ConsorcioBE consorcio)
                    throw new Exception("Debe seleccionar un consorcio.");
                if (textBoxPisoModificar.Text == null || textBoxDptoModificar == null)
                {
                    throw new Exception("Debe llenar los campos.");
                }
                decimal? superficie = null;
                if (!string.IsNullOrWhiteSpace(textBoxSuperficieAgregar.Text))
                {
                    if (!decimal.TryParse(textBoxSuperficieAgregar.Text.Trim(), out decimal sup))
                        throw new Exception("La superficie debe ser un número válido.");
                    superficie = sup;
                }
                if (comboBoxUnidadModificar.SelectedItem is not UnidadBE unidadBE)
                {
                    throw new Exception("Seleccione una Unidad válida.");

                }

                unidadBE = new UnidadBE()
                {
                    Id_Unidad = Convert.ToInt32(comboBoxUnidadModificar.SelectedValue),
                    Superficie = superficie,
                    Piso = textBoxPisoModificar.Text,
                    Depto = textBoxDptoModificar.Text,
                    Id_Consorcio = consorcio.Id_Consorcio,
                };

                _unidadBLL.Actualizar(unidadBE);
                MessageBox.Show("Unidad actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Unidad_ConsorcistaBE unidad_ConsorcistaBE = new Unidad_ConsorcistaBE();
                unidad_ConsorcistaBE.Id_Unidad = Convert.ToString(unidadBE.Id_Unidad);
                unidad_ConsorcistaBE.Id_Consorcista = Convert.ToString(comboBoxConsorcista.SelectedValue);
                unidad_ConsorcistaBE.TipoVinculo = comboBoxTipoVinculoModificar.SelectedItem.ToString();

                _ucBLL.Asociar(unidadBE.Id_Unidad, unidad_ConsorcistaBE.Id_Consorcista, unidad_ConsorcistaBE.TipoVinculo);

                LimpiarFormularioUnidad();
                CargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar unidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUnidadEliminar.SelectedItem is not UnidadBE unidadBE)
                {
                    throw new Exception("Unidad invalida.");
                }
                unidadBE = _unidadBLL.ObtenerPorId(Convert.ToInt32(comboBoxUnidadEliminar.SelectedValue.ToString()));
                
                _unidadBLL.Eliminar(unidadBE);

                Unidad_ConsorcistaBE unidad_ConsorcistaBE = _ucBLL.ObtenerPorUnidad(unidadBE.Id_Unidad).FirstOrDefault();
                _ucBLL.Eliminar(unidad_ConsorcistaBE);

                MessageBox.Show("Unidad eliminada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormularioUnidad();
                CargarGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarGrilla()
        {
            try
            {
                var unidades = _unidadBLL.ObtenerTodas();
                comboBoxUnidadModificar.DataSource = null;
                comboBoxUnidadModificar.DataSource = unidades;

                comboBoxUnidadModificar.DisplayMember = "Descripcion";
                comboBoxUnidadModificar.ValueMember = "Id_Unidad";

                var unidades1 = _unidadBLL.ObtenerTodas();
                comboBoxUnidadEliminar.DataSource = null;

                comboBoxUnidadEliminar.DataSource = unidades1;
                comboBoxUnidadEliminar.DisplayMember = "Descripcion";
                comboBoxUnidadEliminar.ValueMember = "Id_Unidad";

                var consorcistas = consorcistaBLL.ObtenerTodos();
                comboBoxConsorcistaAgregar.DataSource = null;
                comboBoxConsorcistaAgregar.DataSource = consorcistas;
                comboBoxConsorcistaAgregar.DisplayMember = "Descripcion";
                comboBoxConsorcistaAgregar.ValueMember = "Id_Consorcista";

                var consorcistas1 = consorcistaBLL.ObtenerTodos();
                comboBoxConsorcista.DataSource = null;
                comboBoxConsorcista.DataSource = consorcistas1;
                comboBoxConsorcista.DisplayMember = "Descripcion";
                comboBoxConsorcista.ValueMember = "Id_Consorcista";

                // Cargar consorcios en combo superior
                var consorcios = _consorcioBLL.ObtenerConsorcios();
                comboBoxEdificioAgregar.DataSource = null;
                comboBoxEdificioAgregar.DataSource = consorcios;
                comboBoxEdificioAgregar.DisplayMember = "Nombre";
                comboBoxEdificioAgregar.ValueMember = "Id_Consorcio";
                comboBoxEdificioAgregar.SelectedIndex = -1;

                var consorcios1 = _consorcioBLL.ObtenerConsorcios();
                comboBoxEdificioModificar.DataSource = null;
                comboBoxEdificioModificar.DataSource = consorcios;
                comboBoxEdificioModificar.DisplayMember = "Nombre";
                comboBoxEdificioModificar.ValueMember = "Id_Consorcio";
                comboBoxEdificioModificar.SelectedIndex = -1;

                // Cargar tipos de vinculo para CU08
                comboBoxTipoVinculo.Items.Clear();
                comboBoxTipoVinculo.Items.Add("Propietario");
                comboBoxTipoVinculo.Items.Add("Inquilino");

                comboBoxTipoVinculoModificar.Items.Clear();
                comboBoxTipoVinculoModificar.Items.Add("Propietario");
                comboBoxTipoVinculoModificar.Items.Add("Inquilino");

                LimpiarFormularioUnidad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
