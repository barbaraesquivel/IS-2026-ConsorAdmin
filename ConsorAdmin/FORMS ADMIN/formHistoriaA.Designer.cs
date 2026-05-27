namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formHistoriaA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grpFiltros = new System.Windows.Forms.GroupBox();
            lblUsuario = new System.Windows.Forms.Label();
            cmbUsuario = new System.Windows.Forms.ComboBox();
            lblFechaDesde = new System.Windows.Forms.Label();
            dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            lblFechaHasta = new System.Windows.Forms.Label();
            dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            lblModulo = new System.Windows.Forms.Label();
            cmbModulo = new System.Windows.Forms.ComboBox();
            lblAccion = new System.Windows.Forms.Label();
            cmbAccion = new System.Windows.Forms.ComboBox();
            btnConsultar = new System.Windows.Forms.Button();
            btnLimpiarFiltros = new System.Windows.Forms.Button();
            grpResultados = new System.Windows.Forms.GroupBox();
            dgvBitacora = new System.Windows.Forms.DataGridView();
            lblTotalRegistros = new System.Windows.Forms.Label();
            btnExportar = new System.Windows.Forms.Button();

            grpFiltros.SuspendLayout();
            grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();

            // grpFiltros
            grpFiltros.BackColor = System.Drawing.Color.FromArgb(8, 14, 26);
            grpFiltros.Controls.Add(lblUsuario);
            grpFiltros.Controls.Add(cmbUsuario);
            grpFiltros.Controls.Add(lblFechaDesde);
            grpFiltros.Controls.Add(dtpFechaDesde);
            grpFiltros.Controls.Add(lblFechaHasta);
            grpFiltros.Controls.Add(dtpFechaHasta);
            grpFiltros.Controls.Add(lblModulo);
            grpFiltros.Controls.Add(cmbModulo);
            grpFiltros.Controls.Add(lblAccion);
            grpFiltros.Controls.Add(cmbAccion);
            grpFiltros.Controls.Add(btnConsultar);
            grpFiltros.Controls.Add(btnLimpiarFiltros);
            grpFiltros.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold);
            grpFiltros.ForeColor = System.Drawing.SystemColors.ControlLight;
            grpFiltros.Location = new System.Drawing.Point(8, 8);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new System.Drawing.Size(980, 110);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";

            // lblUsuario
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new System.Drawing.Point(10, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(55, 14);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";

            // cmbUsuario
            cmbUsuario.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            cmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new System.Drawing.Point(10, 42);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new System.Drawing.Size(160, 22);
            cmbUsuario.TabIndex = 1;

            // lblFechaDesde
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new System.Drawing.Point(185, 24);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new System.Drawing.Size(82, 14);
            lblFechaDesde.TabIndex = 2;
            lblFechaDesde.Text = "Fecha desde:";

            // dtpFechaDesde
            dtpFechaDesde.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new System.Drawing.Point(185, 42);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.ShowCheckBox = true;
            dtpFechaDesde.Checked = false;
            dtpFechaDesde.Size = new System.Drawing.Size(160, 23);
            dtpFechaDesde.TabIndex = 3;

            // lblFechaHasta
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new System.Drawing.Point(360, 24);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new System.Drawing.Size(78, 14);
            lblFechaHasta.TabIndex = 4;
            lblFechaHasta.Text = "Fecha hasta:";

            // dtpFechaHasta
            dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new System.Drawing.Point(360, 42);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.ShowCheckBox = true;
            dtpFechaHasta.Checked = false;
            dtpFechaHasta.Size = new System.Drawing.Size(160, 23);
            dtpFechaHasta.TabIndex = 5;

            // lblModulo
            lblModulo.AutoSize = true;
            lblModulo.Location = new System.Drawing.Point(535, 24);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new System.Drawing.Size(50, 14);
            lblModulo.TabIndex = 6;
            lblModulo.Text = "Módulo:";

            // cmbModulo
            cmbModulo.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbModulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new System.Drawing.Point(535, 42);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new System.Drawing.Size(140, 22);
            cmbModulo.TabIndex = 7;

            // lblAccion
            lblAccion.AutoSize = true;
            lblAccion.Location = new System.Drawing.Point(690, 24);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new System.Drawing.Size(46, 14);
            lblAccion.TabIndex = 8;
            lblAccion.Text = "Acción:";

            // cmbAccion
            cmbAccion.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            cmbAccion.FormattingEnabled = true;
            cmbAccion.Location = new System.Drawing.Point(690, 42);
            cmbAccion.Name = "cmbAccion";
            cmbAccion.Size = new System.Drawing.Size(150, 22);
            cmbAccion.TabIndex = 9;

            // btnConsultar
            btnConsultar.BackColor = System.Drawing.Color.Transparent;
            btnConsultar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 58, 95);
            btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsultar.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnConsultar.Location = new System.Drawing.Point(855, 38);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new System.Drawing.Size(110, 28);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;

            // btnLimpiarFiltros
            btnLimpiarFiltros.BackColor = System.Drawing.Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 58, 95);
            btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            btnLimpiarFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpiarFiltros.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnLimpiarFiltros.Location = new System.Drawing.Point(855, 72);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new System.Drawing.Size(110, 28);
            btnLimpiarFiltros.TabIndex = 11;
            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;

            // grpResultados
            grpResultados.BackColor = System.Drawing.Color.FromArgb(8, 14, 26);
            grpResultados.Controls.Add(dgvBitacora);
            grpResultados.Controls.Add(lblTotalRegistros);
            grpResultados.Controls.Add(btnExportar);
            grpResultados.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold);
            grpResultados.ForeColor = System.Drawing.SystemColors.ControlLight;
            grpResultados.Location = new System.Drawing.Point(8, 126);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new System.Drawing.Size(980, 470);
            grpResultados.TabIndex = 1;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";

            // dgvBitacora
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.BackgroundColor = System.Drawing.Color.FromArgb(13, 22, 40);
            dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.GridColor = System.Drawing.Color.FromArgb(30, 58, 95);
            dgvBitacora.Location = new System.Drawing.Point(10, 24);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersWidth = 40;
            dgvBitacora.Size = new System.Drawing.Size(960, 400);
            dgvBitacora.TabIndex = 0;

            // lblTotalRegistros
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new System.Drawing.Point(10, 434);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new System.Drawing.Size(100, 14);
            lblTotalRegistros.TabIndex = 1;
            lblTotalRegistros.Text = "Total: 0 registros";

            // btnExportar
            btnExportar.BackColor = System.Drawing.Color.Transparent;
            btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 58, 95);
            btnExportar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExportar.ForeColor = System.Drawing.SystemColors.ControlLight;
            btnExportar.Location = new System.Drawing.Point(855, 428);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new System.Drawing.Size(115, 28);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;

            // formHistoriaA
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(8, 14, 26);
            ClientSize = new System.Drawing.Size(996, 604);
            Controls.Add(grpFiltros);
            Controls.Add(grpResultados);
            Name = "formHistoriaA";
            Text = "Bitácora del Sistema";

            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblAccion;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.GroupBox grpResultados;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnExportar;
    }
}
