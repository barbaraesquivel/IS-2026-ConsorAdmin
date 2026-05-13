namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormEdificiosG
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
            groupBoxEstado = new GroupBox();
            textBoxSuperficie = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBoxLocalidad = new ComboBox();
            label2 = new Label();
            comboBoxEdificios = new ComboBox();
            label1 = new Label();
            textBoxNombre = new TextBox();
            buttonGuardar = new Button();
            groupBox1 = new GroupBox();
            dataGridViewEdificios = new DataGridView();
            groupBox2.SuspendLayout();
            groupBoxEstado.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(groupBoxEstado);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.None;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(buttonGuardar);
            groupBoxEstado.Controls.Add(textBoxNombre);
            groupBoxEstado.Controls.Add(textBoxSuperficie);
            groupBoxEstado.Controls.Add(label3);
            groupBoxEstado.Controls.Add(label4);
            groupBoxEstado.Controls.Add(comboBoxLocalidad);
            groupBoxEstado.Controls.Add(label2);
            groupBoxEstado.Controls.Add(comboBoxEdificios);
            groupBoxEstado.Controls.Add(label1);
            groupBoxEstado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(40, 32);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(601, 201);
            groupBoxEstado.TabIndex = 3;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "EDITAR EDIFICIOS";
            // 
            // textBoxSuperficie
            // 
            textBoxSuperficie.BackColor = Color.FromArgb(13, 22, 40);
            textBoxSuperficie.ForeColor = SystemColors.ControlLight;
            textBoxSuperficie.Location = new Point(319, 112);
            textBoxSuperficie.Name = "textBoxSuperficie";
            textBoxSuperficie.Size = new Size(208, 22);
            textBoxSuperficie.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 95);
            label3.Name = "label3";
            label3.Size = new Size(196, 14);
            label3.TabIndex = 16;
            label3.Text = "Superficie (mts cuadrados):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 95);
            label4.Name = "label4";
            label4.Size = new Size(56, 14);
            label4.TabIndex = 15;
            label4.Text = "Nombre:";
            // 
            // comboBoxLocalidad
            // 
            comboBoxLocalidad.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxLocalidad.ForeColor = SystemColors.ControlLight;
            comboBoxLocalidad.FormattingEnabled = true;
            comboBoxLocalidad.Location = new Point(319, 49);
            comboBoxLocalidad.Name = "comboBoxLocalidad";
            comboBoxLocalidad.Size = new Size(209, 22);
            comboBoxLocalidad.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 32);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 13;
            label2.Text = "Localidad:";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 32);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 0;
            label1.Text = "Edificio:";
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
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = SystemColors.ControlLight;
            buttonGuardar.Location = new Point(112, 154);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(338, 36);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Guardar Cambios";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(dataGridViewEdificios);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(40, 255);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 318);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "EDIFICIOS";
            // 
            // dataGridViewEdificios
            // 
            dataGridViewEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEdificios.Location = new Point(7, 21);
            dataGridViewEdificios.Name = "dataGridViewEdificios";
            dataGridViewEdificios.Size = new Size(587, 277);
            dataGridViewEdificios.TabIndex = 0;
            // 
            // FormEdificiosG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "FormEdificiosG";
            Text = "FormEdificiosG";
            groupBox2.ResumeLayout(false);
            groupBoxEstado.ResumeLayout(false);
            groupBoxEstado.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxEstado;
        private TextBox textBoxSuperficie;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxLocalidad;
        private Label label2;
        private ComboBox comboBoxEdificios;
        private Label label1;
        private TextBox textBoxNombre;
        private Button buttonGuardar;
        private GroupBox groupBox1;
        private DataGridView dataGridViewEdificios;
    }
}