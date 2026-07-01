namespace ConsorAdmin
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            txtUser = new TextBox();
            txtContraseña = new TextBox();
            labelUsuario_FormLogin = new Label();
            labelContraseña_FormLogin = new Label();
            btnIniciaSesion_FormLogin = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            cboIdiomaPreLogin = new ComboBox();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(88, 41);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(238, 23);
            txtUser.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(88, 93);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(238, 23);
            txtContraseña.TabIndex = 1;
            // 
            // labelUsuario_FormLogin
            // 
            labelUsuario_FormLogin.AutoSize = true;
            labelUsuario_FormLogin.Location = new Point(12, 44);
            labelUsuario_FormLogin.Name = "labelUsuario_FormLogin";
            labelUsuario_FormLogin.Size = new Size(50, 15);
            labelUsuario_FormLogin.TabIndex = 2;
            labelUsuario_FormLogin.Text = "Usuario:";
            // 
            // labelContraseña_FormLogin
            // 
            labelContraseña_FormLogin.AutoSize = true;
            labelContraseña_FormLogin.Location = new Point(12, 96);
            labelContraseña_FormLogin.Name = "labelContraseña_FormLogin";
            labelContraseña_FormLogin.Size = new Size(70, 15);
            labelContraseña_FormLogin.TabIndex = 3;
            labelContraseña_FormLogin.Text = "Contraseña:";
            // 
            // btnIniciaSesion_FormLogin
            // 
            btnIniciaSesion_FormLogin.Location = new Point(217, 133);
            btnIniciaSesion_FormLogin.Name = "btnIniciaSesion_FormLogin";
            btnIniciaSesion_FormLogin.Size = new Size(109, 23);
            btnIniciaSesion_FormLogin.TabIndex = 4;
            btnIniciaSesion_FormLogin.Text = "Iniciar Sesión";
            btnIniciaSesion_FormLogin.UseVisualStyleBackColor = true;
            btnIniciaSesion_FormLogin.Click += btnIniciaSesion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.InfoText;
            label3.Location = new Point(12, 150);
            label3.Name = "label3";
            label3.Size = new Size(125, 30);
            label3.TabIndex = 5;
            label3.Text = "Usuario: admin\r\nContraseña: admin123";
            //
            // cboIdiomaPreLogin
            //
            cboIdiomaPreLogin.FormattingEnabled = true;
            cboIdiomaPreLogin.Location = new Point(207, 10);
            cboIdiomaPreLogin.Name = "cboIdiomaPreLogin";
            cboIdiomaPreLogin.Size = new Size(131, 23);
            cboIdiomaPreLogin.TabIndex = 6;
            cboIdiomaPreLogin.SelectedIndexChanged += cboIdiomaPreLogin_SelectedIndexChanged;
            //
            // Login
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(350, 204);
            Controls.Add(cboIdiomaPreLogin);
            Controls.Add(label3);
            Controls.Add(btnIniciaSesion_FormLogin);
            Controls.Add(labelContraseña_FormLogin);
            Controls.Add(labelUsuario_FormLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUser);
            Name = "Login";
            Text = "Inicio de Sesión";
            FormClosing += Login_FormClosing;
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtContraseña;
        private Label labelUsuario_FormLogin;
        private Label labelContraseña_FormLogin;
        private Button btnIniciaSesion_FormLogin;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private ComboBox cboIdiomaPreLogin;
    }
}