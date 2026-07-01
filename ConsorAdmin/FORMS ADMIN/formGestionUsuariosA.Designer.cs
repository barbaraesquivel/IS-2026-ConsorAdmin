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
            groupBoxUsuarios_FormGestionUsuariosA = new GroupBox();
            dataGridUsuarios = new DataGridView();
            groupBoxModificar_FormGestionUsuariosA = new GroupBox();
            buttonLimpiarCampos_FormGestionUsuariosA = new Button();
            comboBoxUsuarios = new ComboBox();
            buttonRMUsuario_FormGestionUsuariosA = new Button();
            labelUsuario_FormGestionUsuariosA = new Label();
            tvwPermisos = new TreeView();
            labelPermisos_FormGestionUsuariosA = new Label();
            checkBoxBloqueadoModificar_FormGestionUsuariosA = new CheckBox();
            labelBloqueado_FormGestionUsuariosA = new Label();
            checkBoxActivoModificar_FormGestionUsuariosA = new CheckBox();
            labelActivo_FormGestionUsuariosA = new Label();
            labelContraseña_FormGestionUsuariosA = new Label();
            textBoxContraseñaModificar = new TextBox();
            labelNombre_FormGestionUsuariosA = new Label();
            textBoxNombreModificar = new TextBox();
            groupBoxEliminar_FormGestionUsuariosA = new GroupBox();
            buttonEliminar_FormGestionUsuariosA = new Button();
            comboBoxUsuarioEliminar = new ComboBox();
            labelUsuarioEliminar_FormGestionUsuariosA = new Label();
            grpHistorial_FormGestionUsuariosA = new GroupBox();
            dgvHistorial = new DataGridView();
            lblInfoRestaurar_FormGestionUsuariosA = new Label();
            btnRestaurarEstado_FormGestionUsuariosA = new Button();
            groupBoxUsuarios_FormGestionUsuariosA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            groupBoxModificar_FormGestionUsuariosA.SuspendLayout();
            groupBoxEliminar_FormGestionUsuariosA.SuspendLayout();
            grpHistorial_FormGestionUsuariosA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsuarios_FormGestionUsuariosA
            // 
            groupBoxUsuarios_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            groupBoxUsuarios_FormGestionUsuariosA.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxUsuarios_FormGestionUsuariosA.Controls.Add(dataGridUsuarios);
            groupBoxUsuarios_FormGestionUsuariosA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxUsuarios_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            groupBoxUsuarios_FormGestionUsuariosA.Location = new Point(15, 389);
            groupBoxUsuarios_FormGestionUsuariosA.Name = "groupBoxUsuarios_FormGestionUsuariosA";
            groupBoxUsuarios_FormGestionUsuariosA.Size = new Size(655, 196);
            groupBoxUsuarios_FormGestionUsuariosA.TabIndex = 6;
            groupBoxUsuarios_FormGestionUsuariosA.TabStop = false;
            groupBoxUsuarios_FormGestionUsuariosA.Text = "USUARIOS";
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
            // groupBoxModificar_FormGestionUsuariosA
            // 
            groupBoxModificar_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            groupBoxModificar_FormGestionUsuariosA.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(buttonLimpiarCampos_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(comboBoxUsuarios);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(buttonRMUsuario_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelUsuario_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(tvwPermisos);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelPermisos_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(checkBoxBloqueadoModificar_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelBloqueado_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(checkBoxActivoModificar_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelActivo_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelContraseña_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(textBoxContraseñaModificar);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(labelNombre_FormGestionUsuariosA);
            groupBoxModificar_FormGestionUsuariosA.Controls.Add(textBoxNombreModificar);
            groupBoxModificar_FormGestionUsuariosA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxModificar_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            groupBoxModificar_FormGestionUsuariosA.Location = new Point(15, 12);
            groupBoxModificar_FormGestionUsuariosA.Name = "groupBoxModificar_FormGestionUsuariosA";
            groupBoxModificar_FormGestionUsuariosA.Size = new Size(655, 256);
            groupBoxModificar_FormGestionUsuariosA.TabIndex = 36;
            groupBoxModificar_FormGestionUsuariosA.TabStop = false;
            groupBoxModificar_FormGestionUsuariosA.Text = "Registrar / Modificar";
            // 
            // buttonLimpiarCampos_FormGestionUsuariosA
            // 
            buttonLimpiarCampos_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            buttonLimpiarCampos_FormGestionUsuariosA.BackColor = Color.Transparent;
            buttonLimpiarCampos_FormGestionUsuariosA.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonLimpiarCampos_FormGestionUsuariosA.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonLimpiarCampos_FormGestionUsuariosA.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonLimpiarCampos_FormGestionUsuariosA.FlatStyle = FlatStyle.Flat;
            buttonLimpiarCampos_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            buttonLimpiarCampos_FormGestionUsuariosA.Location = new Point(361, 211);
            buttonLimpiarCampos_FormGestionUsuariosA.Name = "buttonLimpiarCampos_FormGestionUsuariosA";
            buttonLimpiarCampos_FormGestionUsuariosA.Size = new Size(176, 39);
            buttonLimpiarCampos_FormGestionUsuariosA.TabIndex = 41;
            buttonLimpiarCampos_FormGestionUsuariosA.Text = "Limpiar Campos";
            buttonLimpiarCampos_FormGestionUsuariosA.UseVisualStyleBackColor = false;
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
            // buttonRMUsuario_FormGestionUsuariosA
            // 
            buttonRMUsuario_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            buttonRMUsuario_FormGestionUsuariosA.BackColor = Color.FromArgb(0, 187, 118);
            buttonRMUsuario_FormGestionUsuariosA.FlatAppearance.BorderSize = 0;
            buttonRMUsuario_FormGestionUsuariosA.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonRMUsuario_FormGestionUsuariosA.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonRMUsuario_FormGestionUsuariosA.FlatStyle = FlatStyle.Flat;
            buttonRMUsuario_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            buttonRMUsuario_FormGestionUsuariosA.Location = new Point(130, 211);
            buttonRMUsuario_FormGestionUsuariosA.Name = "buttonRMUsuario_FormGestionUsuariosA";
            buttonRMUsuario_FormGestionUsuariosA.Size = new Size(176, 39);
            buttonRMUsuario_FormGestionUsuariosA.TabIndex = 40;
            buttonRMUsuario_FormGestionUsuariosA.Text = "Registrar/Modificar Usuario";
            buttonRMUsuario_FormGestionUsuariosA.UseVisualStyleBackColor = false;
            // 
            // labelUsuario_FormGestionUsuariosA
            // 
            labelUsuario_FormGestionUsuariosA.AutoSize = true;
            labelUsuario_FormGestionUsuariosA.Location = new Point(7, 24);
            labelUsuario_FormGestionUsuariosA.Name = "labelUsuario_FormGestionUsuariosA";
            labelUsuario_FormGestionUsuariosA.Size = new Size(126, 42);
            labelUsuario_FormGestionUsuariosA.TabIndex = 36;
            labelUsuario_FormGestionUsuariosA.Text = "Usuario:\r\n(no completar si \r\nquiere registrar)\r\n";
            // 
            // tvwPermisos
            // 
            tvwPermisos.BackColor = Color.FromArgb(13, 22, 40);
            tvwPermisos.BorderStyle = BorderStyle.FixedSingle;
            tvwPermisos.CheckBoxes = true;
            tvwPermisos.ForeColor = SystemColors.ControlLight;
            tvwPermisos.Location = new Point(397, 21);
            tvwPermisos.Name = "tvwPermisos";
            tvwPermisos.Size = new Size(240, 157);
            tvwPermisos.TabIndex = 35;
            // 
            // labelPermisos_FormGestionUsuariosA
            // 
            labelPermisos_FormGestionUsuariosA.AutoSize = true;
            labelPermisos_FormGestionUsuariosA.Location = new Point(321, 24);
            labelPermisos_FormGestionUsuariosA.Name = "labelPermisos_FormGestionUsuariosA";
            labelPermisos_FormGestionUsuariosA.Size = new Size(70, 14);
            labelPermisos_FormGestionUsuariosA.TabIndex = 34;
            labelPermisos_FormGestionUsuariosA.Text = "Permisos:";
            // 
            // checkBoxBloqueadoModificar_FormGestionUsuariosA
            // 
            checkBoxBloqueadoModificar_FormGestionUsuariosA.AutoSize = true;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Location = new Point(116, 165);
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Name = "checkBoxBloqueadoModificar_FormGestionUsuariosA";
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Size = new Size(89, 18);
            checkBoxBloqueadoModificar_FormGestionUsuariosA.TabIndex = 33;
            checkBoxBloqueadoModificar_FormGestionUsuariosA.Text = "Bloqueado";
            checkBoxBloqueadoModificar_FormGestionUsuariosA.UseVisualStyleBackColor = true;
            // 
            // labelBloqueado_FormGestionUsuariosA
            // 
            labelBloqueado_FormGestionUsuariosA.AutoSize = true;
            labelBloqueado_FormGestionUsuariosA.Location = new Point(7, 168);
            labelBloqueado_FormGestionUsuariosA.Name = "labelBloqueado_FormGestionUsuariosA";
            labelBloqueado_FormGestionUsuariosA.Size = new Size(77, 14);
            labelBloqueado_FormGestionUsuariosA.TabIndex = 32;
            labelBloqueado_FormGestionUsuariosA.Text = "Bloqueado:";
            // 
            // checkBoxActivoModificar_FormGestionUsuariosA
            // 
            checkBoxActivoModificar_FormGestionUsuariosA.AutoSize = true;
            checkBoxActivoModificar_FormGestionUsuariosA.Location = new Point(116, 141);
            checkBoxActivoModificar_FormGestionUsuariosA.Name = "checkBoxActivoModificar_FormGestionUsuariosA";
            checkBoxActivoModificar_FormGestionUsuariosA.Size = new Size(68, 18);
            checkBoxActivoModificar_FormGestionUsuariosA.TabIndex = 31;
            checkBoxActivoModificar_FormGestionUsuariosA.Text = "Activo";
            checkBoxActivoModificar_FormGestionUsuariosA.UseVisualStyleBackColor = true;
            // 
            // labelActivo_FormGestionUsuariosA
            // 
            labelActivo_FormGestionUsuariosA.AutoSize = true;
            labelActivo_FormGestionUsuariosA.Location = new Point(7, 142);
            labelActivo_FormGestionUsuariosA.Name = "labelActivo_FormGestionUsuariosA";
            labelActivo_FormGestionUsuariosA.Size = new Size(56, 14);
            labelActivo_FormGestionUsuariosA.TabIndex = 30;
            labelActivo_FormGestionUsuariosA.Text = "Activo:";
            // 
            // labelContraseña_FormGestionUsuariosA
            // 
            labelContraseña_FormGestionUsuariosA.AutoSize = true;
            labelContraseña_FormGestionUsuariosA.Location = new Point(7, 113);
            labelContraseña_FormGestionUsuariosA.Name = "labelContraseña_FormGestionUsuariosA";
            labelContraseña_FormGestionUsuariosA.Size = new Size(84, 14);
            labelContraseña_FormGestionUsuariosA.TabIndex = 29;
            labelContraseña_FormGestionUsuariosA.Text = "Contraseña:";
            // 
            // textBoxContraseñaModificar
            // 
            textBoxContraseñaModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxContraseñaModificar.ForeColor = SystemColors.ControlLight;
            textBoxContraseñaModificar.Location = new Point(129, 110);
            textBoxContraseñaModificar.Name = "textBoxContraseñaModificar";
            textBoxContraseñaModificar.PasswordChar = '*';
            textBoxContraseñaModificar.Size = new Size(177, 22);
            textBoxContraseñaModificar.TabIndex = 28;
            // 
            // labelNombre_FormGestionUsuariosA
            // 
            labelNombre_FormGestionUsuariosA.AutoSize = true;
            labelNombre_FormGestionUsuariosA.Location = new Point(7, 85);
            labelNombre_FormGestionUsuariosA.Name = "labelNombre_FormGestionUsuariosA";
            labelNombre_FormGestionUsuariosA.Size = new Size(56, 14);
            labelNombre_FormGestionUsuariosA.TabIndex = 27;
            labelNombre_FormGestionUsuariosA.Text = "Nombre:";
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
            // groupBoxEliminar_FormGestionUsuariosA
            // 
            groupBoxEliminar_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            groupBoxEliminar_FormGestionUsuariosA.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEliminar_FormGestionUsuariosA.Controls.Add(buttonEliminar_FormGestionUsuariosA);
            groupBoxEliminar_FormGestionUsuariosA.Controls.Add(comboBoxUsuarioEliminar);
            groupBoxEliminar_FormGestionUsuariosA.Controls.Add(labelUsuarioEliminar_FormGestionUsuariosA);
            groupBoxEliminar_FormGestionUsuariosA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEliminar_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            groupBoxEliminar_FormGestionUsuariosA.Location = new Point(15, 284);
            groupBoxEliminar_FormGestionUsuariosA.Name = "groupBoxEliminar_FormGestionUsuariosA";
            groupBoxEliminar_FormGestionUsuariosA.Size = new Size(655, 80);
            groupBoxEliminar_FormGestionUsuariosA.TabIndex = 7;
            groupBoxEliminar_FormGestionUsuariosA.TabStop = false;
            groupBoxEliminar_FormGestionUsuariosA.Text = "Eliminar";
            // 
            // buttonEliminar_FormGestionUsuariosA
            // 
            buttonEliminar_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            buttonEliminar_FormGestionUsuariosA.BackColor = Color.FromArgb(255, 83, 113);
            buttonEliminar_FormGestionUsuariosA.FlatAppearance.BorderSize = 0;
            buttonEliminar_FormGestionUsuariosA.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar_FormGestionUsuariosA.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar_FormGestionUsuariosA.FlatStyle = FlatStyle.Flat;
            buttonEliminar_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            buttonEliminar_FormGestionUsuariosA.Location = new Point(380, 17);
            buttonEliminar_FormGestionUsuariosA.Name = "buttonEliminar_FormGestionUsuariosA";
            buttonEliminar_FormGestionUsuariosA.Size = new Size(177, 26);
            buttonEliminar_FormGestionUsuariosA.TabIndex = 41;
            buttonEliminar_FormGestionUsuariosA.Text = "Eliminar Usuario";
            buttonEliminar_FormGestionUsuariosA.UseVisualStyleBackColor = false;
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
            // labelUsuarioEliminar_FormGestionUsuariosA
            // 
            labelUsuarioEliminar_FormGestionUsuariosA.AutoSize = true;
            labelUsuarioEliminar_FormGestionUsuariosA.Location = new Point(7, 24);
            labelUsuarioEliminar_FormGestionUsuariosA.Name = "labelUsuarioEliminar_FormGestionUsuariosA";
            labelUsuarioEliminar_FormGestionUsuariosA.Size = new Size(63, 14);
            labelUsuarioEliminar_FormGestionUsuariosA.TabIndex = 38;
            labelUsuarioEliminar_FormGestionUsuariosA.Text = "Usuario:";
            //
            // grpHistorial_FormGestionUsuariosA
            //
            grpHistorial_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            grpHistorial_FormGestionUsuariosA.BackColor = Color.FromArgb(17, 30, 53);
            grpHistorial_FormGestionUsuariosA.Controls.Add(dgvHistorial);
            grpHistorial_FormGestionUsuariosA.Controls.Add(lblInfoRestaurar_FormGestionUsuariosA);
            grpHistorial_FormGestionUsuariosA.Controls.Add(btnRestaurarEstado_FormGestionUsuariosA);
            grpHistorial_FormGestionUsuariosA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            grpHistorial_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            grpHistorial_FormGestionUsuariosA.Location = new Point(15, 590);
            grpHistorial_FormGestionUsuariosA.Name = "grpHistorial_FormGestionUsuariosA";
            grpHistorial_FormGestionUsuariosA.Size = new Size(655, 215);
            grpHistorial_FormGestionUsuariosA.TabIndex = 42;
            grpHistorial_FormGestionUsuariosA.TabStop = false;
            grpHistorial_FormGestionUsuariosA.Text = "Historial de cambios del usuario seleccionado";
            //
            // dgvHistorial
            //
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Location = new Point(7, 21);
            dgvHistorial.MultiSelect = false;
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.Size = new Size(440, 180);
            dgvHistorial.TabIndex = 0;
            //
            // lblInfoRestaurar_FormGestionUsuariosA
            //
            lblInfoRestaurar_FormGestionUsuariosA.Location = new Point(455, 21);
            lblInfoRestaurar_FormGestionUsuariosA.Name = "lblInfoRestaurar_FormGestionUsuariosA";
            lblInfoRestaurar_FormGestionUsuariosA.Size = new Size(190, 100);
            lblInfoRestaurar_FormGestionUsuariosA.TabIndex = 1;
            lblInfoRestaurar_FormGestionUsuariosA.Text = "Seleccioná una fila del historial y presioná \"Restaurar estado seleccionado\" para volver a ese estado. La contraseña actual no se modifica.";
            //
            // btnRestaurarEstado_FormGestionUsuariosA
            //
            btnRestaurarEstado_FormGestionUsuariosA.Anchor = AnchorStyles.None;
            btnRestaurarEstado_FormGestionUsuariosA.BackColor = Color.Transparent;
            btnRestaurarEstado_FormGestionUsuariosA.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            btnRestaurarEstado_FormGestionUsuariosA.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            btnRestaurarEstado_FormGestionUsuariosA.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            btnRestaurarEstado_FormGestionUsuariosA.FlatStyle = FlatStyle.Flat;
            btnRestaurarEstado_FormGestionUsuariosA.ForeColor = SystemColors.ControlLight;
            btnRestaurarEstado_FormGestionUsuariosA.Location = new Point(455, 130);
            btnRestaurarEstado_FormGestionUsuariosA.Name = "btnRestaurarEstado_FormGestionUsuariosA";
            btnRestaurarEstado_FormGestionUsuariosA.Size = new Size(190, 40);
            btnRestaurarEstado_FormGestionUsuariosA.TabIndex = 2;
            btnRestaurarEstado_FormGestionUsuariosA.Text = "Restaurar estado seleccionado";
            btnRestaurarEstado_FormGestionUsuariosA.UseVisualStyleBackColor = false;
            //
            // formGestionUsuariosA
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 820);
            Controls.Add(grpHistorial_FormGestionUsuariosA);
            Controls.Add(groupBoxEliminar_FormGestionUsuariosA);
            Controls.Add(groupBoxModificar_FormGestionUsuariosA);
            Controls.Add(groupBoxUsuarios_FormGestionUsuariosA);
            Name = "formGestionUsuariosA";
            Text = "Gestión de Usuarios";
            groupBoxUsuarios_FormGestionUsuariosA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            groupBoxModificar_FormGestionUsuariosA.ResumeLayout(false);
            groupBoxModificar_FormGestionUsuariosA.PerformLayout();
            groupBoxEliminar_FormGestionUsuariosA.ResumeLayout(false);
            groupBoxEliminar_FormGestionUsuariosA.PerformLayout();
            grpHistorial_FormGestionUsuariosA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsuarios_FormGestionUsuariosA;
        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.GroupBox groupBoxModificar_FormGestionUsuariosA;
        // CAMBIO: tvwPermisos reemplaza a checkListBoxPermisosModificar
        private System.Windows.Forms.TreeView tvwPermisos;
        private System.Windows.Forms.Label labelPermisos_FormGestionUsuariosA;
        private System.Windows.Forms.CheckBox checkBoxBloqueadoModificar_FormGestionUsuariosA;
        private System.Windows.Forms.Label labelBloqueado_FormGestionUsuariosA;
        private System.Windows.Forms.CheckBox checkBoxActivoModificar_FormGestionUsuariosA;
        private System.Windows.Forms.Label labelActivo_FormGestionUsuariosA;
        private System.Windows.Forms.Label labelContraseña_FormGestionUsuariosA;
        private System.Windows.Forms.TextBox textBoxContraseñaModificar;
        private System.Windows.Forms.Label labelNombre_FormGestionUsuariosA;
        private System.Windows.Forms.TextBox textBoxNombreModificar;
        private System.Windows.Forms.Label labelUsuario_FormGestionUsuariosA;
        private System.Windows.Forms.ComboBox comboBoxUsuarios;
        private System.Windows.Forms.GroupBox groupBoxEliminar_FormGestionUsuariosA;
        private System.Windows.Forms.ComboBox comboBoxUsuarioEliminar;
        private System.Windows.Forms.Label labelUsuarioEliminar_FormGestionUsuariosA;
        private System.Windows.Forms.Button buttonLimpiarCampos_FormGestionUsuariosA;
        private System.Windows.Forms.Button buttonRMUsuario_FormGestionUsuariosA;
        private System.Windows.Forms.Button buttonEliminar_FormGestionUsuariosA;
        private System.Windows.Forms.GroupBox grpHistorial_FormGestionUsuariosA;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblInfoRestaurar_FormGestionUsuariosA;
        private System.Windows.Forms.Button btnRestaurarEstado_FormGestionUsuariosA;
    }
}
