namespace ConsorAdmin.FORMS_PROOVEDOR
{
    partial class formCargarP
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
            groupBox2 = new GroupBox();
            groupBoxExpensas = new GroupBox();
            buttonImprimir = new Button();
            buttonGuardar = new Button();
            label1 = new Label();
            comboBoxConsorcios = new ComboBox();
            comboBoxServicios = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            richTextBoxDetalle = new RichTextBox();
            label4 = new Label();
            dateTimePrestacion = new DateTimePicker();
            label5 = new Label();
            textBoxFacturanr = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            comboBoxEstado = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            groupBox2.SuspendLayout();
            groupBoxExpensas.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxExpensas);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // groupBoxExpensas
            // 
            groupBoxExpensas.Anchor = AnchorStyles.None;
            groupBoxExpensas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxExpensas.Controls.Add(panel1);
            groupBoxExpensas.Controls.Add(label9);
            groupBoxExpensas.Controls.Add(comboBoxEstado);
            groupBoxExpensas.Controls.Add(label8);
            groupBoxExpensas.Controls.Add(textBox2);
            groupBoxExpensas.Controls.Add(label7);
            groupBoxExpensas.Controls.Add(textBox1);
            groupBoxExpensas.Controls.Add(label6);
            groupBoxExpensas.Controls.Add(textBoxFacturanr);
            groupBoxExpensas.Controls.Add(label5);
            groupBoxExpensas.Controls.Add(dateTimePrestacion);
            groupBoxExpensas.Controls.Add(label4);
            groupBoxExpensas.Controls.Add(richTextBoxDetalle);
            groupBoxExpensas.Controls.Add(label3);
            groupBoxExpensas.Controls.Add(comboBoxServicios);
            groupBoxExpensas.Controls.Add(label2);
            groupBoxExpensas.Controls.Add(comboBoxConsorcios);
            groupBoxExpensas.Controls.Add(label1);
            groupBoxExpensas.Controls.Add(buttonGuardar);
            groupBoxExpensas.Controls.Add(buttonImprimir);
            groupBoxExpensas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxExpensas.ForeColor = SystemColors.ControlLight;
            groupBoxExpensas.Location = new Point(12, 21);
            groupBoxExpensas.Name = "groupBoxExpensas";
            groupBoxExpensas.Size = new Size(655, 564);
            groupBoxExpensas.TabIndex = 5;
            groupBoxExpensas.TabStop = false;
            groupBoxExpensas.Text = "Registrar Servicio Prestado";
            // 
            // buttonImprimir
            // 
            buttonImprimir.Anchor = AnchorStyles.None;
            buttonImprimir.BackColor = Color.FromArgb(0, 187, 118);
            buttonImprimir.FlatAppearance.BorderSize = 0;
            buttonImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonImprimir.FlatStyle = FlatStyle.Flat;
            buttonImprimir.ForeColor = SystemColors.ControlLight;
            buttonImprimir.Location = new Point(37, 477);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(202, 36);
            buttonImprimir.TabIndex = 14;
            buttonImprimir.Text = "Cargar Servicio";
            buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.BackColor = Color.Transparent;
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonGuardar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonGuardar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = SystemColors.ControlLight;
            buttonGuardar.Location = new Point(264, 477);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(202, 36);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Limpiar Campos";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 16;
            label1.Text = "Consorcio";
            // 
            // comboBoxConsorcios
            // 
            comboBoxConsorcios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxConsorcios.ForeColor = SystemColors.ControlLight;
            comboBoxConsorcios.FormattingEnabled = true;
            comboBoxConsorcios.Location = new Point(39, 53);
            comboBoxConsorcios.Name = "comboBoxConsorcios";
            comboBoxConsorcios.Size = new Size(231, 22);
            comboBoxConsorcios.TabIndex = 17;
            // 
            // comboBoxServicios
            // 
            comboBoxServicios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxServicios.ForeColor = SystemColors.ControlLight;
            comboBoxServicios.FormattingEnabled = true;
            comboBoxServicios.Location = new Point(347, 53);
            comboBoxServicios.Name = "comboBoxServicios";
            comboBoxServicios.Size = new Size(231, 22);
            comboBoxServicios.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 36);
            label2.Name = "label2";
            label2.Size = new Size(119, 14);
            label2.TabIndex = 18;
            label2.Text = "Tipo de Servicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 97);
            label3.Name = "label3";
            label3.Size = new Size(140, 14);
            label3.TabIndex = 20;
            label3.Text = "Detalle del Trabajo";
            // 
            // richTextBoxDetalle
            // 
            richTextBoxDetalle.BackColor = Color.FromArgb(13, 22, 40);
            richTextBoxDetalle.ForeColor = SystemColors.ControlLight;
            richTextBoxDetalle.Location = new Point(39, 114);
            richTextBoxDetalle.Name = "richTextBoxDetalle";
            richTextBoxDetalle.Size = new Size(539, 87);
            richTextBoxDetalle.TabIndex = 21;
            richTextBoxDetalle.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 229);
            label4.Name = "label4";
            label4.Size = new Size(140, 14);
            label4.TabIndex = 22;
            label4.Text = "Fecha de Prestación";
            // 
            // dateTimePrestacion
            // 
            dateTimePrestacion.CalendarForeColor = SystemColors.ControlLight;
            dateTimePrestacion.Location = new Point(39, 246);
            dateTimePrestacion.Name = "dateTimePrestacion";
            dateTimePrestacion.Size = new Size(231, 22);
            dateTimePrestacion.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 229);
            label5.Name = "label5";
            label5.Size = new Size(98, 14);
            label5.TabIndex = 24;
            label5.Text = "N° de Factura";
            // 
            // textBoxFacturanr
            // 
            textBoxFacturanr.BackColor = Color.FromArgb(13, 22, 40);
            textBoxFacturanr.ForeColor = SystemColors.ControlLight;
            textBoxFacturanr.Location = new Point(347, 249);
            textBoxFacturanr.Name = "textBoxFacturanr";
            textBoxFacturanr.Size = new Size(231, 22);
            textBoxFacturanr.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(13, 22, 40);
            textBox1.ForeColor = SystemColors.ControlLight;
            textBox1.Location = new Point(39, 315);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 22);
            textBox1.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 295);
            label6.Name = "label6";
            label6.Size = new Size(77, 14);
            label6.TabIndex = 26;
            label6.Text = "Monto Base";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(13, 22, 40);
            textBox2.ForeColor = SystemColors.ControlLight;
            textBox2.Location = new Point(347, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 22);
            textBox2.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(347, 295);
            label7.Name = "label7";
            label7.Size = new Size(98, 14);
            label7.TabIndex = 28;
            label7.Text = "Gastos Extras";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEstado.ForeColor = SystemColors.ControlLight;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(347, 377);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(231, 22);
            comboBoxEstado.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(347, 360);
            label8.Name = "label8";
            label8.Size = new Size(119, 14);
            label8.TabIndex = 30;
            label8.Text = "Estado del Cobro";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(39, 360);
            label9.Name = "label9";
            label9.Size = new Size(42, 14);
            label9.TabIndex = 32;
            label9.Text = "Total";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(16, 44, 59);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(39, 377);
            panel1.Name = "panel1";
            panel1.Size = new Size(231, 32);
            panel1.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 201, 127);
            label10.Location = new Point(4, 8);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 34;
            label10.Text = "$1.234,56";
            // 
            // formCargarP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formCargarP";
            Text = "formCargarP";
            groupBox2.ResumeLayout(false);
            groupBoxExpensas.ResumeLayout(false);
            groupBoxExpensas.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxExpensas;
        private Button buttonGuardar;
        private Button buttonImprimir;
        private Label label1;
        private Label label4;
        private RichTextBox richTextBoxDetalle;
        private Label label3;
        private ComboBox comboBoxServicios;
        private Label label2;
        private ComboBox comboBoxConsorcios;
        private DateTimePicker dateTimePrestacion;
        private TextBox textBoxFacturanr;
        private Label label5;
        private Panel panel1;
        private Label label9;
        private ComboBox comboBoxEstado;
        private Label label8;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private Label label10;
    }
}