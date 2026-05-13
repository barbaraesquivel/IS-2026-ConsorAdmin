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
            comboBoxSubrubro = new ComboBox();
            label4 = new Label();
            comboBoxRubro = new ComboBox();
            label3 = new Label();
            comboBoxTipo = new ComboBox();
            label2 = new Label();
            comboBoxEdificios = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            textBoxImporte = new TextBox();
            dateTimeFechaActual = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dateTimePickerVencimiento = new DateTimePicker();
            label8 = new Label();
            comboBoxSituacion = new ComboBox();
            buttonGuard = new Button();
            buttonCancelar = new Button();
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
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(779, 796);
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
            groupBoxEdificios.Location = new Point(22, 26);
            groupBoxEdificios.Margin = new Padding(3, 4, 3, 4);
            groupBoxEdificios.Name = "groupBoxEdificios";
            groupBoxEdificios.Padding = new Padding(3, 4, 3, 4);
            groupBoxEdificios.Size = new Size(731, 757);
            groupBoxEdificios.TabIndex = 3;
            groupBoxEdificios.TabStop = false;
            groupBoxEdificios.Text = "NUEVA EXPENSA";
            // 
            // comboBoxSubrubro
            // 
            comboBoxSubrubro.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxSubrubro.ForeColor = SystemColors.ControlLight;
            comboBoxSubrubro.FormattingEnabled = true;
            comboBoxSubrubro.Location = new Point(84, 240);
            comboBoxSubrubro.Margin = new Padding(3, 4, 3, 4);
            comboBoxSubrubro.Name = "comboBoxSubrubro";
            comboBoxSubrubro.Size = new Size(228, 26);
            comboBoxSubrubro.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 213);
            label4.Name = "label4";
            label4.Size = new Size(98, 18);
            label4.TabIndex = 16;
            label4.Text = "Sub-Rubro:";
            // 
            // comboBoxRubro
            // 
            comboBoxRubro.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxRubro.ForeColor = SystemColors.ControlLight;
            comboBoxRubro.FormattingEnabled = true;
            comboBoxRubro.Location = new Point(405, 163);
            comboBoxRubro.Margin = new Padding(3, 4, 3, 4);
            comboBoxRubro.Name = "comboBoxRubro";
            comboBoxRubro.Size = new Size(245, 26);
            comboBoxRubro.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 136);
            label3.Name = "label3";
            label3.Size = new Size(62, 18);
            label3.TabIndex = 14;
            label3.Text = "Rubro:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxTipo.ForeColor = SystemColors.ControlLight;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(84, 163);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(228, 26);
            comboBoxTipo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 136);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 12;
            label2.Text = "Tipo de expensa:";
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(84, 82);
            comboBoxEdificios.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(228, 26);
            comboBoxEdificios.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 57);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 0;
            label1.Text = "Edificio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 213);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 18;
            label5.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            textBoxImporte.BackColor = Color.FromArgb(13, 22, 40);
            textBoxImporte.ForeColor = SystemColors.ControlLight;
            textBoxImporte.Location = new Point(405, 241);
            textBoxImporte.Margin = new Padding(3, 4, 3, 4);
            textBoxImporte.Name = "textBoxImporte";
            textBoxImporte.Size = new Size(245, 25);
            textBoxImporte.TabIndex = 19;
            // 
            // dateTimeFechaActual
            // 
            dateTimeFechaActual.CalendarForeColor = SystemColors.ControlLight;
            dateTimeFechaActual.Location = new Point(84, 339);
            dateTimeFechaActual.Margin = new Padding(3, 4, 3, 4);
            dateTimeFechaActual.Name = "dateTimeFechaActual";
            dateTimeFechaActual.Size = new Size(228, 25);
            dateTimeFechaActual.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 307);
            label6.Name = "label6";
            label6.Size = new Size(62, 18);
            label6.TabIndex = 21;
            label6.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(405, 307);
            label7.Name = "label7";
            label7.Size = new Size(197, 18);
            label7.TabIndex = 23;
            label7.Text = "Fecha de vencimiento:";
            // 
            // dateTimePickerVencimiento
            // 
            dateTimePickerVencimiento.CalendarForeColor = SystemColors.ControlLight;
            dateTimePickerVencimiento.Location = new Point(405, 339);
            dateTimePickerVencimiento.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            dateTimePickerVencimiento.Size = new Size(245, 25);
            dateTimePickerVencimiento.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(84, 400);
            label8.Name = "label8";
            label8.Size = new Size(98, 18);
            label8.TabIndex = 24;
            label8.Text = "Situacion:";
            // 
            // comboBoxSituacion
            // 
            comboBoxSituacion.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxSituacion.ForeColor = SystemColors.ControlLight;
            comboBoxSituacion.FormattingEnabled = true;
            comboBoxSituacion.Location = new Point(84, 422);
            comboBoxSituacion.Margin = new Padding(3, 4, 3, 4);
            comboBoxSituacion.Name = "comboBoxSituacion";
            comboBoxSituacion.Size = new Size(228, 26);
            comboBoxSituacion.TabIndex = 25;
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
            buttonGuard.Location = new Point(84, 550);
            buttonGuard.Margin = new Padding(3, 4, 3, 4);
            buttonGuard.Name = "buttonGuard";
            buttonGuard.Size = new Size(566, 48);
            buttonGuard.TabIndex = 35;
            buttonGuard.Text = "Cargar";
            buttonGuard.UseVisualStyleBackColor = false;
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
            buttonCancelar.Location = new Point(84, 613);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(566, 48);
            buttonCancelar.TabIndex = 34;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormCargarG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(779, 796);
            Controls.Add(groupBox2);
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