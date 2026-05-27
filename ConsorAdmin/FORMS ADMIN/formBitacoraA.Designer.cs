namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formBitacoraA
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            grpFiltros = new GroupBox();
            lblUsuario = new Label();
            cmbUsuario = new ComboBox();
            lblFechaDesde = new Label();
            dtpFechaDesde = new DateTimePicker();
            lblFechaHasta = new Label();
            dtpFechaHasta = new DateTimePicker();
            lblModulo = new Label();
            cmbModulo = new ComboBox();
            lblAccion = new Label();
            cmbAccion = new ComboBox();
            btnConsultar = new Button();
            btnLimpiarFiltros = new Button();
            grpResultados = new GroupBox();
            dgvBitacora = new DataGridView();
            lblTotalRegistros = new Label();
            btnExportar = new Button();
            grpFiltros.SuspendLayout();
            grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // grpFiltros
            // 
            grpFiltros.BackColor = Color.FromArgb(8, 14, 26);
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
            grpFiltros.Font = new Font("Unispace", 9F, FontStyle.Bold);
            grpFiltros.ForeColor = SystemColors.ControlLight;
            grpFiltros.Location = new Point(8, 8);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(980, 110);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(10, 24);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 14);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario:";
            // 
            // cmbUsuario
            // 
            cmbUsuario.BackColor = Color.FromArgb(13, 22, 40);
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.ForeColor = SystemColors.ControlLight;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(10, 42);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(160, 22);
            cmbUsuario.TabIndex = 1;
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Location = new Point(185, 24);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(91, 14);
            lblFechaDesde.TabIndex = 2;
            lblFechaDesde.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.CalendarForeColor = SystemColors.ControlLight;
            dtpFechaDesde.Checked = false;
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(185, 42);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.ShowCheckBox = true;
            dtpFechaDesde.Size = new Size(160, 22);
            dtpFechaDesde.TabIndex = 3;
            // 
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Location = new Point(360, 24);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(91, 14);
            lblFechaHasta.TabIndex = 4;
            lblFechaHasta.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Checked = false;
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(360, 42);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.ShowCheckBox = true;
            dtpFechaHasta.Size = new Size(160, 22);
            dtpFechaHasta.TabIndex = 5;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Location = new Point(535, 24);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(56, 14);
            lblModulo.TabIndex = 6;
            lblModulo.Text = "Módulo:";
            // 
            // cmbModulo
            // 
            cmbModulo.BackColor = Color.FromArgb(13, 22, 40);
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbModulo.ForeColor = SystemColors.ControlLight;
            cmbModulo.FormattingEnabled = true;
            cmbModulo.Location = new Point(535, 42);
            cmbModulo.Name = "cmbModulo";
            cmbModulo.Size = new Size(140, 22);
            cmbModulo.TabIndex = 7;
            // 
            // lblAccion
            // 
            lblAccion.AutoSize = true;
            lblAccion.Location = new Point(690, 24);
            lblAccion.Name = "lblAccion";
            lblAccion.Size = new Size(56, 14);
            lblAccion.TabIndex = 8;
            lblAccion.Text = "Acción:";
            // 
            // cmbAccion
            // 
            cmbAccion.BackColor = Color.FromArgb(13, 22, 40);
            cmbAccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccion.ForeColor = SystemColors.ControlLight;
            cmbAccion.FormattingEnabled = true;
            cmbAccion.Location = new Point(690, 42);
            cmbAccion.Name = "cmbAccion";
            cmbAccion.Size = new Size(150, 22);
            cmbAccion.TabIndex = 9;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.Transparent;
            btnConsultar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnConsultar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnConsultar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnConsultar.FlatStyle = FlatStyle.Flat;
            btnConsultar.ForeColor = SystemColors.ControlLight;
            btnConsultar.Location = new Point(855, 38);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(110, 28);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.BackColor = Color.Transparent;
            btnLimpiarFiltros.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnLimpiarFiltros.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnLimpiarFiltros.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnLimpiarFiltros.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros.ForeColor = SystemColors.ControlLight;
            btnLimpiarFiltros.Location = new Point(855, 72);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(110, 28);
            btnLimpiarFiltros.TabIndex = 11;
            btnLimpiarFiltros.Text = "Limpiar filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // grpResultados
            // 
            grpResultados.BackColor = Color.FromArgb(8, 14, 26);
            grpResultados.Controls.Add(dgvBitacora);
            grpResultados.Controls.Add(lblTotalRegistros);
            grpResultados.Controls.Add(btnExportar);
            grpResultados.Font = new Font("Unispace", 9F, FontStyle.Bold);
            grpResultados.ForeColor = SystemColors.ControlLight;
            grpResultados.Location = new Point(8, 126);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(980, 470);
            grpResultados.TabIndex = 1;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados";
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.BackgroundColor = Color.FromArgb(13, 22, 40);
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvBitacora.DefaultCellStyle = dataGridViewCellStyle1;
            dgvBitacora.GridColor = Color.FromArgb(30, 58, 95);
            dgvBitacora.Location = new Point(10, 24);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersWidth = 40;
            dgvBitacora.Size = new Size(960, 400);
            dgvBitacora.TabIndex = 0;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(10, 434);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(133, 14);
            lblTotalRegistros.TabIndex = 1;
            lblTotalRegistros.Text = "Total: 0 registros";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Transparent;
            btnExportar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnExportar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnExportar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.ForeColor = SystemColors.ControlLight;
            btnExportar.Location = new Point(855, 428);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(115, 28);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = false;
            // 
            // formHistoriaA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(996, 604);
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
