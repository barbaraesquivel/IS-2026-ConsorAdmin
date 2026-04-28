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
            label2 = new Label();
            label1 = new Label();
            groupBoxDeuda = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            groupBoxProxexp = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            groupBoxEstado = new GroupBox();
            dataGridExpensasHistorial = new DataGridView();
            groupBoxAtencion = new GroupBox();
            dataGridUltimasExp = new DataGridView();
            groupBox1 = new GroupBox();
            buttonPagar = new Button();
            label7 = new Label();
            label8 = new Label();
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
            groupBoxPagado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxPagado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPagado.Controls.Add(label2);
            groupBoxPagado.Controls.Add(label1);
            groupBoxPagado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPagado.ForeColor = SystemColors.ControlLight;
            groupBoxPagado.Location = new Point(27, 39);
            groupBoxPagado.Name = "groupBoxPagado";
            groupBoxPagado.Size = new Size(159, 63);
            groupBoxPagado.TabIndex = 0;
            groupBoxPagado.TabStop = false;
            groupBoxPagado.Text = "TOTAL PAGADO";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 45);
            label2.Name = "label2";
            label2.Size = new Size(119, 11);
            label2.TabIndex = 1;
            label2.Text = "X expensas abonadas";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 19);
            label1.Name = "label1";
            label1.Size = new Size(139, 19);
            label1.TabIndex = 0;
            label1.Text = "$000000000.00";
            // 
            // groupBoxDeuda
            // 
            groupBoxDeuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxDeuda.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxDeuda.Controls.Add(label3);
            groupBoxDeuda.Controls.Add(label4);
            groupBoxDeuda.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxDeuda.ForeColor = SystemColors.ControlLight;
            groupBoxDeuda.Location = new Point(213, 39);
            groupBoxDeuda.Name = "groupBoxDeuda";
            groupBoxDeuda.Size = new Size(159, 63);
            groupBoxDeuda.TabIndex = 1;
            groupBoxDeuda.TabStop = false;
            groupBoxDeuda.Text = "EN DEUDA";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 45);
            label3.Name = "label3";
            label3.Size = new Size(77, 11);
            label3.TabIndex = 3;
            label3.Text = "X vencida(s)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 19);
            label4.Name = "label4";
            label4.Size = new Size(139, 19);
            label4.TabIndex = 2;
            label4.Text = "$000000000.00";
            // 
            // groupBoxProxexp
            // 
            groupBoxProxexp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxProxexp.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp.Controls.Add(label5);
            groupBoxProxexp.Controls.Add(label6);
            groupBoxProxexp.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp.Location = new Point(399, 39);
            groupBoxProxexp.Name = "groupBoxProxexp";
            groupBoxProxexp.Size = new Size(159, 63);
            groupBoxProxexp.TabIndex = 2;
            groupBoxProxexp.TabStop = false;
            groupBoxProxexp.Text = "PRÓXIMA EXPENSA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 44);
            label5.Name = "label5";
            label5.Size = new Size(107, 11);
            label5.TabIndex = 5;
            label5.Text = "Vence: 10/03/2025";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 18);
            label6.Name = "label6";
            label6.Size = new Size(139, 19);
            label6.TabIndex = 4;
            label6.Text = "$000000000.00";
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(dataGridExpensasHistorial);
            groupBoxEstado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(23, 152);
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
            groupBoxAtencion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAtencion.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxAtencion.Controls.Add(dataGridUltimasExp);
            groupBoxAtencion.Controls.Add(groupBox1);
            groupBoxAtencion.Controls.Add(panel3);
            groupBoxAtencion.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxAtencion.ForeColor = SystemColors.ControlLight;
            groupBoxAtencion.Location = new Point(298, 152);
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
            dataGridUltimasExp.Location = new Point(7, 149);
            dataGridUltimasExp.Name = "dataGridUltimasExp";
            dataGridUltimasExp.Size = new Size(252, 148);
            dataGridUltimasExp.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(buttonPagar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
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
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 45);
            label7.Name = "label7";
            label7.Size = new Size(221, 11);
            label7.TabIndex = 3;
            label7.Text = "Expensa Ene 2025 - Vencio 10/01/2025";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 19);
            label8.Name = "label8";
            label8.Size = new Size(139, 19);
            label8.TabIndex = 2;
            label8.Text = "$000000000.00";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(255, 83, 113);
            panel3.Location = new Point(3, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 108);
            panel3.TabIndex = 8;
            // 
            // panelGreen
            // 
            panelGreen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGreen.BackColor = Color.FromArgb(0, 220, 144);
            panelGreen.Location = new Point(23, 33);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(167, 72);
            panelGreen.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(255, 83, 113);
            panel1.Location = new Point(209, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 72);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 189, 20);
            panel2.Location = new Point(395, 33);
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
            groupBox2.Location = new Point(44, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(585, 476);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridExpensasHistorial;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Panel panel3;
        private Button buttonPagar;
        private DataGridView dataGridUltimasExp;
        private GroupBox groupBox2;
    }
}