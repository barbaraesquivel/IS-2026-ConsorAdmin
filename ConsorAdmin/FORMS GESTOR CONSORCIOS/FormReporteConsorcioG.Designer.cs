namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormReporteConsorcioG
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            groupBoxEdificio_FormReporteConsorcioG = new GroupBox();
            dataGridViewEdificios = new DataGridView();
            groupBoxEditarEdificios_FormReporteConsorcioG = new GroupBox();
            textBoxDireccion = new TextBox();
            buttonGuardar_FormReporteConsorcioG = new Button();
            textBoxNombre = new TextBox();
            textBoxCantUnid = new TextBox();
            labelCantUnid_FormReporteConsorcioG = new Label();
            labelNombre_FormReporteConsorcioG = new Label();
            labelDireccion_FormReporteConsorcioG = new Label();
            comboBoxEdificios = new ComboBox();
            labelEdificio_FormReporteConsorcioG = new Label();
            groupBox2.SuspendLayout();
            groupBoxEdificio_FormReporteConsorcioG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).BeginInit();
            groupBoxEditarEdificios_FormReporteConsorcioG.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBoxEdificio_FormReporteConsorcioG);
            groupBox2.Controls.Add(groupBoxEditarEdificios_FormReporteConsorcioG);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBoxEdificio_FormReporteConsorcioG
            // 
            groupBoxEdificio_FormReporteConsorcioG.Anchor = AnchorStyles.None;
            groupBoxEdificio_FormReporteConsorcioG.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificio_FormReporteConsorcioG.Controls.Add(dataGridViewEdificios);
            groupBoxEdificio_FormReporteConsorcioG.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificio_FormReporteConsorcioG.ForeColor = SystemColors.ControlLight;
            groupBoxEdificio_FormReporteConsorcioG.Location = new Point(40, 255);
            groupBoxEdificio_FormReporteConsorcioG.Name = "groupBoxEdificio_FormReporteConsorcioG";
            groupBoxEdificio_FormReporteConsorcioG.Size = new Size(601, 318);
            groupBoxEdificio_FormReporteConsorcioG.TabIndex = 21;
            groupBoxEdificio_FormReporteConsorcioG.TabStop = false;
            groupBoxEdificio_FormReporteConsorcioG.Text = "EDIFICIOS";
            // 
            // dataGridViewEdificios
            // 
            dataGridViewEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEdificios.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEdificios.Location = new Point(7, 21);
            dataGridViewEdificios.Name = "dataGridViewEdificios";
            dataGridViewEdificios.Size = new Size(587, 277);
            dataGridViewEdificios.TabIndex = 0;
            // 
            // groupBoxEditarEdificios_FormReporteConsorcioG
            // 
            groupBoxEditarEdificios_FormReporteConsorcioG.Anchor = AnchorStyles.None;
            groupBoxEditarEdificios_FormReporteConsorcioG.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(textBoxDireccion);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(buttonGuardar_FormReporteConsorcioG);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(textBoxNombre);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(textBoxCantUnid);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(labelCantUnid_FormReporteConsorcioG);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(labelNombre_FormReporteConsorcioG);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(labelDireccion_FormReporteConsorcioG);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(comboBoxEdificios);
            groupBoxEditarEdificios_FormReporteConsorcioG.Controls.Add(labelEdificio_FormReporteConsorcioG);
            groupBoxEditarEdificios_FormReporteConsorcioG.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEditarEdificios_FormReporteConsorcioG.ForeColor = SystemColors.ControlLight;
            groupBoxEditarEdificios_FormReporteConsorcioG.Location = new Point(40, 32);
            groupBoxEditarEdificios_FormReporteConsorcioG.Name = "groupBoxEditarEdificios_FormReporteConsorcioG";
            groupBoxEditarEdificios_FormReporteConsorcioG.Size = new Size(601, 201);
            groupBoxEditarEdificios_FormReporteConsorcioG.TabIndex = 3;
            groupBoxEditarEdificios_FormReporteConsorcioG.TabStop = false;
            groupBoxEditarEdificios_FormReporteConsorcioG.Text = "EDITAR EDIFICIOS";
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.FromArgb(13, 22, 40);
            textBoxDireccion.ForeColor = SystemColors.ControlLight;
            textBoxDireccion.Location = new Point(319, 49);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(208, 22);
            textBoxDireccion.TabIndex = 21;
            // 
            // buttonGuardar_FormReporteConsorcioG
            // 
            buttonGuardar_FormReporteConsorcioG.Anchor = AnchorStyles.None;
            buttonGuardar_FormReporteConsorcioG.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuardar_FormReporteConsorcioG.FlatAppearance.BorderSize = 0;
            buttonGuardar_FormReporteConsorcioG.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar_FormReporteConsorcioG.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar_FormReporteConsorcioG.FlatStyle = FlatStyle.Flat;
            buttonGuardar_FormReporteConsorcioG.ForeColor = SystemColors.ControlLight;
            buttonGuardar_FormReporteConsorcioG.Location = new Point(112, 154);
            buttonGuardar_FormReporteConsorcioG.Name = "buttonGuardar_FormReporteConsorcioG";
            buttonGuardar_FormReporteConsorcioG.Size = new Size(338, 36);
            buttonGuardar_FormReporteConsorcioG.TabIndex = 20;
            buttonGuardar_FormReporteConsorcioG.Text = "Guardar Cambios";
            buttonGuardar_FormReporteConsorcioG.UseVisualStyleBackColor = false;
            buttonGuardar_FormReporteConsorcioG.Click += buttonGuardar_Click;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNombre.ForeColor = SystemColors.ControlLight;
            textBoxNombre.Location = new Point(25, 112);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(208, 22);
            textBoxNombre.TabIndex = 19;
            // 
            // textBoxCantUnid
            // 
            textBoxCantUnid.BackColor = Color.FromArgb(13, 22, 40);
            textBoxCantUnid.ForeColor = SystemColors.ControlLight;
            textBoxCantUnid.Location = new Point(319, 112);
            textBoxCantUnid.Name = "textBoxCantUnid";
            textBoxCantUnid.Size = new Size(208, 22);
            textBoxCantUnid.TabIndex = 18;
            // 
            // labelCantUnid_FormReporteConsorcioG
            // 
            labelCantUnid_FormReporteConsorcioG.AutoSize = true;
            labelCantUnid_FormReporteConsorcioG.Location = new Point(319, 95);
            labelCantUnid_FormReporteConsorcioG.Name = "labelCantUnid_FormReporteConsorcioG";
            labelCantUnid_FormReporteConsorcioG.Size = new Size(154, 14);
            labelCantUnid_FormReporteConsorcioG.TabIndex = 16;
            labelCantUnid_FormReporteConsorcioG.Text = "Cantidad de unidades:";
            // 
            // labelNombre_FormReporteConsorcioG
            // 
            labelNombre_FormReporteConsorcioG.AutoSize = true;
            labelNombre_FormReporteConsorcioG.Location = new Point(24, 95);
            labelNombre_FormReporteConsorcioG.Name = "labelNombre_FormReporteConsorcioG";
            labelNombre_FormReporteConsorcioG.Size = new Size(56, 14);
            labelNombre_FormReporteConsorcioG.TabIndex = 15;
            labelNombre_FormReporteConsorcioG.Text = "Nombre:";
            // 
            // labelDireccion_FormReporteConsorcioG
            // 
            labelDireccion_FormReporteConsorcioG.AutoSize = true;
            labelDireccion_FormReporteConsorcioG.Location = new Point(319, 32);
            labelDireccion_FormReporteConsorcioG.Name = "labelDireccion_FormReporteConsorcioG";
            labelDireccion_FormReporteConsorcioG.Size = new Size(77, 14);
            labelDireccion_FormReporteConsorcioG.TabIndex = 13;
            labelDireccion_FormReporteConsorcioG.Text = "Direccion:";
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(24, 49);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(209, 22);
            comboBoxEdificios.TabIndex = 12;
            // 
            // labelEdificio_FormReporteConsorcioG
            // 
            labelEdificio_FormReporteConsorcioG.AutoSize = true;
            labelEdificio_FormReporteConsorcioG.Location = new Point(24, 32);
            labelEdificio_FormReporteConsorcioG.Name = "labelEdificio_FormReporteConsorcioG";
            labelEdificio_FormReporteConsorcioG.Size = new Size(70, 14);
            labelEdificio_FormReporteConsorcioG.TabIndex = 0;
            labelEdificio_FormReporteConsorcioG.Text = "Edificio:";
            // 
            // FormReporteConsorcioG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "FormReporteConsorcioG";
            Text = "FormEdificiosG";
            Load += FormEdificiosG_Load;
            FormClosing += FormReporteConsorcioG_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBoxEdificio_FormReporteConsorcioG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).EndInit();
            groupBoxEditarEdificios_FormReporteConsorcioG.ResumeLayout(false);
            groupBoxEditarEdificios_FormReporteConsorcioG.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxEditarEdificios_FormReporteConsorcioG;
        private TextBox textBoxCantUnid;
        private Label labelCantUnid_FormReporteConsorcioG;
        private Label labelNombre_FormReporteConsorcioG;
        private Label labelDireccion_FormReporteConsorcioG;
        private ComboBox comboBoxEdificios;
        private Label labelEdificio_FormReporteConsorcioG;
        private TextBox textBoxNombre;
        private Button buttonGuardar_FormReporteConsorcioG;
        private GroupBox groupBoxEdificio_FormReporteConsorcioG;
        private DataGridView dataGridViewEdificios;
        private TextBox textBoxDireccion;
    }
}