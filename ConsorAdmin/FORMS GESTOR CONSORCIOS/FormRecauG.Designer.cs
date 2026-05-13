namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormRecauG
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
            groupBox3 = new GroupBox();
            labelSinAsig = new Label();
            panel4 = new Panel();
            groupBoxPagado = new GroupBox();
            labelFondo = new Label();
            panelGreen = new Panel();
            groupBoxEstado = new GroupBox();
            groupBoxProxexp = new GroupBox();
            labelAsignado = new Label();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            label1 = new Label();
            comboBoxEdificios = new ComboBox();
            comboBoxCategoria = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            textBoxMonto = new TextBox();
            groupBox3.SuspendLayout();
            groupBoxPagado.SuspendLayout();
            groupBoxEstado.SuspendLayout();
            groupBoxProxexp.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.FromArgb(17, 30, 53);
            groupBox3.Controls.Add(labelSinAsig);
            groupBox3.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(440, 105);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(159, 63);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "SIN ASIGNAR";
            // 
            // labelSinAsig
            // 
            labelSinAsig.Anchor = AnchorStyles.None;
            labelSinAsig.AutoSize = true;
            labelSinAsig.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSinAsig.Location = new Point(2, 16);
            labelSinAsig.Name = "labelSinAsig";
            labelSinAsig.Size = new Size(139, 19);
            labelSinAsig.TabIndex = 4;
            labelSinAsig.Text = "$000000000.00";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(255, 189, 20);
            panel4.Location = new Point(436, 99);
            panel4.Name = "panel4";
            panel4.Size = new Size(167, 72);
            panel4.TabIndex = 9;
            // 
            // groupBoxPagado
            // 
            groupBoxPagado.Anchor = AnchorStyles.None;
            groupBoxPagado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPagado.Controls.Add(labelFondo);
            groupBoxPagado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPagado.ForeColor = SystemColors.ControlLight;
            groupBoxPagado.Location = new Point(92, 105);
            groupBoxPagado.Name = "groupBoxPagado";
            groupBoxPagado.Size = new Size(159, 63);
            groupBoxPagado.TabIndex = 0;
            groupBoxPagado.TabStop = false;
            groupBoxPagado.Text = "FONDO DISPONIBLE";
            // 
            // labelFondo
            // 
            labelFondo.Anchor = AnchorStyles.None;
            labelFondo.AutoSize = true;
            labelFondo.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFondo.Location = new Point(2, 16);
            labelFondo.Name = "labelFondo";
            labelFondo.Size = new Size(139, 19);
            labelFondo.TabIndex = 0;
            labelFondo.Text = "$000000000.00";
            // 
            // panelGreen
            // 
            panelGreen.Anchor = AnchorStyles.None;
            panelGreen.BackColor = Color.FromArgb(0, 220, 144);
            panelGreen.Location = new Point(87, 99);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(167, 72);
            panelGreen.TabIndex = 5;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.None;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(textBoxMonto);
            groupBoxEstado.Controls.Add(richTextBox1);
            groupBoxEstado.Controls.Add(label3);
            groupBoxEstado.Controls.Add(label4);
            groupBoxEstado.Controls.Add(comboBoxCategoria);
            groupBoxEstado.Controls.Add(label2);
            groupBoxEstado.Controls.Add(comboBoxEdificios);
            groupBoxEstado.Controls.Add(label1);
            groupBoxEstado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(87, 217);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(515, 324);
            groupBoxEstado.TabIndex = 3;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "ASIGNAR FONDOS";
            // 
            // groupBoxProxexp
            // 
            groupBoxProxexp.Anchor = AnchorStyles.None;
            groupBoxProxexp.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp.Controls.Add(labelAsignado);
            groupBoxProxexp.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp.Location = new Point(265, 105);
            groupBoxProxexp.Name = "groupBoxProxexp";
            groupBoxProxexp.Size = new Size(159, 63);
            groupBoxProxexp.TabIndex = 2;
            groupBoxProxexp.TabStop = false;
            groupBoxProxexp.Text = "ASIGNADO";
            // 
            // labelAsignado
            // 
            labelAsignado.Anchor = AnchorStyles.None;
            labelAsignado.AutoSize = true;
            labelAsignado.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAsignado.Location = new Point(2, 16);
            labelAsignado.Name = "labelAsignado";
            labelAsignado.Size = new Size(139, 19);
            labelAsignado.TabIndex = 4;
            labelAsignado.Text = "$000000000.00";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(0, 212, 255);
            panel2.Location = new Point(262, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(167, 72);
            panel2.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(groupBoxPagado);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(groupBoxEstado);
            groupBox2.Controls.Add(groupBoxProxexp);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 0;
            label1.Text = "Edificio:";
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(7, 49);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(209, 22);
            comboBoxEdificios.TabIndex = 12;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxCategoria.ForeColor = SystemColors.ControlLight;
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(272, 49);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(209, 22);
            comboBoxCategoria.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 32);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 13;
            label2.Text = "Categoria:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 95);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 16;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 95);
            label4.Name = "label4";
            label4.Size = new Size(91, 14);
            label4.TabIndex = 15;
            label4.Text = "Descripcion:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(7, 112);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(209, 166);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // textBoxMonto
            // 
            textBoxMonto.BackColor = Color.FromArgb(13, 22, 40);
            textBoxMonto.ForeColor = SystemColors.ControlLight;
            textBoxMonto.Location = new Point(272, 112);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(208, 22);
            textBoxMonto.TabIndex = 18;
            // 
            // FormRecauG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormRecauG";
            Text = "FormRecauG";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxPagado.ResumeLayout(false);
            groupBoxPagado.PerformLayout();
            groupBoxEstado.ResumeLayout(false);
            groupBoxEstado.PerformLayout();
            groupBoxProxexp.ResumeLayout(false);
            groupBoxProxexp.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxPagado;
        private Label labelExpAbon;
        private Label labelTotal;
        private Panel panelGreen;
        private GroupBox groupBoxAtencion;
        private DataGridView dataGridUltimasExp;
        private GroupBox groupBox1;
        private Button buttonPagar;
        private Label labelVenAtencion;
        private Label labelTotAtencion;
        private Panel panel3;
        private GroupBox groupBoxEstado;
        private GroupBox groupBoxDeuda;
        private Label labelExpVen;
        private Label labelDeuda;
        private GroupBox groupBoxProxexp;
        private Label labelVenProx;
        private Label labelProx;
        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox3;
        private Label labelSinAsig;
        private Panel panel4;
        private Label labelFondo;
        private Label labelAsignado;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCategoria;
        private Label label2;
        private ComboBox comboBoxEdificios;
        private TextBox textBoxMonto;
    }
}