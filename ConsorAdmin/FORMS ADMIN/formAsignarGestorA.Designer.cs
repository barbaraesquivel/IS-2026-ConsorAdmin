namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formAsignarGestorA
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
            groupBoxEliminar = new GroupBox();
            buttonEliminar = new Button();
            comboBoxEdificio = new ComboBox();
            label12 = new Label();
            comboBoxGestor = new ComboBox();
            label1 = new Label();
            groupBoxEdificios = new GroupBox();
            dataGridEdificios = new DataGridView();
            groupBoxEliminar.SuspendLayout();
            groupBoxEdificios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Anchor = AnchorStyles.None;
            groupBoxEliminar.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEliminar.Controls.Add(comboBoxGestor);
            groupBoxEliminar.Controls.Add(label1);
            groupBoxEliminar.Controls.Add(buttonEliminar);
            groupBoxEliminar.Controls.Add(comboBoxEdificio);
            groupBoxEliminar.Controls.Add(label12);
            groupBoxEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEliminar.ForeColor = SystemColors.ControlLight;
            groupBoxEliminar.Location = new Point(15, 48);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(655, 80);
            groupBoxEliminar.TabIndex = 8;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Asignar Gestor";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.None;
            buttonEliminar.BackColor = Color.FromArgb(0, 187, 118);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = SystemColors.ControlLight;
            buttonEliminar.Location = new Point(92, 48);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(481, 26);
            buttonEliminar.TabIndex = 41;
            buttonEliminar.Text = "Asignar Gestor";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // comboBoxEdificio
            // 
            comboBoxEdificio.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificio.ForeColor = SystemColors.ControlLight;
            comboBoxEdificio.FormattingEnabled = true;
            comboBoxEdificio.Location = new Point(116, 21);
            comboBoxEdificio.Name = "comboBoxEdificio";
            comboBoxEdificio.Size = new Size(177, 22);
            comboBoxEdificio.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 24);
            label12.Name = "label12";
            label12.Size = new Size(70, 14);
            label12.TabIndex = 38;
            label12.Text = "Edificio:";
            // 
            // comboBoxGestor
            // 
            comboBoxGestor.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxGestor.ForeColor = SystemColors.ControlLight;
            comboBoxGestor.FormattingEnabled = true;
            comboBoxGestor.Location = new Point(444, 21);
            comboBoxGestor.Name = "comboBoxGestor";
            comboBoxGestor.Size = new Size(177, 22);
            comboBoxGestor.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 42;
            label1.Text = "Gestor:";
            // 
            // groupBoxEdificios
            // 
            groupBoxEdificios.Anchor = AnchorStyles.None;
            groupBoxEdificios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificios.Controls.Add(dataGridEdificios);
            groupBoxEdificios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificios.ForeColor = SystemColors.ControlLight;
            groupBoxEdificios.Location = new Point(15, 156);
            groupBoxEdificios.Name = "groupBoxEdificios";
            groupBoxEdificios.Size = new Size(655, 303);
            groupBoxEdificios.TabIndex = 9;
            groupBoxEdificios.TabStop = false;
            groupBoxEdificios.Text = "MIS EDIFICIOS";
            // 
            // dataGridEdificios
            // 
            dataGridEdificios.Anchor = AnchorStyles.None;
            dataGridEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEdificios.Location = new Point(7, 27);
            dataGridEdificios.Name = "dataGridEdificios";
            dataGridEdificios.RowHeadersWidth = 51;
            dataGridEdificios.Size = new Size(642, 261);
            dataGridEdificios.TabIndex = 0;
            // 
            // formAsignarGestorA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBoxEdificios);
            Controls.Add(groupBoxEliminar);
            Name = "formAsignarGestorA";
            Text = "formAsignarGestorA";
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxEdificios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEliminar;
        private ComboBox comboBoxGestor;
        private Label label1;
        private Button buttonEliminar;
        private ComboBox comboBoxEdificio;
        private Label label12;
        private GroupBox groupBoxEdificios;
        private DataGridView dataGridEdificios;
    }
}