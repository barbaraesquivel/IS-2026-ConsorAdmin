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
        /// NOTA: el control de permisos fue cambiado de CheckedListBox a TreeView (tvwPermisos).
        /// En el diseñador visual reemplazar checkListBoxPermisosModificar por un TreeView llamado tvwPermisos.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxUsuarios = new System.Windows.Forms.GroupBox();
            dataGridUsuarios = new System.Windows.Forms.DataGridView();
            groupBoxModificar = new System.Windows.Forms.GroupBox();
            // CAMBIO: se reemplaza checkListBoxPermisosModificar por tvwPermisos (TreeView con CheckBoxes)
            tvwPermisos = new System.Windows.Forms.TreeView();
            label6 = new System.Windows.Forms.Label();
            checkBoxBloqueadoModificar = new System.Windows.Forms.CheckBox();
            label7 = new System.Windows.Forms.Label();
            checkBoxActivoModificar = new System.Windows.Forms.CheckBox();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            textBoxContraseñaModificar = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            textBoxNombreModificar = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            comboBoxUsuarios = new System.Windows.Forms.ComboBox();
            groupBoxEliminar = new System.Windows.Forms.GroupBox();
            comboBoxUsuarioEliminar = new System.Windows.Forms.ComboBox();
            label12 = new System.Windows.Forms.Label();
            buttonLimpiarCampos = new System.Windows.Forms.Button();
            buttonRMUsuario = new System.Windows.Forms.Button();
            buttonEliminar = new System.Windows.Forms.Button();
            groupBoxUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            groupBoxModificar.SuspendLayout();
            groupBoxEliminar.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxUsuarios
            //
            groupBoxUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(17, 30, 53);
            groupBoxUsuarios.Controls.Add(dataGridUsuarios);
            groupBoxUsuarios.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold);
            groupBoxUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            groupBoxUsuarios.Location = new System.Drawing.Point(15, 389);
            groupBoxUsuarios.Name = "groupBoxUsuarios";
            groupBoxUsuarios.Size = new System.Drawing.Size(655, 196);
            groupBoxUsuarios.TabIndex = 6;
            groupBoxUsuarios.TabStop = false;
            groupBoxUsuarios.Text = "USUARIOS";
            //
            // dataGridUsuarios
            //
            dataGridUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new System.Drawing.Point(7, 21);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.Size = new System.Drawing.Size(630, 169);
            dataGridUsuarios.TabIndex = 0;
            //
            // groupBoxModificar
            //
            groupBoxModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBoxModificar.BackColor = System.Drawing.Color.FromArgb(17, 30, 53);
            groupBoxModificar.Controls.Add(buttonLimpiarCampos);
            groupBoxModificar.Controls.Add(comboBoxUsuarios);
            groupBoxModificar.Controls.Add(buttonRMUsuario);
            groupBoxModificar.Controls.Add(label11);
            groupBoxModificar.Controls.Add(tvwPermisos);
            groupBoxModificar.Controls.Add(label6);
            groupBoxModificar.Controls.Add(checkBoxBloqueadoModificar);
            groupBoxModificar.Controls.Add(label7);
            groupBoxModificar.Controls.Add(checkBoxActivoModificar);
            groupBoxModificar.Controls.Add(label8);
            groupBoxModificar.Controls.Add(label9);
            groupBoxModificar.Controls.Add(textBoxContraseñaModificar);
            groupBoxModificar.Controls.Add(label10);
            groupBoxModificar.Controls.Add(textBoxNombreModificar);
            groupBoxModificar.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold);
            groupBoxModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            groupBoxModificar.Location = new System.Drawing.Point(15, 12);
            groupBoxModificar.Name = "groupBoxModificar";
            groupBoxModificar.Size = new System.Drawing.Size(655, 256);
            groupBoxModificar.TabIndex = 36;
            groupBoxModificar.TabStop = false;
            groupBoxModificar.Text = "Registrar / Modificar";
            //
            // tvwPermisos  (reemplaza a checkListBoxPermisosModificar)
            //
            tvwPermisos.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            tvwPermisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            tvwPermisos.CheckBoxes = true;
            tvwPermisos.ForeColor = System.Drawing.SystemColors.ControlLight;
            tvwPermisos.Location = new System.Drawing.Point(397, 21);
            tvwPermisos.Name = "tvwPermisos";
            tvwPermisos.Size = new System.Drawing.Size(240, 157);
            tvwPermisos.TabIndex = 35;
            //
            // label6
            //
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(321, 24);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(70, 14);
            label6.TabIndex = 34;
            label6.Text = "Permisos:";
            //
            // checkBoxBloqueadoModificar
            //
            checkBoxBloqueadoModificar.AutoSize = true;
            checkBoxBloqueadoModificar.Location = new System.Drawing.Point(116, 165);
            checkBoxBloqueadoModificar.Name = "checkBoxBloqueadoModificar";
            checkBoxBloqueadoModificar.Size = new System.Drawing.Size(89, 18);
            checkBoxBloqueadoModificar.TabIndex = 33;
            checkBoxBloqueadoModificar.Text = "Bloqueado";
            checkBoxBloqueadoModificar.UseVisualStyleBackColor = true;
            //
            // label7
            //
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 168);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(77, 14);
            label7.TabIndex = 32;
            label7.Text = "Bloqueado:";
            //
            // checkBoxActivoModificar
            //
            checkBoxActivoModificar.AutoSize = true;
            checkBoxActivoModificar.Location = new System.Drawing.Point(116, 141);
            checkBoxActivoModificar.Name = "checkBoxActivoModificar";
            checkBoxActivoModificar.Size = new System.Drawing.Size(68, 18);
            checkBoxActivoModificar.TabIndex = 31;
            checkBoxActivoModificar.Text = "Activo";
            checkBoxActivoModificar.UseVisualStyleBackColor = true;
            //
            // label8
            //
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(7, 142);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 14);
            label8.TabIndex = 30;
            label8.Text = "Activo:";
            //
            // label9
            //
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(7, 113);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(84, 14);
            label9.TabIndex = 29;
            label9.Text = "Contraseña:";
            //
            // textBoxContraseñaModificar
            //
            textBoxContraseñaModificar.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            textBoxContraseñaModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            textBoxContraseñaModificar.Location = new System.Drawing.Point(129, 110);
            textBoxContraseñaModificar.Name = "textBoxContraseñaModificar";
            textBoxContraseñaModificar.PasswordChar = '*';
            textBoxContraseñaModificar.Size = new System.Drawing.Size(177, 22);
            textBoxContraseñaModificar.TabIndex = 28;
            //
            // label10
            //
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(7, 85);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(56, 14);
            label10.TabIndex = 27;
            label10.Text = "Nombre:";
            //
            // textBoxNombreModificar
            //
            textBoxNombreModificar.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            textBoxNombreModificar.ForeColor = System.Drawing.SystemColors.ControlLight;
            textBoxNombreModificar.Location = new System.Drawing.Point(129, 82);
            textBoxNombreModificar.Name = "textBoxNombreModificar";
            textBoxNombreModificar.Size = new System.Drawing.Size(177, 22);
            textBoxNombreModificar.TabIndex = 26;
            //
            // label11
            //
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(7, 24);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(126, 42);
            label11.TabIndex = 36;
            label11.Text = "Usuario:\r\n(no completar si \r\nquiere registrar)\r\n";
            //
            // comboBoxUsuarios
            //
            comboBoxUsuarios.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            comboBoxUsuarios.ForeColor = System.Drawing.SystemColors.ControlLight;
            comboBoxUsuarios.FormattingEnabled = true;
            comboBoxUsuarios.Location = new System.Drawing.Point(129, 21);
            comboBoxUsuarios.Name = "comboBoxUsuarios";
            comboBoxUsuarios.Size = new System.Drawing.Size(177, 22);
            comboBoxUsuarios.TabIndex = 37;
            //
            // groupBoxEliminar
            //
            groupBoxEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            groupBoxEliminar.BackColor = System.Drawing.Color.FromArgb(17, 30, 53);
            groupBoxEliminar.Controls.Add(buttonEliminar);
            groupBoxEliminar.Controls.Add(comboBoxUsuarioEliminar);
            groupBoxEliminar.Controls.Add(label12);
            groupBoxEliminar.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold);
            groupBoxEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            groupBoxEliminar.Location = new System.Drawing.Point(15, 284);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new System.Drawing.Size(655, 80);
            groupBoxEliminar.TabIndex = 7;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Eliminar";
            //
            // comboBoxUsuarioEliminar
            //
            comboBoxUsuarioEliminar.BackColor = System.Drawing.Color.FromArgb(13, 22, 40);
            comboBoxUsuarioEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            comboBoxUsuarioEliminar.FormattingEnabled = true;
            comboBoxUsuarioEliminar.Location = new System.Drawing.Point(116, 21);
            comboBoxUsuarioEliminar.Name = "comboBoxUsuarioEliminar";
            comboBoxUsuarioEliminar.Size = new System.Drawing.Size(177, 22);
            comboBoxUsuarioEliminar.TabIndex = 39;
            //
            // label12
            //
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(7, 24);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(63, 14);
            label12.TabIndex = 38;
            label12.Text = "Usuario:";
            //
            // buttonLimpiarCampos
            //
            buttonLimpiarCampos.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonLimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            buttonLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 58, 95);
            buttonLimpiarCampos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
            buttonLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            buttonLimpiarCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLimpiarCampos.ForeColor = System.Drawing.SystemColors.ControlLight;
            buttonLimpiarCampos.Location = new System.Drawing.Point(361, 211);
            buttonLimpiarCampos.Name = "buttonLimpiarCampos";
            buttonLimpiarCampos.Size = new System.Drawing.Size(176, 39);
            buttonLimpiarCampos.TabIndex = 41;
            buttonLimpiarCampos.Text = "Limpiar Campos";
            buttonLimpiarCampos.UseVisualStyleBackColor = false;
            //
            // buttonRMUsuario
            //
            buttonRMUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonRMUsuario.BackColor = System.Drawing.Color.FromArgb(0, 187, 118);
            buttonRMUsuario.FlatAppearance.BorderSize = 0;
            buttonRMUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(2, 146, 95);
            buttonRMUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(2, 146, 95);
            buttonRMUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonRMUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            buttonRMUsuario.Location = new System.Drawing.Point(130, 211);
            buttonRMUsuario.Name = "buttonRMUsuario";
            buttonRMUsuario.Size = new System.Drawing.Size(176, 39);
            buttonRMUsuario.TabIndex = 40;
            buttonRMUsuario.Text = "Registrar/Modificar Usuario";
            buttonRMUsuario.UseVisualStyleBackColor = false;
            //
            // buttonEliminar
            //
            buttonEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            buttonEliminar.BackColor = System.Drawing.Color.FromArgb(255, 83, 113);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            buttonEliminar.Location = new System.Drawing.Point(380, 17);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new System.Drawing.Size(177, 26);
            buttonEliminar.TabIndex = 41;
            buttonEliminar.Text = "Eliminar Usuario";
            buttonEliminar.UseVisualStyleBackColor = false;
            //
            // formGestionUsuariosA
            //
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(8, 14, 26);
            ClientSize = new System.Drawing.Size(682, 597);
            Controls.Add(groupBoxEliminar);
            Controls.Add(groupBoxModificar);
            Controls.Add(groupBoxUsuarios);
            Name = "formGestionUsuariosA";
            Text = "Gestión de Usuarios";
            groupBoxUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            groupBoxModificar.ResumeLayout(false);
            groupBoxModificar.PerformLayout();
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsuarios;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.GroupBox groupBoxModificar;
        // CAMBIO: tvwPermisos reemplaza a checkListBoxPermisosModificar
        private System.Windows.Forms.TreeView tvwPermisos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxBloqueadoModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxActivoModificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxContraseñaModificar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNombreModificar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.GroupBox groupBoxEliminar;
        private System.Windows.Forms.ComboBox comboBoxUsuarioEliminar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonLimpiarCampos;
        private System.Windows.Forms.Button buttonRMUsuario;
        private System.Windows.Forms.Button buttonEliminar;
    }
}
