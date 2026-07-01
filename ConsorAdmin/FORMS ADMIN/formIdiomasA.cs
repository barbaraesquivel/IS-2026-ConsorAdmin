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
    public partial class formIdiomasA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _bll = new TraductorBLL();
        private List<IdiomaBE> _idiomas;

        public formIdiomasA()
        {
            InitializeComponent();
        }

        public void ActualizarIdioma(IdiomaBE idioma)
        {
            try
            {
                if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
                else Traducir(idioma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formIdiomasA_Load(object sender, EventArgs e)
        {
            try
            {
                AsignarTags();
                SessionManager.SuscribirObservador(this);

                CargarIdiomas();
                Traducir();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formIdiomasA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado
        }

        // -----------------------------------------------------------------
        // COMBO IDIOMAS — al cambiar, recarga la grilla para el idioma elegido
        // -----------------------------------------------------------------
        private void CargarIdiomas()
        {
            try
            {
                cboIdiomas.SelectedIndexChanged -= cboIdiomas_SelectedIndexChanged;

                _idiomas = _bll.ObtenerIdiomas();
                cboIdiomas.DataSource = null;
                cboIdiomas.DataSource = new List<IdiomaBE>(_idiomas);
                cboIdiomas.DisplayMember = "Nombre";
                cboIdiomas.ValueMember = "IdIdioma";

                cboIdiomas.SelectedIndexChanged += cboIdiomas_SelectedIndexChanged;

                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboIdiomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarGrid();
        }

        // -----------------------------------------------------------------
        // GRILLA — combina todas las claves de ETIQUETA con su texto en
        // español ("Original") y la traducción existente para el idioma
        // seleccionado ("Traduccion", vacía si no existe aún).
        // -----------------------------------------------------------------
        private void CargarGrid()
        {
            try
            {
                dgvTraducciones.Rows.Clear();
                if (cboIdiomas.SelectedItem is not IdiomaBE idioma) return;

                var filas = _bll.ObtenerParaEdicion(idioma.IdIdioma);
                foreach (var fila in filas)
                    dgvTraducciones.Rows.Add(fila.Clave, fila.Original, fila.Traduccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // -----------------------------------------------------------------
        // AGREGAR IDIOMA
        // -----------------------------------------------------------------
        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Microsoft.VisualBasic.Interaction.InputBox(
                    "Nombre del nuevo idioma:", "Nuevo idioma");

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre del idioma no puede estar vacío.",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nuevo = _bll.AgregarIdioma(nombre.Trim());
                CargarIdiomas();
                cboIdiomas.SelectedValue = nuevo.IdIdioma;

                MessageBox.Show($"Idioma '{nuevo.Nombre}' agregado. Ahora podés completar sus traducciones.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // -----------------------------------------------------------------
        // GUARDAR TRADUCCIONES — persiste todas las filas con texto cargado
        // -----------------------------------------------------------------
        private void btnGuardarTraducciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboIdiomas.SelectedItem is not IdiomaBE idioma)
                {
                    MessageBox.Show("Seleccioná un idioma antes de guardar.",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dgvTraducciones.Rows)
                {
                    if (row.IsNewRow) continue;

                    string clave = row.Cells[colClave.Index].Value?.ToString();
                    string texto = row.Cells[colTraduccion.Index].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(clave) || string.IsNullOrWhiteSpace(texto)) continue;

                    _bll.GuardarTraduccion(idioma.IdIdioma, clave, texto, null);
                }

                MessageBox.Show("Traducciones guardadas.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // -----------------------------------------------------------------
        // APLICAR IDIOMA — notifica a todos los forms abiertos (Observer)
        // -----------------------------------------------------------------
        private void btnAplicarIdioma_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboIdiomas.SelectedItem is not IdiomaBE idioma)
                {
                    MessageBox.Show("Seleccioná un idioma antes de aplicar.",
                        "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SessionManager.CambiarIdioma(idioma);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -----------------------------------------------------------------
        // Traducción del propio form
        // -----------------------------------------------------------------
        private void Traducir(IdiomaBE idioma = null)
        {
            try
            {
                idioma ??= SessionManager.IdiomaActual ?? _bll.ObtenerIdiomaDefault();
                var t = _bll.ObtenerTraducciones(idioma);
                TraducirControles(this.Controls, t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            labelGestiondeIdiomas_FormIdiomasA.Tag = "labelGestiondeIdiomas_FormIdiomasA";
            labelIdioma_FormIdiomasA.Tag = "labelIdioma_FormIdiomasA";
            buttonAgregarIdioma_FormIdiomasA.Tag = "buttonAgregarIdioma_FormIdiomasA";
            btnGuardarTraducciones_FormIdiomasA.Tag = "btnGuardarTraducciones_FormIdiomasA";
            btnAplicarIdioma_FormIdiomasA.Tag = "btnAplicarIdioma_FormIdiomasA";
            btnCancelar_FormIdiomasA.Tag = "btnCancelar_FormIdiomasA";
        }
    }
}
