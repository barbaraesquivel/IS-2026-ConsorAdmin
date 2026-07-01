namespace ConsorAdmin
{
    partial class formInicioC
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
            groupBoxPagado_FormInicioC = new GroupBox();
            labelExpAbon_FormInicioC = new Label();
            labelTotal_FormInicioC = new Label();
            groupBoxDeuda_FormInicioC = new GroupBox();
            labelExpVen_FormInicioC = new Label();
            labelDeuda_FormInicioC = new Label();
            groupBoxProxexp_FormInicioC = new GroupBox();
            labelVenProx_FormInicioC = new Label();
            labelProx_FormInicioC = new Label();
            groupBoxEstado_FormInicioC = new GroupBox();
            dataGridExpensasHistorial = new DataGridView();
            groupBoxAtencion_FormInicioC = new GroupBox();
            dataGridUltimasExp = new DataGridView();
            groupBox1 = new GroupBox();
            buttonPagar_FormInicioC = new Button();
            labelVenAtencion_FormInicioC = new Label();
            labelTotAtencion_FormInicioC = new Label();
            panel3 = new Panel();
            panelGreen = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            groupBoxPagado_FormInicioC.SuspendLayout();
            groupBoxDeuda_FormInicioC.SuspendLayout();
            groupBoxProxexp_FormInicioC.SuspendLayout();
            groupBoxEstado_FormInicioC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).BeginInit();
            groupBoxAtencion_FormInicioC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUltimasExp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPagado_FormInicioC
            // 
            groupBoxPagado_FormInicioC.Anchor = AnchorStyles.None;
            groupBoxPagado_FormInicioC.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPagado_FormInicioC.Controls.Add(labelExpAbon_FormInicioC);
            groupBoxPagado_FormInicioC.Controls.Add(labelTotal_FormInicioC);
            groupBoxPagado_FormInicioC.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPagado_FormInicioC.ForeColor = SystemColors.ControlLight;
            groupBoxPagado_FormInicioC.Location = new Point(76, 100);
            groupBoxPagado_FormInicioC.Name = "groupBoxPagado_FormInicioC";
            groupBoxPagado_FormInicioC.Size = new Size(159, 63);
            groupBoxPagado_FormInicioC.TabIndex = 0;
            groupBoxPagado_FormInicioC.TabStop = false;
            groupBoxPagado_FormInicioC.Text = "TOTAL PAGADO";
            // 
            // labelExpAbon_FormInicioC
            // 
            labelExpAbon_FormInicioC.Anchor = AnchorStyles.None;
            labelExpAbon_FormInicioC.AutoSize = true;
            labelExpAbon_FormInicioC.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExpAbon_FormInicioC.Location = new Point(10, 45);
            labelExpAbon_FormInicioC.Name = "labelExpAbon_FormInicioC";
            labelExpAbon_FormInicioC.Size = new Size(119, 11);
            labelExpAbon_FormInicioC.TabIndex = 1;
            labelExpAbon_FormInicioC.Text = "X expensas abonadas";
            // 
            // labelTotal_FormInicioC
            // 
            labelTotal_FormInicioC.Anchor = AnchorStyles.None;
            labelTotal_FormInicioC.AutoSize = true;
            labelTotal_FormInicioC.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal_FormInicioC.Location = new Point(7, 19);
            labelTotal_FormInicioC.Name = "labelTotal_FormInicioC";
            labelTotal_FormInicioC.Size = new Size(139, 19);
            labelTotal_FormInicioC.TabIndex = 0;
            labelTotal_FormInicioC.Text = "$000000000.00";
            // 
            // groupBoxDeuda_FormInicioC
            // 
            groupBoxDeuda_FormInicioC.Anchor = AnchorStyles.None;
            groupBoxDeuda_FormInicioC.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxDeuda_FormInicioC.Controls.Add(labelExpVen_FormInicioC);
            groupBoxDeuda_FormInicioC.Controls.Add(labelDeuda_FormInicioC);
            groupBoxDeuda_FormInicioC.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxDeuda_FormInicioC.ForeColor = SystemColors.ControlLight;
            groupBoxDeuda_FormInicioC.Location = new Point(262, 100);
            groupBoxDeuda_FormInicioC.Name = "groupBoxDeuda_FormInicioC";
            groupBoxDeuda_FormInicioC.Size = new Size(159, 63);
            groupBoxDeuda_FormInicioC.TabIndex = 1;
            groupBoxDeuda_FormInicioC.TabStop = false;
            groupBoxDeuda_FormInicioC.Text = "EN DEUDA";
            // 
            // labelExpVen_FormInicioC
            // 
            labelExpVen_FormInicioC.Anchor = AnchorStyles.None;
            labelExpVen_FormInicioC.AutoSize = true;
            labelExpVen_FormInicioC.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExpVen_FormInicioC.Location = new Point(10, 45);
            labelExpVen_FormInicioC.Name = "labelExpVen_FormInicioC";
            labelExpVen_FormInicioC.Size = new Size(77, 11);
            labelExpVen_FormInicioC.TabIndex = 3;
            labelExpVen_FormInicioC.Text = "X vencida(s)";
            // 
            // labelDeuda_FormInicioC
            // 
            labelDeuda_FormInicioC.Anchor = AnchorStyles.None;
            labelDeuda_FormInicioC.AutoSize = true;
            labelDeuda_FormInicioC.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeuda_FormInicioC.Location = new Point(7, 19);
            labelDeuda_FormInicioC.Name = "labelDeuda_FormInicioC";
            labelDeuda_FormInicioC.Size = new Size(139, 19);
            labelDeuda_FormInicioC.TabIndex = 2;
            labelDeuda_FormInicioC.Text = "$000000000.00";
            // 
            // groupBoxProxexp_FormInicioC
            // 
            groupBoxProxexp_FormInicioC.Anchor = AnchorStyles.None;
            groupBoxProxexp_FormInicioC.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp_FormInicioC.Controls.Add(labelVenProx_FormInicioC);
            groupBoxProxexp_FormInicioC.Controls.Add(labelProx_FormInicioC);
            groupBoxProxexp_FormInicioC.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp_FormInicioC.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp_FormInicioC.Location = new Point(448, 100);
            groupBoxProxexp_FormInicioC.Name = "groupBoxProxexp_FormInicioC";
            groupBoxProxexp_FormInicioC.Size = new Size(159, 63);
            groupBoxProxexp_FormInicioC.TabIndex = 2;
            groupBoxProxexp_FormInicioC.TabStop = false;
            groupBoxProxexp_FormInicioC.Text = "PRÓXIMA EXPENSA";
            // 
            // labelVenProx_FormInicioC
            // 
            labelVenProx_FormInicioC.Anchor = AnchorStyles.None;
            labelVenProx_FormInicioC.AutoSize = true;
            labelVenProx_FormInicioC.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVenProx_FormInicioC.Location = new Point(10, 44);
            labelVenProx_FormInicioC.Name = "labelVenProx_FormInicioC";
            labelVenProx_FormInicioC.Size = new Size(107, 11);
            labelVenProx_FormInicioC.TabIndex = 5;
            labelVenProx_FormInicioC.Text = "Vence: 10/03/2025";
            // 
            // labelProx_FormInicioC
            // 
            labelProx_FormInicioC.Anchor = AnchorStyles.None;
            labelProx_FormInicioC.AutoSize = true;
            labelProx_FormInicioC.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProx_FormInicioC.Location = new Point(7, 18);
            labelProx_FormInicioC.Name = "labelProx_FormInicioC";
            labelProx_FormInicioC.Size = new Size(139, 19);
            labelProx_FormInicioC.TabIndex = 4;
            labelProx_FormInicioC.Text = "$000000000.00";
            // 
            // groupBoxEstado_FormInicioC
            // 
            groupBoxEstado_FormInicioC.Anchor = AnchorStyles.None;
            groupBoxEstado_FormInicioC.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado_FormInicioC.Controls.Add(dataGridExpensasHistorial);
            groupBoxEstado_FormInicioC.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado_FormInicioC.ForeColor = SystemColors.ControlLight;
            groupBoxEstado_FormInicioC.Location = new Point(72, 213);
            groupBoxEstado_FormInicioC.Name = "groupBoxEstado_FormInicioC";
            groupBoxEstado_FormInicioC.Size = new Size(264, 303);
            groupBoxEstado_FormInicioC.TabIndex = 3;
            groupBoxEstado_FormInicioC.TabStop = false;
            groupBoxEstado_FormInicioC.Text = "ESTADO DE MI CUENTA";
            // 
            // dataGridExpensasHistorial
            // 
            dataGridExpensasHistorial.Anchor = AnchorStyles.None;
            dataGridExpensasHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExpensasHistorial.Location = new Point(10, 21);
            dataGridExpensasHistorial.Name = "dataGridExpensasHistorial";
            dataGridExpensasHistorial.Size = new Size(249, 276);
            dataGridExpensasHistorial.TabIndex = 0;
            // 
            // groupBoxAtencion_FormInicioC
            // 
            groupBoxAtencion_FormInicioC.Anchor = AnchorStyles.None;
            groupBoxAtencion_FormInicioC.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxAtencion_FormInicioC.Controls.Add(dataGridUltimasExp);
            groupBoxAtencion_FormInicioC.Controls.Add(groupBox1);
            groupBoxAtencion_FormInicioC.Controls.Add(panel3);
            groupBoxAtencion_FormInicioC.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxAtencion_FormInicioC.ForeColor = SystemColors.ControlLight;
            groupBoxAtencion_FormInicioC.Location = new Point(347, 213);
            groupBoxAtencion_FormInicioC.Name = "groupBoxAtencion_FormInicioC";
            groupBoxAtencion_FormInicioC.Size = new Size(264, 303);
            groupBoxAtencion_FormInicioC.TabIndex = 4;
            groupBoxAtencion_FormInicioC.TabStop = false;
            groupBoxAtencion_FormInicioC.Text = "ATENCIÓN REQUERIDA";
            // 
            // dataGridUltimasExp
            // 
            dataGridUltimasExp.Anchor = AnchorStyles.None;
            dataGridUltimasExp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUltimasExp.Location = new Point(7, 128);
            dataGridUltimasExp.Name = "dataGridUltimasExp";
            dataGridUltimasExp.Size = new Size(252, 169);
            dataGridUltimasExp.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(buttonPagar_FormInicioC);
            groupBox1.Controls.Add(labelVenAtencion_FormInicioC);
            groupBox1.Controls.Add(labelTotAtencion_FormInicioC);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(7, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 99);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // buttonPagar_FormInicioC
            // 
            buttonPagar_FormInicioC.Anchor = AnchorStyles.None;
            buttonPagar_FormInicioC.BackColor = Color.FromArgb(255, 40, 78);
            buttonPagar_FormInicioC.FlatAppearance.BorderSize = 0;
            buttonPagar_FormInicioC.FlatStyle = FlatStyle.Flat;
            buttonPagar_FormInicioC.ForeColor = SystemColors.ControlLight;
            buttonPagar_FormInicioC.Location = new Point(10, 65);
            buttonPagar_FormInicioC.Name = "buttonPagar_FormInicioC";
            buttonPagar_FormInicioC.Size = new Size(121, 23);
            buttonPagar_FormInicioC.TabIndex = 9;
            buttonPagar_FormInicioC.Text = "Pagar Ahora";
            buttonPagar_FormInicioC.UseVisualStyleBackColor = false;
            // 
            // labelVenAtencion_FormInicioC
            // 
            labelVenAtencion_FormInicioC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelVenAtencion_FormInicioC.AutoSize = true;
            labelVenAtencion_FormInicioC.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVenAtencion_FormInicioC.Location = new Point(10, 45);
            labelVenAtencion_FormInicioC.Name = "labelVenAtencion_FormInicioC";
            labelVenAtencion_FormInicioC.Size = new Size(221, 11);
            labelVenAtencion_FormInicioC.TabIndex = 3;
            labelVenAtencion_FormInicioC.Text = "Expensa Ene 2025 - Vencio 10/01/2025";
            // 
            // labelTotAtencion_FormInicioC
            // 
            labelTotAtencion_FormInicioC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTotAtencion_FormInicioC.AutoSize = true;
            labelTotAtencion_FormInicioC.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotAtencion_FormInicioC.Location = new Point(7, 19);
            labelTotAtencion_FormInicioC.Name = "labelTotAtencion_FormInicioC";
            labelTotAtencion_FormInicioC.Size = new Size(139, 19);
            labelTotAtencion_FormInicioC.TabIndex = 2;
            labelTotAtencion_FormInicioC.Text = "$000000000.00";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(255, 83, 113);
            panel3.Location = new Point(3, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 108);
            panel3.TabIndex = 8;
            // 
            // panelGreen
            // 
            panelGreen.Anchor = AnchorStyles.None;
            panelGreen.BackColor = Color.FromArgb(0, 220, 144);
            panelGreen.Location = new Point(72, 94);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(167, 72);
            panelGreen.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(255, 83, 113);
            panel1.Location = new Point(258, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 72);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 189, 20);
            panel2.Location = new Point(444, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 72);
            panel2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxPagado_FormInicioC);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(groupBoxAtencion_FormInicioC);
            groupBox2.Controls.Add(groupBoxEstado_FormInicioC);
            groupBox2.Controls.Add(groupBoxDeuda_FormInicioC);
            groupBox2.Controls.Add(groupBoxProxexp_FormInicioC);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // formInicioC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formInicioC";
            Text = "formInicioC";
            FormClosing += formInicioC_FormClosing;
            Load += formInicioC_Load;
            groupBoxPagado_FormInicioC.ResumeLayout(false);
            groupBoxPagado_FormInicioC.PerformLayout();
            groupBoxDeuda_FormInicioC.ResumeLayout(false);
            groupBoxDeuda_FormInicioC.PerformLayout();
            groupBoxProxexp_FormInicioC.ResumeLayout(false);
            groupBoxProxexp_FormInicioC.PerformLayout();
            groupBoxEstado_FormInicioC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).EndInit();
            groupBoxAtencion_FormInicioC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUltimasExp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPagado_FormInicioC;
        private GroupBox groupBoxDeuda_FormInicioC;
        private GroupBox groupBoxProxexp_FormInicioC;
        private GroupBox groupBoxEstado_FormInicioC;
        private GroupBox groupBoxAtencion_FormInicioC;
        private Panel panelGreen;
        private Label labelTotal_FormInicioC;
        private Panel panel1;
        private Panel panel2;
        private Label labelExpAbon_FormInicioC;
        private Label labelExpVen_FormInicioC;
        private Label labelDeuda_FormInicioC;
        private Label labelVenProx_FormInicioC;
        private Label labelProx_FormInicioC;
        private DataGridView dataGridExpensasHistorial;
        private GroupBox groupBox1;
        private Label labelVenAtencion_FormInicioC;
        private Label labelTotAtencion_FormInicioC;
        private Panel panel3;
        private Button buttonPagar_FormInicioC;
        private DataGridView dataGridUltimasExp;
        private GroupBox groupBox2;
    }
}