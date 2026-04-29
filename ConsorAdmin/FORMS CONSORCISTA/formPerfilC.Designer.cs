namespace ConsorAdmin
{
    partial class formPerfilC
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
            buttonGuardar = new Button();
            buttonImprimir = new Button();
            groupBoxExpensas = new GroupBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label2 = new Label();
            textBoxDni = new TextBox();
            label3 = new Label();
            label4 = new Label();
            dateTimeNacimiento = new DateTimePicker();
            textBoxDireccion = new TextBox();
            label5 = new Label();
            textBoxTelefono = new TextBox();
            label6 = new Label();
            textBoxEmail = new TextBox();
            label7 = new Label();
            textBoxConfirmarPW = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxLocalidad = new TextBox();
            textBoxNewPW = new TextBox();
            label10 = new Label();
            buttonCancelar = new Button();
            buttonGuard = new Button();
            groupBox2.SuspendLayout();
            groupBoxExpensas.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(buttonGuardar);
            groupBox2.Controls.Add(buttonImprimir);
            groupBox2.Controls.Add(groupBoxExpensas);
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(8, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(667, 507);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.BackColor = Color.Transparent;
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonGuardar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonGuardar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = SystemColors.ControlLight;
            buttonGuardar.Location = new Point(501, 564);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(202, 36);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar en PDF";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Anchor = AnchorStyles.None;
            buttonImprimir.BackColor = Color.FromArgb(39, 133, 243);
            buttonImprimir.FlatAppearance.BorderSize = 0;
            buttonImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir.FlatStyle = FlatStyle.Flat;
            buttonImprimir.ForeColor = SystemColors.ControlLight;
            buttonImprimir.Location = new Point(269, 564);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(202, 36);
            buttonImprimir.TabIndex = 14;
            buttonImprimir.Text = "Imprimir Expensa Seleccionada(s)";
            buttonImprimir.UseVisualStyleBackColor = false;
            // 
            // groupBoxExpensas
            // 
            groupBoxExpensas.Anchor = AnchorStyles.None;
            groupBoxExpensas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxExpensas.Controls.Add(dateTimeNacimiento);
            groupBoxExpensas.Controls.Add(label4);
            groupBoxExpensas.Controls.Add(textBoxDni);
            groupBoxExpensas.Controls.Add(label3);
            groupBoxExpensas.Controls.Add(textBoxApellido);
            groupBoxExpensas.Controls.Add(label2);
            groupBoxExpensas.Controls.Add(textBoxNombre);
            groupBoxExpensas.Controls.Add(label1);
            groupBoxExpensas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxExpensas.ForeColor = SystemColors.ControlLight;
            groupBoxExpensas.Location = new Point(17, 18);
            groupBoxExpensas.Name = "groupBoxExpensas";
            groupBoxExpensas.Size = new Size(307, 466);
            groupBoxExpensas.TabIndex = 5;
            groupBoxExpensas.TabStop = false;
            groupBoxExpensas.Text = "DATOS PERSONALES";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(buttonGuard);
            groupBox1.Controls.Add(buttonCancelar);
            groupBox1.Controls.Add(textBoxConfirmarPW);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBoxLocalidad);
            groupBox1.Controls.Add(textBoxNewPW);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxDireccion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(textBoxTelefono);
            groupBox1.Controls.Add(label6);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(342, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 466);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DE CONTACTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 31);
            label1.Name = "label1";
            label1.Size = new Size(70, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombre(s)";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNombre.ForeColor = SystemColors.ControlLight;
            textBoxNombre.Location = new Point(19, 48);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(221, 22);
            textBoxNombre.TabIndex = 13;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.FromArgb(13, 22, 40);
            textBoxApellido.ForeColor = SystemColors.ControlLight;
            textBoxApellido.Location = new Point(19, 108);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(221, 22);
            textBoxApellido.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 91);
            label2.Name = "label2";
            label2.Size = new Size(84, 14);
            label2.TabIndex = 14;
            label2.Text = "Apellido(s)";
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = Color.FromArgb(13, 22, 40);
            textBoxDni.ForeColor = SystemColors.ControlLight;
            textBoxDni.Location = new Point(19, 171);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(221, 22);
            textBoxDni.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 154);
            label3.Name = "label3";
            label3.Size = new Size(91, 14);
            label3.TabIndex = 16;
            label3.Text = "D.N.I / CUIT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 219);
            label4.Name = "label4";
            label4.Size = new Size(140, 14);
            label4.TabIndex = 18;
            label4.Text = "FECHA DE NACIMIENTO";
            // 
            // dateTimeNacimiento
            // 
            dateTimeNacimiento.CalendarForeColor = SystemColors.ControlLight;
            dateTimeNacimiento.Location = new Point(19, 236);
            dateTimeNacimiento.Name = "dateTimeNacimiento";
            dateTimeNacimiento.Size = new Size(200, 22);
            dateTimeNacimiento.TabIndex = 19;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.BackColor = Color.FromArgb(13, 22, 40);
            textBoxDireccion.ForeColor = SystemColors.ControlLight;
            textBoxDireccion.Location = new Point(21, 171);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(221, 22);
            textBoxDireccion.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 154);
            label5.Name = "label5";
            label5.Size = new Size(70, 14);
            label5.TabIndex = 24;
            label5.Text = "DIRECCIÓN";
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BackColor = Color.FromArgb(13, 22, 40);
            textBoxTelefono.ForeColor = SystemColors.ControlLight;
            textBoxTelefono.Location = new Point(21, 108);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(221, 22);
            textBoxTelefono.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 91);
            label6.Name = "label6";
            label6.Size = new Size(63, 14);
            label6.TabIndex = 22;
            label6.Text = "TELÉFONO";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(13, 22, 40);
            textBoxEmail.ForeColor = SystemColors.ControlLight;
            textBoxEmail.Location = new Point(21, 48);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(221, 22);
            textBoxEmail.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 31);
            label7.Name = "label7";
            label7.Size = new Size(42, 14);
            label7.TabIndex = 20;
            label7.Text = "EMAIL";
            // 
            // textBoxConfirmarPW
            // 
            textBoxConfirmarPW.BackColor = Color.FromArgb(13, 22, 40);
            textBoxConfirmarPW.ForeColor = SystemColors.ControlLight;
            textBoxConfirmarPW.Location = new Point(21, 359);
            textBoxConfirmarPW.Name = "textBoxConfirmarPW";
            textBoxConfirmarPW.Size = new Size(221, 22);
            textBoxConfirmarPW.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 219);
            label8.Name = "label8";
            label8.Size = new Size(70, 14);
            label8.TabIndex = 26;
            label8.Text = "LOCALIDAD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 342);
            label9.Name = "label9";
            label9.Size = new Size(147, 14);
            label9.TabIndex = 30;
            label9.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // textBoxLocalidad
            // 
            textBoxLocalidad.BackColor = Color.FromArgb(13, 22, 40);
            textBoxLocalidad.ForeColor = SystemColors.ControlLight;
            textBoxLocalidad.Location = new Point(21, 236);
            textBoxLocalidad.Name = "textBoxLocalidad";
            textBoxLocalidad.Size = new Size(221, 22);
            textBoxLocalidad.TabIndex = 27;
            // 
            // textBoxNewPW
            // 
            textBoxNewPW.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNewPW.ForeColor = SystemColors.ControlLight;
            textBoxNewPW.Location = new Point(21, 296);
            textBoxNewPW.Name = "textBoxNewPW";
            textBoxNewPW.Size = new Size(221, 22);
            textBoxNewPW.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 279);
            label10.Name = "label10";
            label10.Size = new Size(119, 14);
            label10.TabIndex = 28;
            label10.Text = "NUEVA CONTRASEÑA";
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
            buttonCancelar.Location = new Point(152, 409);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(90, 36);
            buttonCancelar.TabIndex = 32;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
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
            buttonGuard.Location = new Point(21, 409);
            buttonGuard.Name = "buttonGuard";
            buttonGuard.Size = new Size(90, 36);
            buttonGuard.TabIndex = 33;
            buttonGuard.Text = "Guardar";
            buttonGuard.UseVisualStyleBackColor = false;
            // 
            // formPerfilC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formPerfilC";
            Text = "formPerfilC";
            groupBox2.ResumeLayout(false);
            groupBoxExpensas.ResumeLayout(false);
            groupBoxExpensas.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonGuardar;
        private Button buttonImprimir;
        private GroupBox groupBoxExpensas;
        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dateTimeNacimiento;
        private Label label4;
        private TextBox textBoxDni;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label2;
        private TextBox textBoxNombre;
        private TextBox textBoxConfirmarPW;
        private Label label8;
        private Label label9;
        private TextBox textBoxLocalidad;
        private TextBox textBoxNewPW;
        private Label label10;
        private TextBox textBoxDireccion;
        private Label label7;
        private Label label5;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefono;
        private Label label6;
        private Button buttonCancelar;
        private Button buttonGuard;
    }
}