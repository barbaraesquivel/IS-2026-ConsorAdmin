using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formBitacoraA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly ILogBitacoraBLL _bll = new LogBitacoraBLL();
        private readonly IPermisoBLL _permisoBLL = new PermisoBLL();

        // Resultados actuales (para exportar)
        private List<LogBitacoraBE> _resultados = new();

        public formBitacoraA()
        {
            InitializeComponent();
            this.Load += FormHistoriaA_Load;
            btnConsultar_FormBitacoraA.Click += BtnConsultar_Click;
            btnLimpiarFiltros_FormBitacoraA.Click += BtnLimpiarFiltros_Click;
            btnExportar.Click += BtnExportar_Click;
        }

        private void FormHistoriaA_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
            var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;
            if (!_permisoBLL.TienePatente(idUsuario, CodigosPermiso.ConsultarBitacora))
            {
                MessageBox.Show("No tiene permisos para acceder a esta sección.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            CargarCombos();
        }

        // ── Carga de combos ───────────────────────────────────────────────────

        private void CargarCombos()
        {
            try
            {
                // Usuarios
                cmbUsuario.Items.Clear();
                cmbUsuario.Items.Add(new ComboItem { Display = "(Todos)", Value = null });
                foreach (var (id, username) in _bll.ObtenerUsuariosConLogs())
                    cmbUsuario.Items.Add(new ComboItem { Display = username, Value = id });
                cmbUsuario.DisplayMember = "Display";
                cmbUsuario.SelectedIndex = 0;

                // Módulos
                cmbModulo.Items.Clear();
                cmbModulo.Items.Add("(Todos)");
                foreach (var m in _bll.ObtenerModulos())
                    cmbModulo.Items.Add(m);
                cmbModulo.SelectedIndex = 0;

                // Acciones
                cmbAccion.Items.Clear();
                cmbAccion.Items.Add("(Todas)");
                foreach (var a in _bll.ObtenerAcciones())
                    cmbAccion.Items.Add(a);
                cmbAccion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar filtros: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Consultar ─────────────────────────────────────────────────────────

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var filtro = new FiltroBitacoraBE
                {
                    IdUsuario = (cmbUsuario.SelectedItem as ComboItem)?.Value as string,
                    FechaDesde = dtpFechaDesde.Checked ? dtpFechaDesde.Value.Date : (DateTime?)null,
                    FechaHasta = dtpFechaHasta.Checked ? dtpFechaHasta.Value.Date : (DateTime?)null,
                    Modulo = cmbModulo.SelectedIndex > 0 ? cmbModulo.SelectedItem?.ToString() : null,
                    Accion = cmbAccion.SelectedIndex > 0 ? cmbAccion.SelectedItem?.ToString() : null
                };

                _resultados = _bll.Consultar(filtro);

                if (_resultados.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Sin resultados",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvBitacora.DataSource = null;
                    lblTotalRegistros.Text = "Total: 0 registros";
                    return;
                }

                MostrarEnGrilla(_resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnGrilla(List<LogBitacoraBE> datos)
        {
            try
            {
                var tabla = datos.Select(l => new
                {
                    FechaHora = l.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
                    Usuario = l.usuarioBE?.Usuario ?? l.Id_Usuario.ToString(),
                    Modulo = l.Modulo,
                    Accion = l.Accion,
                    Detalle = l.Detalle ?? string.Empty
                }).ToList();

                dgvBitacora.DataSource = tabla;
                dgvBitacora.AutoResizeColumns();
                lblTotalRegistros.Text = $"Total: {datos.Count} registros";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ── Limpiar ───────────────────────────────────────────────────────────

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {

            cmbUsuario.SelectedIndex = 0;
            dtpFechaDesde.Checked = false;
            dtpFechaHasta.Checked = false;
            cmbModulo.SelectedIndex = 0;
            cmbAccion.SelectedIndex = 0;
            dgvBitacora.DataSource = null;
            lblTotalRegistros.Text = "Total: 0 registros";
            _resultados.Clear();
        }

        // ── Exportar CSV ──────────────────────────────────────────────────────

        private void BtnExportar_Click(object sender, EventArgs e)
        {

            if (_resultados == null || _resultados.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Exportar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var dlg = new SaveFileDialog
            {
                Filter = "Archivos CSV (*.csv)|*.csv",
                FileName = $"bitacora_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
            };

            if (dlg.ShowDialog() != DialogResult.OK) return;

            try
            {
                var exportar = _resultados.Select(l => new
                {
                    FechaHora = l.FechaHora.ToString("dd/MM/yyyy HH:mm:ss"),
                    Usuario = l.usuarioBE?.Usuario ?? l.Id_Usuario.ToString(),
                    Modulo = l.Modulo,
                    Accion = l.Accion,
                    Detalle = l.Detalle ?? string.Empty
                });

                CsvExporter.Exportar(exportar, dlg.FileName);

                var idUsuario = SessionManager.ObtenerInstancia.Usuario.Id;
                _bll.RegistrarExportacion(idUsuario, _resultados.Count);

                MessageBox.Show("Archivo guardado correctamente.", "Exportar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Clase auxiliar para ComboBox ──────────────────────────────────────

        private class ComboItem
        {
            public string Display { get; set; }
            public object Value { get; set; }
            public override string ToString() => Display;
        }

        private void formBitacoraA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado
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
            grpFiltros_FormBitacoraA.Tag = "grpFiltros_FormBitacoraA";
            lblUsuario_FormBitacoraA.Tag = "lblUsuario_FormBitacoraA";
            lblFechaDesde_FormBitacoraA.Tag = "lblFechaDesde_FormBitacoraA";
            lblFechaHasta_FormBitacoraA.Tag = "lblFechaHasta_FormBitacoraA";
            lblModulo_FormBitacoraA.Tag = "lblModulo_FormBitacoraA";
            lblAccion_FormBitacoraA.Tag = "lblAccion_FormBitacoraA";
            btnConsultar_FormBitacoraA.Tag = "btnConsultar_FormBitacoraA";
            btnLimpiarFiltros_FormBitacoraA.Tag = "btnLimpiarFiltros_FormBitacoraA";
            grpResultados_FormBitacoraA.Tag = "grpResultados_FormBitacoraA";
            btnExportar.Tag = "btnExportar";
        }
    }
}
