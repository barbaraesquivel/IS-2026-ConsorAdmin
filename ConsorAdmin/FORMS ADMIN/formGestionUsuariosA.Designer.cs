namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formGestionUsuariosA
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
            groupBoxModificar = new GroupBox();
            checkListBoxPermisosModificar = new CheckedListBox();
            label6 = new Label();
            checkBoxBloqueadoModificar = new CheckBox();
            label7 = new Label();
            checkBoxActivoModificar = new CheckBox();
            label8 = new Label();
            label9 = new Label();
            textBoxContraseñaModificar = new TextBox();
            label10 = new Label();
            textBoxNombreModificar = new TextBox();
            label11 = new Label();
            comboBoxUsuarios = new ComboBox();
            groupBoxEliminar = new GroupBox();
            comboBoxUsuarioEliminar = new ComboBox();
            label12 = new Label();
            buttonLimpiarCampos = new Button();
            buttonRMUsuario = new Button();
            buttonEliminar = new Button();
            groupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            groupBoxModificar.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUsuarios
            // 
            groupBoxUsuarios.Anchor = AnchorStyles.None;
            groupBoxUsuarios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxUsuarios.Controls.Add(dataGridUsuarios);
            groupBoxUsuarios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxUsuarios.ForeColor = SystemColors.ControlLight;
            groupBoxUsuarios.Location = new Point(15, 389);
            groupBoxUsuarios.Name = "groupBoxUsuarios";
            groupBoxUsuarios.Size = new Size(655, 196);
            groupBoxUsuarios.TabIndex = 6;
            groupBoxUsuarios.TabStop = false;
            groupBoxUsuarios.Text = "USUARIOS";
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.Anchor = AnchorStyles.None;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(7, 21);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.Size = new Size(630, 169);
            dataGridUsuarios.TabIndex = 0;
            // 
            // groupBoxModificar
            // 
            groupBoxModificar.Anchor = AnchorStyles.None;
            groupBoxModificar.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxModificar.Controls.Add(buttonLimpiarCampos);
            groupBoxModificar.Controls.Add(comboBoxUsuarios);
            groupBoxModificar.Controls.Add(buttonRMUsuario);
            groupBoxModificar.Controls.Add(label11);
            groupBoxModificar.Controls.Add(checkListBoxPermisosModificar);
            groupBoxModificar.Controls.Add(label6);
            groupBoxModificar.Controls.Add(checkBoxBloqueadoModificar);
            groupBoxModificar.Controls.Add(label7);
            groupBoxModificar.Controls.Add(checkBoxActivoModificar);
            groupBoxModificar.Controls.Add(label8);
            groupBoxModificar.Controls.Add(label9);
            groupBoxModificar.Controls.Add(textBoxContraseñaModificar);
            groupBoxModificar.Controls.Add(label10);
            groupBoxModificar.Controls.Add(textBoxNombreModificar);
            groupBoxModificar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxModificar.ForeColor = SystemColors.ControlLight;
            groupBoxModificar.Location = new Point(15, 12);
            groupBoxModificar.Name = "groupBoxModificar";
            groupBoxModificar.Size = new Size(655, 256);
            groupBoxModificar.TabIndex = 36;
            groupBoxModificar.TabStop = false;
            groupBoxModificar.Text = "Registrar / Modificar";
            // 
            // checkListBoxPermisosModificar
            // 
            checkListBoxPermisosModificar.FormattingEnabled = true;
            checkListBoxPermisosModificar.Location = new Point(397, 21);
            checkListBoxPermisosModificar.Name = "checkListBoxPermisosModificar";
            checkListBoxPermisosModificar.Size = new Size(240, 157);
            checkListBoxPermisosModificar.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(321, 24);
            label6.Name = "label6";
            label6.Size = new Size(70, 14);
            label6.TabIndex = 34;
            label6.Text = "Permisos:";
            // 
            // checkBoxBloqueadoModificar
            // 
            checkBoxBloqueadoModificar.AutoSize = true;
            checkBoxBloqueadoModificar.Location = new Point(116, 165);
            checkBoxBloqueadoModificar.Name = "checkBoxBloqueadoModificar";
            checkBoxBloqueadoModificar.Size = new Size(89, 18);
            checkBoxBloqueadoModificar.TabIndex = 33;
            checkBoxBloqueadoModificar.Text = "Bloqueado";
            checkBoxBloqueadoModificar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 168);
            label7.Name = "label7";
            label7.Size = new Size(77, 14);
            label7.TabIndex = 32;
            label7.Text = "Bloqueado:";
            // 
            // checkBoxActivoModificar
            // 
            checkBoxActivoModificar.AutoSize = true;
            checkBoxActivoModificar.Location = new Point(116, 141);
            checkBoxActivoModificar.Name = "checkBoxActivoModificar";
            checkBoxActivoModificar.Size = new Size(68, 18);
            checkBoxActivoModificar.TabIndex = 31;
            checkBoxActivoModificar.Text = "Activo";
            checkBoxActivoModificar.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 142);
            label8.Name = "label8";
            label8.Size = new Size(56, 14);
            label8.TabIndex = 30;
            label8.Text = "Activo:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 113);
            label9.Name = "label9";
            label9.Size = new Size(84, 14);
            label9.TabIndex = 29;
            label9.Text = "Contraseña:";
            // 
            // textBoxContraseñaModificar
            // 
            textBoxContraseñaModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxContraseñaModificar.ForeColor = SystemColors.ControlLight;
            textBoxContraseñaModificar.Location = new Point(129, 110);
            textBoxContraseñaModificar.Name = "textBoxContraseñaModificar";
            textBoxContraseñaModificar.Size = new Size(177, 22);
            textBoxContraseñaModificar.TabIndex = 28;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 85);
            label10.Name = "label10";
            label10.Size = new Size(56, 14);
            label10.TabIndex = 27;
            label10.Text = "Nombre:";
            // 
            // textBoxNombreModificar
            // 
            textBoxNombreModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNombreModificar.ForeColor = SystemColors.ControlLight;
            textBoxNombreModificar.Location = new Point(129, 82);
            textBoxNombreModificar.Name = "textBoxNombreModificar";
            textBoxNombreModificar.Size = new Size(177, 22);
            textBoxNombreModificar.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(7, 24);
            label11.Name = "label11";
            label11.Size = new Size(126, 42);
            label11.TabIndex = 36;
            label11.Text = "Usuario:\r\n(no completar si \r\nquiere registrar)\r\n";
            // 
            // comboBoxUsuarios
            // 
            comboBoxUsuarios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxUsuarios.ForeColor = SystemColors.ControlLight;
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new Point(129, 21);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new Size(177, 22);
            comboBoxUsuarios.TabIndex = 37;
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Anchor = AnchorStyles.None;
            groupBoxEliminar.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEliminar.Controls.Add(buttonEliminar);
            groupBoxEliminar.Controls.Add(comboBoxUsuarioEliminar);
            groupBoxEliminar.Controls.Add(label12);
            groupBoxEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEliminar.ForeColor = SystemColors.ControlLight;
            groupBoxEliminar.Location = new Point(15, 284);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(655, 80);
            groupBoxEliminar.TabIndex = 7;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Eliminar";
            // 
            // comboBoxUsuarioEliminar
            // 
            comboBoxUsuarioEliminar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxUsuarioEliminar.ForeColor = SystemColors.ControlLight;
            comboBoxUsuarioEliminar.FormattingEnabled = true;
            comboBoxUsuarioEliminar.Location = new Point(116, 21);
            comboBoxUsuarioEliminar.Name = "comboBoxUsuarioEliminar";
            comboBoxUsuarioEliminar.Size = new Size(177, 22);
            comboBoxUsuarioEliminar.TabIndex = 39;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 24);
            label12.Name = "label12";
            label12.Size = new Size(63, 14);
            label12.TabIndex = 38;
            label12.Text = "Usuario:";
            // 
            // buttonLimpiarCampos
            // 
            buttonLimpiarCampos.Anchor = AnchorStyles.None;
            buttonLimpiarCampos.BackColor = Color.Transparent;
            buttonLimpiarCampos.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonLimpiarCampos.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonLimpiarCampos.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonLimpiarCampos.FlatStyle = FlatStyle.Flat;
            buttonLimpiarCampos.ForeColor = SystemColors.ControlLight;
            buttonLimpiarCampos.Location = new Point(361, 211);
            buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            buttonLimpiarCampos.Size = new Size(176, 39);
            buttonLimpiarCampos.TabIndex = 41;
            buttonLimpiarCampos.Text = "Limpiar Campos";
            buttonLimpiarCampos.UseVisualStyleBackColor = false;
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
            buttonRMUsuario.Location = new Point(130, 211);
            buttonRMUsuario.Name = "buttonRMUsuario";
            buttonRMUsuario.Size = new Size(176, 39);
            buttonRMUsuario.TabIndex = 40;
            buttonRMUsuario.Text = "Registrar/Modificar Usuario";
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
            buttonEliminar.Location = new Point(380, 17);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(177, 26);
            buttonEliminar.TabIndex = 41;
            buttonEliminar.Text = "Eliminar Usuario";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // formGestionUsuariosA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxModificar);
            Controls.Add(groupBoxUsuarios);
            Name = "formGestionUsuariosA";
            Text = "formGestionUsuariosA";
            groupBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            groupBoxModificar.ResumeLayout(false);
            groupBoxModificar.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsuarios;
        private DataGridView dataGridUsuarios;
        private GroupBox groupBoxModificar;
        private CheckedListBox checkListBoxPermisosModificar;
        private Label label6;
        private CheckBox checkBoxBloqueadoModificar;
        private Label label7;
        private CheckBox checkBoxActivoModificar;
        private Label label8;
        private Label label9;
        private TextBox textBoxContraseñaModificar;
        private Label label10;
        private TextBox textBoxNombreModificar;
        private Label label11;
        private ComboBox comboBoxUsuarios;
        private GroupBox groupBoxEliminar;
        private ComboBox comboBoxUsuarioEliminar;
        private Label label12;
        private Button buttonLimpiarCampos;
        private Button buttonRMUsuario;
        private Button buttonEliminar;
    }
}