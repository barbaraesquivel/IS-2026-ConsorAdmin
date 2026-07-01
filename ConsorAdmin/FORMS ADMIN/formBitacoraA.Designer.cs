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
            grpFiltros_FormBitacoraA = new GroupBox();
            lblUsuario_FormBitacoraA = new Label();
            cmbUsuario = new ComboBox();
            lblFechaDesde_FormBitacoraA = new Label();
            dtpFechaDesde = new DateTimePicker();
            lblFechaHasta_FormBitacoraA = new Label();
            dtpFechaHasta = new DateTimePicker();
            lblModulo_FormBitacoraA = new Label();
            cmbModulo = new ComboBox();
            lblAccion_FormBitacoraA = new Label();
            cmbAccion = new ComboBox();
            btnConsultar_FormBitacoraA = new Button();
            btnLimpiarFiltros_FormBitacoraA = new Button();
            grpResultados_FormBitacoraA = new GroupBox();
            dgvBitacora = new DataGridView();
            lblTotalRegistros = new Label();
            btnExportar = new Button();
            grpFiltros_FormBitacoraA.SuspendLayout();
            grpResultados_FormBitacoraA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // grpFiltros_FormBitacoraA
            // 
            grpFiltros_FormBitacoraA.BackColor = Color.FromArgb(8, 14, 26);
            grpFiltros_FormBitacoraA.Controls.Add(lblUsuario_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(cmbUsuario);
            grpFiltros_FormBitacoraA.Controls.Add(lblFechaDesde_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(dtpFechaDesde);
            grpFiltros_FormBitacoraA.Controls.Add(lblFechaHasta_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(dtpFechaHasta);
            grpFiltros_FormBitacoraA.Controls.Add(lblModulo_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(cmbModulo);
            grpFiltros_FormBitacoraA.Controls.Add(lblAccion_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(cmbAccion);
            grpFiltros_FormBitacoraA.Controls.Add(btnConsultar_FormBitacoraA);
            grpFiltros_FormBitacoraA.Controls.Add(btnLimpiarFiltros_FormBitacoraA);
            grpFiltros_FormBitacoraA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            grpFiltros_FormBitacoraA.ForeColor = SystemColors.ControlLight;
            grpFiltros_FormBitacoraA.Location = new Point(8, 8);
            grpFiltros_FormBitacoraA.Name = "grpFiltros_FormBitacoraA";
            grpFiltros_FormBitacoraA.Size = new Size(980, 110);
            grpFiltros_FormBitacoraA.TabIndex = 0;
            grpFiltros_FormBitacoraA.TabStop = false;
            grpFiltros_FormBitacoraA.Text = "Filtros";
            // 
            // lblUsuario_FormBitacoraA
            // 
            lblUsuario_FormBitacoraA.AutoSize = true;
            lblUsuario_FormBitacoraA.Location = new Point(10, 24);
            lblUsuario_FormBitacoraA.Name = "lblUsuario_FormBitacoraA";
            lblUsuario_FormBitacoraA.Size = new Size(63, 14);
            lblUsuario_FormBitacoraA.TabIndex = 0;
            lblUsuario_FormBitacoraA.Text = "Usuario:";
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
            // lblFechaDesde_FormBitacoraA
            // 
            lblFechaDesde_FormBitacoraA.AutoSize = true;
            lblFechaDesde_FormBitacoraA.Location = new Point(185, 24);
            lblFechaDesde_FormBitacoraA.Name = "lblFechaDesde_FormBitacoraA";
            lblFechaDesde_FormBitacoraA.Size = new Size(91, 14);
            lblFechaDesde_FormBitacoraA.TabIndex = 2;
            lblFechaDesde_FormBitacoraA.Text = "Fecha desde:";
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
            // lblFechaHasta_FormBitacoraA
            // 
            lblFechaHasta_FormBitacoraA.AutoSize = true;
            lblFechaHasta_FormBitacoraA.Location = new Point(360, 24);
            lblFechaHasta_FormBitacoraA.Name = "lblFechaHasta_FormBitacoraA";
            lblFechaHasta_FormBitacoraA.Size = new Size(91, 14);
            lblFechaHasta_FormBitacoraA.TabIndex = 4;
            lblFechaHasta_FormBitacoraA.Text = "Fecha hasta:";
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
            // lblModulo_FormBitacoraA
            // 
            lblModulo_FormBitacoraA.AutoSize = true;
            lblModulo_FormBitacoraA.Location = new Point(535, 24);
            lblModulo_FormBitacoraA.Name = "lblModulo_FormBitacoraA";
            lblModulo_FormBitacoraA.Size = new Size(56, 14);
            lblModulo_FormBitacoraA.TabIndex = 6;
            lblModulo_FormBitacoraA.Text = "Módulo:";
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
            // lblAccion_FormBitacoraA
            // 
            lblAccion_FormBitacoraA.AutoSize = true;
            lblAccion_FormBitacoraA.Location = new Point(690, 24);
            lblAccion_FormBitacoraA.Name = "lblAccion_FormBitacoraA";
            lblAccion_FormBitacoraA.Size = new Size(56, 14);
            lblAccion_FormBitacoraA.TabIndex = 8;
            lblAccion_FormBitacoraA.Text = "Acción:";
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
            // btnConsultar_FormBitacoraA
            // 
            btnConsultar_FormBitacoraA.BackColor = Color.Transparent;
            btnConsultar_FormBitacoraA.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnConsultar_FormBitacoraA.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnConsultar_FormBitacoraA.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnConsultar_FormBitacoraA.FlatStyle = FlatStyle.Flat;
            btnConsultar_FormBitacoraA.ForeColor = SystemColors.ControlLight;
            btnConsultar_FormBitacoraA.Location = new Point(855, 38);
            btnConsultar_FormBitacoraA.Name = "btnConsultar_FormBitacoraA";
            btnConsultar_FormBitacoraA.Size = new Size(110, 28);
            btnConsultar_FormBitacoraA.TabIndex = 10;
            btnConsultar_FormBitacoraA.Text = "Consultar";
            btnConsultar_FormBitacoraA.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarFiltros_FormBitacoraA
            // 
            btnLimpiarFiltros_FormBitacoraA.BackColor = Color.Transparent;
            btnLimpiarFiltros_FormBitacoraA.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnLimpiarFiltros_FormBitacoraA.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnLimpiarFiltros_FormBitacoraA.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnLimpiarFiltros_FormBitacoraA.FlatStyle = FlatStyle.Flat;
            btnLimpiarFiltros_FormBitacoraA.ForeColor = SystemColors.ControlLight;
            btnLimpiarFiltros_FormBitacoraA.Location = new Point(855, 72);
            btnLimpiarFiltros_FormBitacoraA.Name = "btnLimpiarFiltros_FormBitacoraA";
            btnLimpiarFiltros_FormBitacoraA.Size = new Size(110, 28);
            btnLimpiarFiltros_FormBitacoraA.TabIndex = 11;
            btnLimpiarFiltros_FormBitacoraA.Text = "Limpiar filtros";
            btnLimpiarFiltros_FormBitacoraA.UseVisualStyleBackColor = false;
            // 
            // grpResultados_FormBitacoraA
            // 
            grpResultados_FormBitacoraA.BackColor = Color.FromArgb(8, 14, 26);
            grpResultados_FormBitacoraA.Controls.Add(dgvBitacora);
            grpResultados_FormBitacoraA.Controls.Add(lblTotalRegistros);
            grpResultados_FormBitacoraA.Controls.Add(btnExportar);
            grpResultados_FormBitacoraA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            grpResultados_FormBitacoraA.ForeColor = SystemColors.ControlLight;
            grpResultados_FormBitacoraA.Location = new Point(8, 126);
            grpResultados_FormBitacoraA.Name = "grpResultados_FormBitacoraA";
            grpResultados_FormBitacoraA.Size = new Size(980, 470);
            grpResultados_FormBitacoraA.TabIndex = 1;
            grpResultados_FormBitacoraA.TabStop = false;
            grpResultados_FormBitacoraA.Text = "Resultados";
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
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlLight;
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
            // formBitacoraA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(996, 604);
            Controls.Add(grpFiltros_FormBitacoraA);
            Controls.Add(grpResultados_FormBitacoraA);
            Name = "formBitacoraA";
            Text = "Bitácora del Sistema";
            FormClosing += formBitacoraA_FormClosing;
            grpFiltros_FormBitacoraA.ResumeLayout(false);
            grpFiltros_FormBitacoraA.PerformLayout();
            grpResultados_FormBitacoraA.ResumeLayout(false);
            grpResultados_FormBitacoraA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros_FormBitacoraA;
        private System.Windows.Forms.Label lblUsuario_FormBitacoraA;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblFechaDesde_FormBitacoraA;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaHasta_FormBitacoraA;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblModulo_FormBitacoraA;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblAccion_FormBitacoraA;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Button btnConsultar_FormBitacoraA;
        private System.Windows.Forms.Button btnLimpiarFiltros_FormBitacoraA;
        private System.Windows.Forms.GroupBox grpResultados_FormBitacoraA;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblTotalRegistros;
        private System.Windows.Forms.Button btnExportar;
    }
}
