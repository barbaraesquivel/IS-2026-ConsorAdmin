namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormCargarG
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
            groupBoxEdificios = new GroupBox();
            buttonGuard = new Button();
            buttonCancelar = new Button();
            comboBoxSituacion = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePickerVencimiento = new DateTimePicker();
            label6 = new Label();
            dateTimeFechaActual = new DateTimePicker();
            textBoxImporte = new TextBox();
            label5 = new Label();
            comboBoxSubrubro = new ComboBox();
            label4 = new Label();
            comboBoxRubro = new ComboBox();
            label3 = new Label();
            comboBoxTipo = new ComboBox();
            label2 = new Label();
            comboBoxEdificios = new ComboBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBoxEdificios.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxEdificios);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBoxEdificios
            // 
            groupBoxEdificios.Anchor = AnchorStyles.None;
            groupBoxEdificios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificios.Controls.Add(buttonGuard);
            groupBoxEdificios.Controls.Add(buttonCancelar);
            groupBoxEdificios.Controls.Add(comboBoxSituacion);
            groupBoxEdificios.Controls.Add(label8);
            groupBoxEdificios.Controls.Add(label7);
            groupBoxEdificios.Controls.Add(dateTimePickerVencimiento);
            groupBoxEdificios.Controls.Add(label6);
            groupBoxEdificios.Controls.Add(dateTimeFechaActual);
            groupBoxEdificios.Controls.Add(textBoxImporte);
            groupBoxEdificios.Controls.Add(label5);
            groupBoxEdificios.Controls.Add(comboBoxSubrubro);
            groupBoxEdificios.Controls.Add(label4);
            groupBoxEdificios.Controls.Add(comboBoxRubro);
            groupBoxEdificios.Controls.Add(label3);
            groupBoxEdificios.Controls.Add(comboBoxTipo);
            groupBoxEdificios.Controls.Add(label2);
            groupBoxEdificios.Controls.Add(comboBoxEdificios);
            groupBoxEdificios.Controls.Add(label1);
            groupBoxEdificios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificios.ForeColor = SystemColors.ControlLight;
            groupBoxEdificios.Location = new Point(19, 20);
            groupBoxEdificios.Name = "groupBoxEdificios";
            groupBoxEdificios.Size = new Size(640, 568);
            groupBoxEdificios.TabIndex = 3;
            groupBoxEdificios.TabStop = false;
            groupBoxEdificios.Text = "NUEVA EXPENSA";
            // 
            // buttonGuard
            // 
            buttonGuard.Anchor = AnchorStyles.None;
            buttonGuard.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuard.FlatAppearance.BorderSize = 0;
            buttonGuard.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuard.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuard.FlatStyle = FlatStyle.Flat;
            buttonGuard.ForeColor = SystemColors.ControlLight;
            buttonGuard.Location = new Point(74, 412);
            buttonGuard.Name = "buttonGuard";
            buttonGuard.Size = new Size(495, 36);
            buttonGuard.TabIndex = 35;
            buttonGuard.Text = "Cargar";
            buttonGuard.UseVisualStyleBackColor = false;
            buttonGuard.Click += buttonGuard_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Anchor = AnchorStyles.None;
            buttonCancelar.BackColor = Color.Transparent;
            buttonCancelar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonCancelar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonCancelar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.ForeColor = SystemColors.ControlLight;
            buttonCancelar.Location = new Point(74, 460);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(495, 36);
            buttonCancelar.TabIndex = 34;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // comboBoxSituacion
            // 
            comboBoxSituacion.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxSituacion.ForeColor = SystemColors.ControlLight;
            comboBoxSituacion.FormattingEnabled = true;
            comboBoxSituacion.Location = new Point(74, 316);
            comboBoxSituacion.Name = "comboBoxSituacion";
            comboBoxSituacion.Size = new Size(200, 22);
            comboBoxSituacion.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 300);
            label8.Name = "label8";
            label8.Size = new Size(77, 14);
            label8.TabIndex = 24;
            label8.Text = "Situacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(354, 230);
            label7.Name = "label7";
            label7.Size = new Size(154, 14);
            label7.TabIndex = 23;
            label7.Text = "Fecha de vencimiento:";
            // 
            // dateTimePickerVencimiento
            // 
            dateTimePickerVencimiento.CalendarForeColor = SystemColors.ControlLight;
            dateTimePickerVencimiento.Location = new Point(354, 254);
            dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            dateTimePickerVencimiento.Size = new Size(215, 22);
            dateTimePickerVencimiento.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(74, 230);
            label6.Name = "label6";
            label6.Size = new Size(49, 14);
            label6.TabIndex = 21;
            label6.Text = "Fecha:";
            // 
            // dateTimeFechaActual
            // 
            dateTimeFechaActual.CalendarForeColor = SystemColors.ControlLight;
            dateTimeFechaActual.Location = new Point(74, 254);
            dateTimeFechaActual.Name = "dateTimeFechaActual";
            dateTimeFechaActual.Size = new Size(200, 22);
            dateTimeFechaActual.TabIndex = 20;
            // 
            // textBoxImporte
            // 
            textBoxImporte.BackColor = Color.FromArgb(13, 22, 40);
            textBoxImporte.ForeColor = SystemColors.ControlLight;
            textBoxImporte.Location = new Point(354, 181);
            textBoxImporte.Name = "textBoxImporte";
            textBoxImporte.Size = new Size(215, 22);
            textBoxImporte.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 160);
            label5.Name = "label5";
            label5.Size = new Size(63, 14);
            label5.TabIndex = 18;
            label5.Text = "Importe:";
            // 
            // comboBoxSubrubro
            // 
            comboBoxSubrubro.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxSubrubro.ForeColor = SystemColors.ControlLight;
            comboBoxSubrubro.FormattingEnabled = true;
            comboBoxSubrubro.Location = new Point(74, 180);
            comboBoxSubrubro.Name = "comboBoxSubrubro";
            comboBoxSubrubro.Size = new Size(200, 22);
            comboBoxSubrubro.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 160);
            label4.Name = "label4";
            label4.Size = new Size(77, 14);
            label4.TabIndex = 16;
            label4.Text = "Sub-Rubro:";
            // 
            // comboBoxRubro
            // 
            comboBoxRubro.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxRubro.ForeColor = SystemColors.ControlLight;
            comboBoxRubro.FormattingEnabled = true;
            comboBoxRubro.Location = new Point(354, 122);
            comboBoxRubro.Name = "comboBoxRubro";
            comboBoxRubro.Size = new Size(215, 22);
            comboBoxRubro.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 102);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 14;
            label3.Text = "Rubro:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxTipo.ForeColor = SystemColors.ControlLight;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(74, 122);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(200, 22);
            comboBoxTipo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 102);
            label2.Name = "label2";
            label2.Size = new Size(119, 14);
            label2.TabIndex = 12;
            label2.Text = "Tipo de expensa:";
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(74, 62);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(200, 22);
            comboBoxEdificios.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 0;
            label1.Text = "Edificio:";
            // 
            // FormCargarG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCargarG";
            Text = "FormCargarG";
            groupBox2.ResumeLayout(false);
            groupBoxEdificios.ResumeLayout(false);
            groupBoxEdificios.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxEdificios;
        private Label label1;
        private ComboBox comboBoxEdificios;
        private ComboBox comboBoxSubrubro;
        private Label label4;
        private ComboBox comboBoxRubro;
        private Label label3;
        private ComboBox comboBoxTipo;
        private Label label2;
        private Label label5;
        private TextBox textBoxImporte;
        private Label label7;
        private DateTimePicker dateTimePickerVencimiento;
        private Label label6;
        private DateTimePicker dateTimeFechaActual;
        private ComboBox comboBoxSituacion;
        private Label label8;
        private Button buttonGuard;
        private Button buttonCancelar;
    }
}