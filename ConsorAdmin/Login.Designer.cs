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
            label1 = new Label();
            label2 = new Label();
            btnIniciaSesion = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnIniciaSesion
            // 
            btnIniciaSesion.Location = new Point(217, 133);
            btnIniciaSesion.Name = "btnIniciaSesion";
            btnIniciaSesion.Size = new Size(109, 23);
            btnIniciaSesion.TabIndex = 4;
            btnIniciaSesion.Text = "Iniciar Sesión";
            btnIniciaSesion.UseVisualStyleBackColor = true;
            btnIniciaSesion.Click += btnIniciaSesion_Click;
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
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(350, 204);
            Controls.Add(label3);
            Controls.Add(btnIniciaSesion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtUser);
            Name = "Login";
            Text = "Inicio de Sesión";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Button btnIniciaSesion;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}