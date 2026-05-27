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

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formRegistrarEdificioA : Form
    {
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private ConsorcioBE _consorcioSeleccionado = new ConsorcioBE();
        private UnidadBLL unidadBLL = new UnidadBLL();
        private GestorConsorcioBLL gestorConsorcios = new GestorConsorcioBLL();
        private PermisoBLL permisoValidarBLL = new PermisoBLL();
        private UsuarioBLL usuarioBLL = new UsuarioBLL();

        public formRegistrarEdificioA()
        {
            InitializeComponent();
        }

        private void formRegistrarEdificioA_Load(object sender, EventArgs e)
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

                var consorcios = _consorcioBLL.ObtenerTodos();
                comboBoxEdificioModificar.DataSource = null;
                comboBoxEdificioModificar.DataSource = consorcios;
                comboBoxEdificioModificar.DisplayMember = "Nombre";
                comboBoxEdificioModificar.ValueMember = "Id_Consorcio";
                comboBoxEdificioModificar.SelectedIndex = -1;

                var consorcios1 = _consorcioBLL.ObtenerTodos();
                comboBoxEdificioEliminar.DataSource = null;
                comboBoxEdificioEliminar.DataSource = consorcios1;
                comboBoxEdificioEliminar.DisplayMember = "Nombre";
                comboBoxEdificioEliminar.ValueMember = "Id_Consorcio";
                comboBoxEdificioEliminar.SelectedIndex = -1;

                var gestores = new List<UsuarioBE>();
                foreach (var user in usuarioBLL.ObtenerTodos())
                {
                    if (permisoValidarBLL.TieneAlgunaPatenteDeFamilia(user.Id, "GE200") == true)
                    {
                        gestores.Add(user);
                    }
                }
                comboBoxGestor.DataSource = null;
                comboBoxGestor.DataSource = gestores;
                comboBoxGestor.DisplayMember = "Usuario";
                comboBoxGestor.ValueMember = "Id";
                comboBoxGestor.SelectedIndex = -1;

                comboBoxGestorModificar.DataSource = null;
                comboBoxGestorModificar.DataSource = gestores;
                comboBoxGestorModificar.DisplayMember = "Usuario";
                comboBoxGestorModificar.ValueMember = "Id";
                comboBoxGestorModificar.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar consorcios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Seleccionar consorcio del combo para editar ─────────────────────
        private void comboBoxEdificioModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificioModificar.SelectedItem is ConsorcioBE seleccionado)
                {
                    _consorcioSeleccionado = seleccionado;
                    textBoxNombreModificar.Text = seleccionado.Nombre;
                    textBoxDireccionModificar.Text = seleccionado.Direccion;
                    textBoxCantModificar.Text = seleccionado.CantUnidades.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            _consorcioSeleccionado = null;
            textBoxCodigo.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxDireccion.Text = string.Empty;
            textBoxCant.Text = string.Empty;

            textBoxCodigoModificar.Text = string.Empty;
            textBoxNombreModificar.Text = string.Empty;
            textBoxDireccionModificar.Text = string.Empty;
            textBoxCantModificar.Text = string.Empty;

            comboBoxEdificioModificar.SelectedIndex = -1;
            comboBoxGestor.SelectedIndex = -1;
            comboBoxGestorModificar.SelectedIndex = -1;
            comboBoxEdificioEliminar.SelectedIndex = -1;



        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxCant.Text.Trim(), out int cantUnidades))
                    throw new Exception("La cantidad de unidades debe ser un número entero.");

                var consorcioBE = new ConsorcioBE
                {
                    Nombre = textBoxNombre.Text.Trim(),
                    Direccion = textBoxDireccion.Text.Trim(),
                    Id_Consorcio = textBoxCodigo.Text.Trim(),
                    CantUnidades = cantUnidades
                };


                // Nuevo consorcio: generar ID
                if (_consorcioBLL.ObtenerPorId(consorcioBE.Id_Consorcio) != null)
                {
                    throw new Exception("Codigo de edificio ya cargado en otro.");

                }
                _consorcioBLL.Crear(consorcioBE);
                gestorConsorcios.CrearGestor(comboBoxGestor.SelectedValue.ToString(), consorcioBE.Id_Consorcio);

                MessageBox.Show("Consorcio creado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);



                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxCantModificar.Text.Trim(), out int cantUnidades))
                    throw new Exception("La cantidad de unidades debe ser un número entero.");

                var consorcioBE = new ConsorcioBE
                {
                    Nombre = textBoxNombreModificar.Text.Trim(),
                    Direccion = textBoxDireccionModificar.Text.Trim(),
                    CantUnidades = cantUnidades
                };




                // Editar existente
                consorcioBE.Id_Consorcio = _consorcioSeleccionado.Id_Consorcio;
                _consorcioBLL.Actualizar(consorcioBE);
                gestorConsorcios.CrearGestor(comboBoxGestorModificar.SelectedValue.ToString(), consorcioBE.Id_Consorcio);
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

        private void buttonDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBoxEdificioEliminar.SelectedItem is not ConsorcioBE consorcioBE)
                {
                    MessageBox.Show("Seleccione un edificio correcto.");
                }

                consorcioBE = _consorcioBLL.ObtenerPorId(comboBoxEdificioEliminar.SelectedValue.ToString());
                foreach(var unidad in unidadBLL.ObtenerPorConsorcio(consorcioBE.Id_Consorcio))
                {
                    unidadBLL.Eliminar(unidad);
                }
                foreach (var gestor in gestorConsorcios.ObtenerPorConsorcio(consorcioBE.Id_Consorcio))
                {
                    gestorConsorcios.Eliminar(gestor);
                }
                _consorcioBLL.Eliminar(consorcioBE);
                MessageBox.Show("Consorcio eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                CargarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
