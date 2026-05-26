namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formPermisosA
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
            groupBoxUsuarios = new GroupBox();
            dataGridUsuarios = new DataGridView();
            treeViewPermisos = new TreeView();
            label1 = new Label();
            label9 = new Label();
            textBoxNombre = new TextBox();
            label10 = new Label();
            textBoxCodigo = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            buttonRMUsuario = new Button();
            buttonEliminar = new Button();
            label3 = new Label();
            comboBoxPermisos = new ComboBox();
            groupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsuarios
            // 
            groupBoxUsuarios.Anchor = AnchorStyles.None;
            groupBoxUsuarios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxUsuarios.Controls.Add(dataGridUsuarios);
            groupBoxUsuarios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxUsuarios.ForeColor = SystemColors.ControlLight;
            groupBoxUsuarios.Location = new Point(12, 389);
            groupBoxUsuarios.Name = "groupBoxUsuarios";
            groupBoxUsuarios.Size = new Size(655, 196);
            groupBoxUsuarios.TabIndex = 7;
            groupBoxUsuarios.TabStop = false;
            groupBoxUsuarios.Text = "Permisos";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.Anchor = AnchorStyles.None;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(6, 21);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.Size = new Size(630, 169);
            dataGridUsuarios.TabIndex = 0;
            // 
            // treeViewPermisos
            // 
            treeViewPermisos.Location = new Point(315, 43);
            treeViewPermisos.Name = "treeViewPermisos";
            treeViewPermisos.Size = new Size(321, 159);
            treeViewPermisos.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(315, 25);
            label1.Name = "label1";
            label1.Size = new Size(133, 14);
            label1.TabIndex = 9;
            label1.Text = "Permisos TreeList:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(16, 56);
            label9.Name = "label9";
            label9.Size = new Size(56, 14);
            label9.TabIndex = 33;
            label9.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNombre.ForeColor = SystemColors.ControlLight;
            textBoxNombre.Location = new Point(122, 53);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(177, 22);
            textBoxNombre.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(16, 28);
            label10.Name = "label10";
            label10.Size = new Size(56, 14);
            label10.TabIndex = 31;
            label10.Text = "Codigo:";
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.BackColor = Color.FromArgb(13, 22, 40);
            textBoxCodigo.ForeColor = SystemColors.ControlLight;
            textBoxCodigo.Location = new Point(122, 25);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(177, 22);
            textBoxCodigo.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(comboBoxPermisos);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(buttonEliminar);
            groupBox1.Controls.Add(buttonRMUsuario);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(treeViewPermisos);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(textBoxCodigo);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 335);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permisos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 84);
            label2.Name = "label2";
            label2.Size = new Size(42, 14);
            label2.TabIndex = 34;
            label2.Text = "Tipo:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(122, 83);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(68, 18);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Simple";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(196, 83);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(89, 18);
            checkBox2.TabIndex = 36;
            checkBox2.Text = "Compuesto";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // buttonRMUsuario
            // 
            buttonRMUsuario.Anchor = AnchorStyles.None;
            buttonRMUsuario.BackColor = Color.FromArgb(0, 187, 118);
            buttonRMUsuario.FlatAppearance.BorderSize = 0;
            buttonRMUsuario.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonRMUsuario.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonRMUsuario.FlatStyle = FlatStyle.Flat;
            buttonRMUsuario.ForeColor = SystemColors.ControlLight;
            buttonRMUsuario.Location = new Point(16, 107);
            buttonRMUsuario.Name = "buttonRMUsuario";
            buttonRMUsuario.Size = new Size(283, 28);
            buttonRMUsuario.TabIndex = 41;
            buttonRMUsuario.Text = "Registrar Permiso";
            buttonRMUsuario.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.None;
            buttonEliminar.BackColor = Color.FromArgb(255, 83, 113);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = SystemColors.ControlLight;
            buttonEliminar.Location = new Point(16, 186);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(283, 28);
            buttonEliminar.TabIndex = 42;
            buttonEliminar.Text = "Eliminar Permiso";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(16, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 43;
            label3.Text = "Permiso:";
            // 
            // comboBoxPermisos
            // 
            comboBoxPermisos.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxPermisos.ForeColor = SystemColors.ControlLight;
            comboBoxPermisos.FormattingEnabled = true;
            comboBoxPermisos.Location = new Point(122, 154);
            comboBoxPermisos.Name = "comboBoxPermisos";
            comboBoxPermisos.Size = new Size(177, 22);
            comboBoxPermisos.TabIndex = 44;
            // 
            // formPermisosA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxUsuarios);
            Name = "formPermisosA";
            Text = "formPermisosA";
            groupBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsuarios;
        private DataGridView dataGridUsuarios;
        private TreeView treeViewPermisos;
        private Label label1;
        private Label label9;
        private TextBox textBoxNombre;
        private Label label10;
        private TextBox textBoxCodigo;
        private GroupBox groupBox1;
        private Label label2;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button buttonRMUsuario;
        private Label label3;
        private Button buttonEliminar;
        private ComboBox comboBoxPermisos;
    }
}