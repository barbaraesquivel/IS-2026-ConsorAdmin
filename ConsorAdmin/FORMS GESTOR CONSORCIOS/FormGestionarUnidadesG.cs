using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    public partial class FormGestionarUnidadesG : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly ConsorcioBLL _consorcioBLL = new ConsorcioBLL();
        private readonly UnidadBLL _unidadBLL = new UnidadBLL();
        private readonly ConsorcistaBLL _consorcistaBLL = new ConsorcistaBLL();
        private readonly UnidadConsorcistaBLL _ucBLL = new UnidadConsorcistaBLL();

        public FormGestionarUnidadesG()
        {
            InitializeComponent();
            comboBoxUnidadModificar.SelectedIndexChanged += comboBoxUnidadModificar_SelectedIndexChanged;
        }

        private void FormGestionarUnidadesG_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();

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

        private void FormGestionarUnidadesG_FormClosing(object sender, FormClosingEventArgs e)
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
            buttonEliminar_FormGestionarUnidadesG.Tag = "buttonEliminar_FormGestionarUnidadesG";
            labelEUnidad_FormGestionarUnidadesG.Tag = "labelEUnidad_FormGestionarUnidadesG";
            labelEliminarUnidad_FormGestionarUnidadesG.Tag = "labelEliminarUnidad_FormGestionarUnidadesG";
            groupBoxAgregarUnidades_FormGestionarUnidadesG.Tag = "groupBoxAgregarUnidades_FormGestionarUnidadesG";
            labelATipo_FormGestionarUnidadesG.Tag = "labelATipo_FormGestionarUnidadesG";
            buttonGuardarUnidad_FormGestionarUnidadesG.Tag = "buttonGuardarUnidad_FormGestionarUnidadesG";
            labelAEdificio_FormGestionarUnidadesG.Tag = "labelAEdificio_FormGestionarUnidadesG";
            labelAPiso_FormGestionarUnidadesG.Tag = "labelAPiso_FormGestionarUnidadesG";
            labelADpto_FormGestionarUnidadesG.Tag = "labelADpto_FormGestionarUnidadesG";
            labelASuperficie_FormGestionarUnidadesG.Tag = "labelASuperficie_FormGestionarUnidadesG";
            groupBoxEstado_FormGestionarUnidadesG.Tag = "groupBoxEstado_FormGestionarUnidadesG";
            labelETipo_FormGestionarUnidadesG.Tag = "labelETipo_FormGestionarUnidadesG";
            labelEditarUnidad_FormGestionarUnidadesG.Tag = "labelEditarUnidad_FormGestionarUnidadesG";
            buttonActualizar_FormGestionarUnidadesG.Tag = "buttonActualizar_FormGestionarUnidadesG";
            labelESuperficie_FormGestionarUnidadesG.Tag = "labelESuperficie_FormGestionarUnidadesG";
            labelEDpto_FormGestionarUnidadesG.Tag = "labelEDpto_FormGestionarUnidadesG";
            labelEPiso_FormGestionarUnidadesG.Tag = "labelEPiso_FormGestionarUnidadesG";
            labelEEdificio_FormGestionarUnidadesG.Tag = "labelEEdificio_FormGestionarUnidadesG";
            labelUnidades_FormGestionarUnidadesG.Tag = "labelUnidades_FormGestionarUnidadesG";
        }

        // ── AGREGAR UNIDAD ───────────────────────────────────────────────────
        private void buttonGuardarUnidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxEdificioAgregar.SelectedItem is not ConsorcioBE consorcio)
                    throw new ValidacionException("Debe seleccionar un consorcio.");

                decimal? superficie = null;
                if (!string.IsNullOrWhiteSpace(textBoxSuperficieAgregar.Text))
                {
                    if (!decimal.TryParse(textBoxSuperficieAgregar.Text.Trim(), out decimal sup))
                        throw new ValidacionException("La superficie debe ser un número válido.");
                    superficie = sup;
                }

                var unidadBE = new UnidadBE
                {
                    Piso = textBoxPisoAgregar.Text.Trim(),
                    Depto = textBoxDptoAgregar.Text.Trim(),
                    Superficie = superficie,
                    Id_Consorcio = consorcio.Id_Consorcio
                };

                int nuevoId = _unidadBLL.Crear(unidadBE);

               

                MessageBox.Show("Unidad creada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCamposAgregar();
                CargarCombos();
                CargarGrilla();
            }
            catch (ValidacionException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnidadDuplicadaException ex)
            {
                MessageBox.Show(ex.Message, "Unidad duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── MODIFICAR UNIDAD ─────────────────────────────────────────────────
        private void comboBoxUnidadModificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUnidadModificar.SelectedItem is not UnidadBE unidad) return;

            textBoxPisoModificar.Text = unidad.Piso;
            textBoxDptoModificar.Text = unidad.Depto;
            textBoxSuperficieModificar.Text = unidad.Superficie.HasValue
                ? unidad.Superficie.Value.ToString("F2")
                : "";

            foreach (var item in comboBoxEdificioModificar.Items)
            {
                if (item is ConsorcioBE c && c.Id_Consorcio == unidad.Id_Consorcio)
                {
                    comboBoxEdificioModificar.SelectedItem = c;
                    break;
                }
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUnidadModificar.SelectedItem is not UnidadBE unidadSeleccionada)
                    throw new ValidacionException("Seleccione una unidad válida.");

                if (comboBoxEdificioModificar.SelectedItem is not ConsorcioBE consorcio)
                    throw new ValidacionException("Debe seleccionar un consorcio.");

                decimal? superficie = null;
                if (!string.IsNullOrWhiteSpace(textBoxSuperficieModificar.Text))
                {
                    if (!decimal.TryParse(textBoxSuperficieModificar.Text.Trim(), out decimal sup))
                        throw new ValidacionException("La superficie debe ser un número válido.");
                    superficie = sup;
                }

                var unidadBE = new UnidadBE
                {
                    Id_Unidad = unidadSeleccionada.Id_Unidad,
                    Piso = textBoxPisoModificar.Text.Trim(),
                    Depto = textBoxDptoModificar.Text.Trim(),
                    Superficie = superficie,
                    Id_Consorcio = consorcio.Id_Consorcio
                };

                _unidadBLL.Actualizar(unidadBE);


                MessageBox.Show("Unidad actualizada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
                CargarGrilla();
            }
            catch (ValidacionException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnidadDuplicadaException ex)
            {
                MessageBox.Show(ex.Message, "Unidad duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (RelacionDuplicadaException ex)
            {
                MessageBox.Show(ex.Message, "Relación duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al guardar unidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── ELIMINAR UNIDAD ──────────────────────────────────────────────────
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxUnidadEliminar.SelectedItem is not UnidadBE unidadSel)
                    throw new ValidacionException("Seleccione una unidad válida.");

                var confirmacion = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar la unidad Piso {unidadSel.Piso} Dpto {unidadSel.Depto}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes) return;

                var unidadBE = _unidadBLL.ObtenerPorId(unidadSel.Id_Unidad);
                if (unidadBE == null)
                    throw new Exception("Unidad no encontrada.");

                foreach (var uc in _ucBLL.ObtenerPorUnidad(unidadBE.Id_Unidad))
                    _ucBLL.Eliminar(uc);

                _unidadBLL.Eliminar(unidadBE);

                MessageBox.Show("Unidad eliminada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarCombos();
                CargarGrilla();
            }
            catch (ValidacionException ex)
            {
                MessageBox.Show(ex.Message, "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── CARGA DE COMBOS Y GRILLA ─────────────────────────────────────────
        private void CargarCombos()
        {
            var unidades = _unidadBLL.ObtenerTodas();

            comboBoxUnidadModificar.DataSource = null;
            comboBoxUnidadModificar.DataSource = new List<UnidadBE>(unidades);
            comboBoxUnidadModificar.DisplayMember = "Descripcion";
            comboBoxUnidadModificar.ValueMember = "Id_Unidad";
            comboBoxUnidadModificar.SelectedIndex = -1;

            comboBoxUnidadEliminar.DataSource = null;
            comboBoxUnidadEliminar.DataSource = new List<UnidadBE>(unidades);
            comboBoxUnidadEliminar.DisplayMember = "Descripcion";
            comboBoxUnidadEliminar.ValueMember = "Id_Unidad";
            comboBoxUnidadEliminar.SelectedIndex = -1;

            var consorcistas = _consorcistaBLL.ObtenerTodos();

     

            var consorcios = _consorcioBLL.ObtenerConsorcios();

            comboBoxEdificioAgregar.DataSource = null;
            comboBoxEdificioAgregar.DataSource = new List<ConsorcioBE>(consorcios);
            comboBoxEdificioAgregar.DisplayMember = "Nombre";
            comboBoxEdificioAgregar.ValueMember = "Id_Consorcio";
            comboBoxEdificioAgregar.SelectedIndex = -1;

            comboBoxEdificioModificar.DataSource = null;
            comboBoxEdificioModificar.DataSource = new List<ConsorcioBE>(consorcios);
            comboBoxEdificioModificar.DisplayMember = "Nombre";
            comboBoxEdificioModificar.ValueMember = "Id_Consorcio";
            comboBoxEdificioModificar.SelectedIndex = -1;

            comboBoxTipoVinculo.Items.Clear();
            comboBoxTipoVinculo.Items.Add("Propietario");
            comboBoxTipoVinculo.Items.Add("Inquilino");

            comboBoxTipoVinculoModificar.Items.Clear();
            comboBoxTipoVinculoModificar.Items.Add("Propietario");
            comboBoxTipoVinculoModificar.Items.Add("Inquilino");
        }

        private void CargarGrilla()
        {
            var unidades = _unidadBLL.ObtenerTodas();
            var filas = unidades.Select(u => new
            {
                ID = u.Id_Unidad,
                Consorcio = u.Id_Consorcio,
                Piso = u.Piso,
                Dpto = u.Depto,
                Superficie = u.Superficie.HasValue ? u.Superficie.Value.ToString("F2") : "-",
                Consorcistas = u.unidadConsorcista != null && u.unidadConsorcista.Count > 0
                    ? string.Join(", ", u.unidadConsorcista
                        .Where(uc => uc.consorcistaBE != null)
                        .Select(uc => $"{uc.consorcistaBE.Usuario?.Usuario ?? "?"} ({uc.TipoVinculo})"))
                    : "(sin consorcistas)"
            }).ToList();

            dataGridUnidades.DataSource = null;
            dataGridUnidades.DataSource = filas;
        }

        private void LimpiarCamposAgregar()
        {
            comboBoxEdificioAgregar.SelectedIndex = -1;
            textBoxPisoAgregar.Clear();
            textBoxDptoAgregar.Clear();
            textBoxSuperficieAgregar.Clear();
            comboBoxTipoVinculo.SelectedIndex = -1;
        }
    }
}
