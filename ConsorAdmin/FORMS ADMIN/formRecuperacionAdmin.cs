using BE;
using BLL;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin
{
    public class formRecuperacionAdmin : Form
    {
        private DataGridView _dgv;
        private Label        _lblSinBackup;
        private Button       _btnRestaurar;
        private Button       _btnRecalcular;
        private Button       _btnCerrar;

        private readonly Guid _idAdmin;

        public formRecuperacionAdmin(Guid idAdmin)
        {
            _idAdmin = idAdmin;
            InicializarComponentes();
            this.Load += (s, e) => CargarComparacion();
        }

        private void InicializarComponentes()
        {
            this.SuspendLayout();

            this.Text            = "Panel de Recuperación — Administrador";
            this.ClientSize      = new Size(920, 540);
            this.StartPosition   = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            this.MinimizeBox     = false;

            var lblTitulo = new Label
            {
                Text      = "Se detectó una alteración de la integridad de datos. " +
                            "Comparación contra el último backup válido:",
                Location  = new Point(12, 12),
                Size      = new Size(896, 18),
                Font      = new Font("Segoe UI", 9f, FontStyle.Bold)
            };

            _lblSinBackup = new Label
            {
                Text      = "No hay backup disponible aún.\n" +
                            "Use «Generar línea base» para inicializar el sistema de integridad.",
                Location  = new Point(12, 40),
                Size      = new Size(896, 36),
                ForeColor = Color.DarkOrange,
                Visible   = false
            };

            _dgv = new DataGridView
            {
                Location                    = new Point(12, 40),
                Size                        = new Size(896, 410),
                ReadOnly                    = true,
                AllowUserToAddRows          = false,
                AllowUserToDeleteRows       = false,
                SelectionMode               = DataGridViewSelectionMode.FullRowSelect,
                AutoGenerateColumns         = false,
                AutoSizeColumnsMode         = DataGridViewAutoSizeColumnsMode.Fill,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                RowHeadersVisible           = false,
                BorderStyle                 = BorderStyle.Fixed3D
            };

            _dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colConsorcio", HeaderText = "Consorcio (ID)",
                DataPropertyName = "IdConsorcio", FillWeight = 25
            });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCampo", HeaderText = "Campo",
                DataPropertyName = "Campo", FillWeight = 20
            });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBackup", HeaderText = "Valor en backup",
                DataPropertyName = "ValorBackup", FillWeight = 22
            });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colActual", HeaderText = "Valor actual (BD)",
                DataPropertyName = "ValorActual", FillWeight = 22
            });
            _dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTipo", HeaderText = "Tipo",
                DataPropertyName = "TipoDiferencia", FillWeight = 11
            });

            _dgv.CellFormatting += Dgv_CellFormatting;

            _btnRestaurar = new Button
            {
                Text    = "Restaurar desde backup",
                Location = new Point(12, 463),
                Size    = new Size(190, 30),
                Enabled = false
            };
            _btnRestaurar.Click += BtnRestaurar_Click;

            _btnRecalcular = new Button
            {
                Text     = "Recalcular dígitos (aceptar estado actual)",
                Location = new Point(212, 463),
                Size     = new Size(280, 30)
            };
            _btnRecalcular.Click += BtnRecalcular_Click;

            _btnCerrar = new Button
            {
                Text     = "Cerrar",
                Location = new Point(502, 463),
                Size     = new Size(90, 30)
            };
            _btnCerrar.Click += (s, e) => this.Close();

            this.Controls.AddRange(new System.Windows.Forms.Control[]
            {
                lblTitulo, _lblSinBackup, _dgv, _btnRestaurar, _btnRecalcular, _btnCerrar
            });

            this.ResumeLayout(false);
        }

        private void CargarComparacion()
        {
            try
            {
                var diferencias = new VerificadorBLL().CompararConBackup(_idAdmin);

                if (diferencias == null)
                {
                    // Sin backup: solo ofrecer generar la línea base
                    _dgv.Visible          = false;
                    _lblSinBackup.Visible = true;
                    _btnRestaurar.Enabled = false;
                    _btnRecalcular.Text   = "Generar línea base (primera vez)";
                    return;
                }

                _dgv.Visible          = true;
                _lblSinBackup.Visible = false;
                _btnRecalcular.Text   = "Recalcular dígitos (aceptar estado actual)";

                _dgv.DataSource = diferencias.Select(d => new
                {
                    d.IdConsorcio,
                    d.Campo,
                    d.ValorBackup,
                    d.ValorActual,
                    TipoDiferencia = d.TipoDiferencia.ToString()
                }).ToList();

                // Habilitado siempre que exista backup (ya verificado arriba);
                // no depende de si hay faltantes, sobrantes o modificadas.
                _btnRestaurar.Enabled = true;
                _btnRestaurar.Text    = "Restaurar desde backup";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la comparación:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _dgv.Rows.Count) return;
            var tipo = _dgv.Rows[e.RowIndex].Cells["colTipo"]?.Value?.ToString();
            _dgv.Rows[e.RowIndex].DefaultCellStyle.BackColor = tipo switch
            {
                "Modificada" => Color.FromArgb(255, 255, 200),
                "Faltante"   => Color.FromArgb(255, 200, 200),
                "Sobrante"   => Color.FromArgb(200, 230, 255),
                _            => Color.White
            };
        }


        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            var conf = MessageBox.Show(
                "Esta acción dejará la tabla CONSORCIO exactamente igual al backup:\n\n" +
                "  • MODIFICADAS  → se restauran los campos del backup\n" +
                "  • FALTANTES    → se re-insertan las filas borradas\n" +
                "  • SOBRANTES    → se eliminan (puede fallar si tienen registros dependientes)\n\n" +
                "¿Confirma la restauración?",
                "Confirmar restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            try
            {
                var resultado = new VerificadorBLL().RestaurarDesdeBackup(_idAdmin);

                string msg = "Restauración completada:\n" +
                    $"  • {resultado.Actualizadas} fila(s) actualizada(s)\n" +
                    $"  • {resultado.Insertadas} fila(s) insertada(s)\n" +
                    $"  • {resultado.Eliminadas} fila(s) eliminada(s)";

                if (resultado.Errores.Count > 0)
                    msg += "\n\nOperaciones fallidas:\n" +
                           string.Join("\n", resultado.Errores.Select(e => $"  • {e}"));

                msg += "\n\nCierre este panel para continuar.";

                MessageBox.Show(msg, "Restauración", MessageBoxButtons.OK,
                    resultado.Errores.Count == 0 ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al restaurar:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnRecalcular_Click(object sender, EventArgs e)
        {
            string advertencia = _lblSinBackup.Visible
                ? "Esta acción calculará y guardará los dígitos verificadores por primera vez.\n\n¿Confirma?"
                : "Esta acción acepta el estado ACTUAL de la BD como válido y regenera los\n" +
                  "dígitos verificadores y el backup de referencia.\n\n" +
                  "Solo hágalo si verificó manualmente que los datos son correctos.\n\n¿Confirma?";

            var conf = MessageBox.Show(advertencia, "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (conf != DialogResult.Yes) return;

            try
            {
                new VerificadorBLL().GenerarDigitos();
                MessageBox.Show("Dígitos generados correctamente. Cierre este panel para continuar.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar dígitos:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
