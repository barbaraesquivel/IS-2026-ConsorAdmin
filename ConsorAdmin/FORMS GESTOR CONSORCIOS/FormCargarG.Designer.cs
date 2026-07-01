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
            groupBoxNuevaExp_FormCargarG = new GroupBox();
            buttonGuard_FormCargarG = new Button();
            buttonCancelar_FormCargarG = new Button();
            comboBoxSituacion = new ComboBox();
            labelSituacion_FormCargarG = new Label();
            labelFechaVencimiento_FormCargarG = new Label();
            dateTimePickerVencimiento = new DateTimePicker();
            labelFecha_FormCargarG = new Label();
            dateTimeFechaActual = new DateTimePicker();
            textBoxImporte = new TextBox();
            labelImporte_FormCargarG = new Label();
            comboBoxSubrubro = new ComboBox();
            labelSubRubro_FormCargarG = new Label();
            comboBoxRubro = new ComboBox();
            labelRubro_FormCargarG = new Label();
            comboBoxTipo = new ComboBox();
            labelTipoExp_FormCargarG = new Label();
            comboBoxEdificios = new ComboBox();
            labelEdificio_FormCargarG = new Label();
            groupBox2.SuspendLayout();
            groupBoxNuevaExp_FormCargarG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxNuevaExp_FormCargarG);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBoxNuevaExp_FormCargarG
            // 
            groupBoxNuevaExp_FormCargarG.Anchor = AnchorStyles.None;
            groupBoxNuevaExp_FormCargarG.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxNuevaExp_FormCargarG.Controls.Add(buttonGuard_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(buttonCancelar_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(comboBoxSituacion);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelSituacion_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelFechaVencimiento_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(dateTimePickerVencimiento);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelFecha_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(dateTimeFechaActual);
            groupBoxNuevaExp_FormCargarG.Controls.Add(textBoxImporte);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelImporte_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(comboBoxSubrubro);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelSubRubro_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(comboBoxRubro);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelRubro_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(comboBoxTipo);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelTipoExp_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Controls.Add(comboBoxEdificios);
            groupBoxNuevaExp_FormCargarG.Controls.Add(labelEdificio_FormCargarG);
            groupBoxNuevaExp_FormCargarG.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxNuevaExp_FormCargarG.ForeColor = SystemColors.ControlLight;
            groupBoxNuevaExp_FormCargarG.Location = new Point(19, 20);
            groupBoxNuevaExp_FormCargarG.Name = "groupBoxNuevaExp_FormCargarG";
            groupBoxNuevaExp_FormCargarG.Size = new Size(640, 568);
            groupBoxNuevaExp_FormCargarG.TabIndex = 3;
            groupBoxNuevaExp_FormCargarG.TabStop = false;
            groupBoxNuevaExp_FormCargarG.Text = "NUEVA EXPENSA";
            // 
            // buttonGuard_FormCargarG
            // 
            buttonGuard_FormCargarG.Anchor = AnchorStyles.None;
            buttonGuard_FormCargarG.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuard_FormCargarG.FlatAppearance.BorderSize = 0;
            buttonGuard_FormCargarG.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuard_FormCargarG.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuard_FormCargarG.FlatStyle = FlatStyle.Flat;
            buttonGuard_FormCargarG.ForeColor = SystemColors.ControlLight;
            buttonGuard_FormCargarG.Location = new Point(74, 412);
            buttonGuard_FormCargarG.Name = "buttonGuard_FormCargarG";
            buttonGuard_FormCargarG.Size = new Size(495, 36);
            buttonGuard_FormCargarG.TabIndex = 35;
            buttonGuard_FormCargarG.Text = "Cargar";
            buttonGuard_FormCargarG.UseVisualStyleBackColor = false;
            buttonGuard_FormCargarG.Click += buttonGuard_Click;
            // 
            // buttonCancelar_FormCargarG
            // 
            buttonCancelar_FormCargarG.Anchor = AnchorStyles.None;
            buttonCancelar_FormCargarG.BackColor = Color.Transparent;
            buttonCancelar_FormCargarG.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonCancelar_FormCargarG.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonCancelar_FormCargarG.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonCancelar_FormCargarG.FlatStyle = FlatStyle.Flat;
            buttonCancelar_FormCargarG.ForeColor = SystemColors.ControlLight;
            buttonCancelar_FormCargarG.Location = new Point(74, 460);
            buttonCancelar_FormCargarG.Name = "buttonCancelar_FormCargarG";
            buttonCancelar_FormCargarG.Size = new Size(495, 36);
            buttonCancelar_FormCargarG.TabIndex = 34;
            buttonCancelar_FormCargarG.Text = "Cancelar";
            buttonCancelar_FormCargarG.UseVisualStyleBackColor = false;
            buttonCancelar_FormCargarG.Click += buttonCancelar_Click;
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
            // labelSituacion_FormCargarG
            // 
            labelSituacion_FormCargarG.AutoSize = true;
            labelSituacion_FormCargarG.Location = new Point(74, 300);
            labelSituacion_FormCargarG.Name = "labelSituacion_FormCargarG";
            labelSituacion_FormCargarG.Size = new Size(77, 14);
            labelSituacion_FormCargarG.TabIndex = 24;
            labelSituacion_FormCargarG.Text = "Situacion:";
            // 
            // labelFechaVencimiento_FormCargarG
            // 
            labelFechaVencimiento_FormCargarG.AutoSize = true;
            labelFechaVencimiento_FormCargarG.Location = new Point(354, 230);
            labelFechaVencimiento_FormCargarG.Name = "labelFechaVencimiento_FormCargarG";
            labelFechaVencimiento_FormCargarG.Size = new Size(154, 14);
            labelFechaVencimiento_FormCargarG.TabIndex = 23;
            labelFechaVencimiento_FormCargarG.Text = "Fecha de vencimiento:";
            // 
            // dateTimePickerVencimiento
            // 
            dateTimePickerVencimiento.CalendarForeColor = SystemColors.ControlLight;
            dateTimePickerVencimiento.Location = new Point(354, 254);
            dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            dateTimePickerVencimiento.Size = new Size(215, 22);
            dateTimePickerVencimiento.TabIndex = 22;
            // 
            // labelFecha_FormCargarG
            // 
            labelFecha_FormCargarG.AutoSize = true;
            labelFecha_FormCargarG.Location = new Point(74, 230);
            labelFecha_FormCargarG.Name = "labelFecha_FormCargarG";
            labelFecha_FormCargarG.Size = new Size(49, 14);
            labelFecha_FormCargarG.TabIndex = 21;
            labelFecha_FormCargarG.Text = "Fecha:";
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
            // labelImporte_FormCargarG
            // 
            labelImporte_FormCargarG.AutoSize = true;
            labelImporte_FormCargarG.Location = new Point(354, 160);
            labelImporte_FormCargarG.Name = "labelImporte_FormCargarG";
            labelImporte_FormCargarG.Size = new Size(63, 14);
            labelImporte_FormCargarG.TabIndex = 18;
            labelImporte_FormCargarG.Text = "Importe:";
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
            // labelSubRubro_FormCargarG
            // 
            labelSubRubro_FormCargarG.AutoSize = true;
            labelSubRubro_FormCargarG.Location = new Point(74, 160);
            labelSubRubro_FormCargarG.Name = "labelSubRubro_FormCargarG";
            labelSubRubro_FormCargarG.Size = new Size(77, 14);
            labelSubRubro_FormCargarG.TabIndex = 16;
            labelSubRubro_FormCargarG.Text = "Sub-Rubro:";
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
            // labelRubro_FormCargarG
            // 
            labelRubro_FormCargarG.AutoSize = true;
            labelRubro_FormCargarG.Location = new Point(354, 102);
            labelRubro_FormCargarG.Name = "labelRubro_FormCargarG";
            labelRubro_FormCargarG.Size = new Size(49, 14);
            labelRubro_FormCargarG.TabIndex = 14;
            labelRubro_FormCargarG.Text = "Rubro:";
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
            // labelTipoExp_FormCargarG
            // 
            labelTipoExp_FormCargarG.AutoSize = true;
            labelTipoExp_FormCargarG.Location = new Point(74, 102);
            labelTipoExp_FormCargarG.Name = "labelTipoExp_FormCargarG";
            labelTipoExp_FormCargarG.Size = new Size(119, 14);
            labelTipoExp_FormCargarG.TabIndex = 12;
            labelTipoExp_FormCargarG.Text = "Tipo de expensa:";
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
            // labelEdificio_FormCargarG
            // 
            labelEdificio_FormCargarG.AutoSize = true;
            labelEdificio_FormCargarG.Location = new Point(74, 43);
            labelEdificio_FormCargarG.Name = "labelEdificio_FormCargarG";
            labelEdificio_FormCargarG.Size = new Size(70, 14);
            labelEdificio_FormCargarG.TabIndex = 0;
            labelEdificio_FormCargarG.Text = "Edificio:";
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
            Load += FormCargarG_Load;
            FormClosing += FormCargarG_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBoxNuevaExp_FormCargarG.ResumeLayout(false);
            groupBoxNuevaExp_FormCargarG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxNuevaExp_FormCargarG;
        private Label labelEdificio_FormCargarG;
        private ComboBox comboBoxEdificios;
        private ComboBox comboBoxSubrubro;
        private Label labelSubRubro_FormCargarG;
        private ComboBox comboBoxRubro;
        private Label labelRubro_FormCargarG;
        private ComboBox comboBoxTipo;
        private Label labelTipoExp_FormCargarG;
        private Label labelImporte_FormCargarG;
        private TextBox textBoxImporte;
        private Label labelFechaVencimiento_FormCargarG;
        private DateTimePicker dateTimePickerVencimiento;
        private Label labelFecha_FormCargarG;
        private DateTimePicker dateTimeFechaActual;
        private ComboBox comboBoxSituacion;
        private Label labelSituacion_FormCargarG;
        private Button buttonGuard_FormCargarG;
        private Button buttonCancelar_FormCargarG;
    }
}