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
            groupBoxPagado = new GroupBox();
            labelExpAbon = new Label();
            labelTotal = new Label();
            groupBoxDeuda = new GroupBox();
            labelExpVen = new Label();
            labelDeuda = new Label();
            groupBoxProxexp = new GroupBox();
            labelVenProx = new Label();
            labelProx = new Label();
            groupBoxEstado = new GroupBox();
            dataGridExpensasHistorial = new DataGridView();
            groupBoxAtencion = new GroupBox();
            dataGridUltimasExp = new DataGridView();
            groupBox1 = new GroupBox();
            buttonPagar = new Button();
            labelVenAtencion = new Label();
            labelTotAtencion = new Label();
            panel3 = new Panel();
            panelGreen = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            groupBoxPagado.SuspendLayout();
            groupBoxDeuda.SuspendLayout();
            groupBoxProxexp.SuspendLayout();
            groupBoxEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).BeginInit();
            groupBoxAtencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUltimasExp).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPagado
            // 
            groupBoxPagado.Anchor = AnchorStyles.None;
            groupBoxPagado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPagado.Controls.Add(labelExpAbon);
            groupBoxPagado.Controls.Add(labelTotal);
            groupBoxPagado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPagado.ForeColor = SystemColors.ControlLight;
            groupBoxPagado.Location = new Point(64, 39);
            groupBoxPagado.Name = "groupBoxPagado";
            groupBoxPagado.Size = new Size(159, 63);
            groupBoxPagado.TabIndex = 0;
            groupBoxPagado.TabStop = false;
            groupBoxPagado.Text = "TOTAL PAGADO";
            // 
            // labelExpAbon
            // 
            labelExpAbon.Anchor = AnchorStyles.None;
            labelExpAbon.AutoSize = true;
            labelExpAbon.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExpAbon.Location = new Point(10, 45);
            labelExpAbon.Name = "labelExpAbon";
            labelExpAbon.Size = new Size(119, 11);
            labelExpAbon.TabIndex = 1;
            labelExpAbon.Text = "X expensas abonadas";
            // 
            // labelTotal
            // 
            labelTotal.Anchor = AnchorStyles.None;
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(7, 19);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(139, 19);
            labelTotal.TabIndex = 0;
            labelTotal.Text = "$000000000.00";
            // 
            // groupBoxDeuda
            // 
            groupBoxDeuda.Anchor = AnchorStyles.None;
            groupBoxDeuda.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxDeuda.Controls.Add(labelExpVen);
            groupBoxDeuda.Controls.Add(labelDeuda);
            groupBoxDeuda.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxDeuda.ForeColor = SystemColors.ControlLight;
            groupBoxDeuda.Location = new Point(250, 39);
            groupBoxDeuda.Name = "groupBoxDeuda";
            groupBoxDeuda.Size = new Size(159, 63);
            groupBoxDeuda.TabIndex = 1;
            groupBoxDeuda.TabStop = false;
            groupBoxDeuda.Text = "EN DEUDA";
            // 
            // labelExpVen
            // 
            labelExpVen.Anchor = AnchorStyles.None;
            labelExpVen.AutoSize = true;
            labelExpVen.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExpVen.Location = new Point(10, 45);
            labelExpVen.Name = "labelExpVen";
            labelExpVen.Size = new Size(77, 11);
            labelExpVen.TabIndex = 3;
            labelExpVen.Text = "X vencida(s)";
            // 
            // labelDeuda
            // 
            labelDeuda.Anchor = AnchorStyles.None;
            labelDeuda.AutoSize = true;
            labelDeuda.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeuda.Location = new Point(7, 19);
            labelDeuda.Name = "labelDeuda";
            labelDeuda.Size = new Size(139, 19);
            labelDeuda.TabIndex = 2;
            labelDeuda.Text = "$000000000.00";
            // 
            // groupBoxProxexp
            // 
            groupBoxProxexp.Anchor = AnchorStyles.None;
            groupBoxProxexp.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp.Controls.Add(labelVenProx);
            groupBoxProxexp.Controls.Add(labelProx);
            groupBoxProxexp.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp.Location = new Point(436, 39);
            groupBoxProxexp.Name = "groupBoxProxexp";
            groupBoxProxexp.Size = new Size(159, 63);
            groupBoxProxexp.TabIndex = 2;
            groupBoxProxexp.TabStop = false;
            groupBoxProxexp.Text = "PRÓXIMA EXPENSA";
            // 
            // labelVenProx
            // 
            labelVenProx.Anchor = AnchorStyles.None;
            labelVenProx.AutoSize = true;
            labelVenProx.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVenProx.Location = new Point(10, 44);
            labelVenProx.Name = "labelVenProx";
            labelVenProx.Size = new Size(107, 11);
            labelVenProx.TabIndex = 5;
            labelVenProx.Text = "Vence: 10/03/2025";
            // 
            // labelProx
            // 
            labelProx.Anchor = AnchorStyles.None;
            labelProx.AutoSize = true;
            labelProx.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelProx.Location = new Point(7, 18);
            labelProx.Name = "labelProx";
            labelProx.Size = new Size(139, 19);
            labelProx.TabIndex = 4;
            labelProx.Text = "$000000000.00";
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.None;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(dataGridExpensasHistorial);
            groupBoxEstado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(60, 152);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(264, 303);
            groupBoxEstado.TabIndex = 3;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "ESTADO DE MI CUENTA";
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
            // groupBoxAtencion
            // 
            groupBoxAtencion.Anchor = AnchorStyles.None;
            groupBoxAtencion.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxAtencion.Controls.Add(dataGridUltimasExp);
            groupBoxAtencion.Controls.Add(groupBox1);
            groupBoxAtencion.Controls.Add(panel3);
            groupBoxAtencion.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxAtencion.ForeColor = SystemColors.ControlLight;
            groupBoxAtencion.Location = new Point(335, 152);
            groupBoxAtencion.Name = "groupBoxAtencion";
            groupBoxAtencion.Size = new Size(264, 303);
            groupBoxAtencion.TabIndex = 4;
            groupBoxAtencion.TabStop = false;
            groupBoxAtencion.Text = "ATENCIÓN REQUERIDA";
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
            groupBox1.Controls.Add(buttonPagar);
            groupBox1.Controls.Add(labelVenAtencion);
            groupBox1.Controls.Add(labelTotAtencion);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(7, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 99);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // buttonPagar
            // 
            buttonPagar.Anchor = AnchorStyles.None;
            buttonPagar.BackColor = Color.FromArgb(255, 40, 78);
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.ForeColor = SystemColors.ControlLight;
            buttonPagar.Location = new Point(10, 65);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(121, 23);
            buttonPagar.TabIndex = 9;
            buttonPagar.Text = "Pagar Ahora";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // labelVenAtencion
            // 
            labelVenAtencion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelVenAtencion.AutoSize = true;
            labelVenAtencion.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVenAtencion.Location = new Point(10, 45);
            labelVenAtencion.Name = "labelVenAtencion";
            labelVenAtencion.Size = new Size(221, 11);
            labelVenAtencion.TabIndex = 3;
            labelVenAtencion.Text = "Expensa Ene 2025 - Vencio 10/01/2025";
            // 
            // labelTotAtencion
            // 
            labelTotAtencion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelTotAtencion.AutoSize = true;
            labelTotAtencion.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotAtencion.Location = new Point(7, 19);
            labelTotAtencion.Name = "labelTotAtencion";
            labelTotAtencion.Size = new Size(139, 19);
            labelTotAtencion.TabIndex = 2;
            labelTotAtencion.Text = "$000000000.00";
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
            panelGreen.Location = new Point(60, 33);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(167, 72);
            panelGreen.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(255, 83, 113);
            panel1.Location = new Point(246, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 72);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 189, 20);
            panel2.Location = new Point(432, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 72);
            panel2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxPagado);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(groupBoxAtencion);
            groupBox2.Controls.Add(groupBoxEstado);
            groupBox2.Controls.Add(groupBoxDeuda);
            groupBox2.Controls.Add(groupBoxProxexp);
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(panel2);
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(12, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(658, 476);
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
            groupBoxPagado.ResumeLayout(false);
            groupBoxPagado.PerformLayout();
            groupBoxDeuda.ResumeLayout(false);
            groupBoxDeuda.PerformLayout();
            groupBoxProxexp.ResumeLayout(false);
            groupBoxProxexp.PerformLayout();
            groupBoxEstado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensasHistorial).EndInit();
            groupBoxAtencion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUltimasExp).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPagado;
        private GroupBox groupBoxDeuda;
        private GroupBox groupBoxProxexp;
        private GroupBox groupBoxEstado;
        private GroupBox groupBoxAtencion;
        private Panel panelGreen;
        private Label labelTotal;
        private Panel panel1;
        private Panel panel2;
        private Label labelExpAbon;
        private Label labelExpVen;
        private Label labelDeuda;
        private Label labelVenProx;
        private Label labelProx;
        private DataGridView dataGridExpensasHistorial;
        private GroupBox groupBox1;
        private Label labelVenAtencion;
        private Label labelTotAtencion;
        private Panel panel3;
        private Button buttonPagar;
        private DataGridView dataGridUltimasExp;
        private GroupBox groupBox2;
    }
}