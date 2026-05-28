namespace ConsorAdmin.FORMS_PROOVEDOR
{
    partial class formInicioP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            labelTot = new Label();
            panel4 = new Panel();
            groupBoxPagado = new GroupBox();
            labelServicios = new Label();
            labelCobrado = new Label();
            panelGreen = new Panel();
            groupBoxDeudas = new GroupBox();
            dataGridExpDeudas = new DataGridView();
            groupBoxEstado = new GroupBox();
            dataGridExpensasHistorial = new DataGridView();
            groupBoxProxexp = new GroupBox();
            labelAcobrar = new Label();
            panel2 = new Panel();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxPagado.SuspendLayout();
            groupBoxDeudas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpDeudas).BeginInit();
            groupBoxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).BeginInit();
            groupBoxProxexp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(groupBoxPagado);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(groupBoxDeudas);
            groupBox2.Controls.Add(groupBoxEstado);
            groupBox2.Controls.Add(groupBoxProxexp);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.FromArgb(17, 30, 53);
            groupBox3.Controls.Add(labelTot);
            groupBox3.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(418, 51);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 63);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "TOTAL FACTURADO";
            // 
            // labelTot
            // 
            labelTot.Anchor = AnchorStyles.None;
            labelTot.AutoSize = true;
            labelTot.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTot.Location = new Point(6, 18);
            labelTot.Name = "labelTot";
            labelTot.Size = new Size(139, 19);
            labelTot.TabIndex = 4;
            labelTot.Text = "$000000000.00";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(0, 212, 255);
            panel4.Location = new Point(414, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 72);
            panel4.TabIndex = 9;
            // 
            // groupBoxPagado
            // 
            groupBoxPagado.Anchor = AnchorStyles.None;
            groupBoxPagado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPagado.Controls.Add(labelServicios);
            groupBoxPagado.Controls.Add(labelCobrado);
            groupBoxPagado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPagado.ForeColor = SystemColors.ControlLight;
            groupBoxPagado.Location = new Point(71, 51);
            groupBoxPagado.Name = "groupBoxPagado";
            groupBoxPagado.Size = new Size(159, 63);
            groupBoxPagado.TabIndex = 0;
            groupBoxPagado.TabStop = false;
            groupBoxPagado.Text = "COBRADO";
            // 
            // labelServicios
            // 
            labelServicios.Anchor = AnchorStyles.None;
            labelServicios.AutoSize = true;
            labelServicios.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServicios.Location = new Point(9, 44);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(71, 11);
            labelServicios.TabIndex = 1;
            labelServicios.Text = "X servicios";
            // 
            // labelCobrado
            // 
            labelCobrado.Anchor = AnchorStyles.None;
            labelCobrado.AutoSize = true;
            labelCobrado.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCobrado.Location = new Point(6, 18);
            labelCobrado.Name = "labelCobrado";
            labelCobrado.Size = new Size(139, 19);
            labelCobrado.TabIndex = 0;
            labelCobrado.Text = "$000000000.00";
            // 
            // panelGreen
            // 
            panelGreen.Anchor = AnchorStyles.None;
            panelGreen.BackColor = Color.FromArgb(0, 220, 144);
            panelGreen.Location = new Point(66, 45);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(167, 72);
            panelGreen.TabIndex = 5;
            // 
            // groupBoxDeudas
            // 
            groupBoxDeudas.Anchor = AnchorStyles.None;
            groupBoxDeudas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxDeudas.Controls.Add(dataGridExpDeudas);
            groupBoxDeudas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxDeudas.ForeColor = SystemColors.ControlLight;
            groupBoxDeudas.Location = new Point(330, 175);
            groupBoxDeudas.Name = "groupBoxDeudas";
            groupBoxDeudas.Size = new Size(264, 303);
            groupBoxDeudas.TabIndex = 4;
            groupBoxDeudas.TabStop = false;
            groupBoxDeudas.Text = "PENDIENTES / DEUDAS";
            // 
            // dataGridExpDeudas
            // 
            dataGridExpDeudas.Anchor = AnchorStyles.None;
            dataGridExpDeudas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridExpDeudas.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridExpDeudas.Location = new Point(6, 21);
            dataGridExpDeudas.Name = "dataGridExpDeudas";
            dataGridExpDeudas.RowHeadersWidth = 51;
            dataGridExpDeudas.Size = new Size(252, 277);
            dataGridExpDeudas.TabIndex = 9;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.None;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(dataGridExpensasHistorial);
            groupBoxEstado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(55, 175);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(264, 303);
            groupBoxEstado.TabIndex = 3;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "ESTADO POR CONSORCIO";
            // 
            // dataGridExpensasHistorial
            // 
            dataGridExpensasHistorial.Anchor = AnchorStyles.None;
            dataGridExpensasHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridExpensasHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridExpensasHistorial.Location = new Point(7, 21);
            dataGridExpensasHistorial.Name = "dataGridExpensasHistorial";
            dataGridExpensasHistorial.RowHeadersWidth = 51;
            dataGridExpensasHistorial.Size = new Size(249, 276);
            dataGridExpensasHistorial.TabIndex = 0;
            // 
            // groupBoxProxexp
            // 
            groupBoxProxexp.Anchor = AnchorStyles.None;
            groupBoxProxexp.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp.Controls.Add(labelAcobrar);
            groupBoxProxexp.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp.Location = new Point(244, 51);
            groupBoxProxexp.Name = "groupBoxProxexp";
            groupBoxProxexp.Size = new Size(159, 63);
            groupBoxProxexp.TabIndex = 2;
            groupBoxProxexp.TabStop = false;
            groupBoxProxexp.Text = "PENDIENTE";
            // 
            // labelAcobrar
            // 
            labelAcobrar.Anchor = AnchorStyles.None;
            labelAcobrar.AutoSize = true;
            labelAcobrar.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcobrar.Location = new Point(6, 18);
            labelAcobrar.Name = "labelAcobrar";
            labelAcobrar.Size = new Size(139, 19);
            labelAcobrar.TabIndex = 4;
            labelAcobrar.Text = "$000000000.00";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 189, 20);
            panel2.Location = new Point(241, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 72);
            panel2.TabIndex = 7;
            // 
            // formInicioP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formInicioP";
            Text = "formInicioP";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxPagado.ResumeLayout(false);
            groupBoxPagado.PerformLayout();
            groupBoxDeudas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpDeudas).EndInit();
            groupBoxEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).EndInit();
            groupBoxProxexp.ResumeLayout(false);
            groupBoxProxexp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxPagado;
        private Label labelServicios;
        private Label labelCobrado;
        private Panel panelGreen;
        private GroupBox groupBoxDeudas;
        private DataGridView dataGridExpDeudas;
        private GroupBox groupBoxEstado;
        private DataGridView dataGridExpensasHistorial;
        private GroupBox groupBoxProxexp;
        private Label labelAcobrar;
        private Panel panel2;
        private GroupBox groupBox3;
        private Label labelTot;
        private Panel panel4;
    }
}