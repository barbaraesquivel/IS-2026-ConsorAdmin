

namespace ConsorAdmin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSideMenu = new Panel();
            buttonLogout = new Button();
            buttonModificarPerfil = new Button();
            buttonVerExpensas = new Button();
            buttonPagarExpensas = new Button();
            buttonInicio = new Button();
            panelSessionInfo = new Panel();
            pictureBox2 = new PictureBox();
            labelUsername = new Label();
            labelSESION = new Label();
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            labelBienvenida = new Label();
            panelSideMenu.SuspendLayout();
            panelSessionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonLogout);
            panelSideMenu.Controls.Add(buttonModificarPerfil);
            panelSideMenu.Controls.Add(buttonVerExpensas);
            panelSideMenu.Controls.Add(buttonPagarExpensas);
            panelSideMenu.Controls.Add(buttonInicio);
            panelSideMenu.Controls.Add(panelSessionInfo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(186, 636);
            panelSideMenu.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = Color.FromArgb(220, 58, 89);
            buttonLogout.Location = new Point(0, 596);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(20, 0, 0, 0);
            buttonLogout.Size = new Size(186, 40);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "Cerrar Sesión";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonModificarPerfil
            // 
            buttonModificarPerfil.Dock = DockStyle.Top;
            buttonModificarPerfil.FlatAppearance.BorderSize = 0;
            buttonModificarPerfil.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonModificarPerfil.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonModificarPerfil.FlatStyle = FlatStyle.Flat;
            buttonModificarPerfil.ForeColor = SystemColors.ControlLight;
            buttonModificarPerfil.Location = new Point(0, 244);
            buttonModificarPerfil.Name = "buttonModificarPerfil";
            buttonModificarPerfil.Padding = new Padding(20, 0, 0, 0);
            buttonModificarPerfil.Size = new Size(186, 40);
            buttonModificarPerfil.TabIndex = 5;
            buttonModificarPerfil.Text = "Modificar Perfil";
            buttonModificarPerfil.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificarPerfil.UseVisualStyleBackColor = true;
            buttonModificarPerfil.Click += buttonModificarPerfil_Click;
            // 
            // buttonVerExpensas
            // 
            buttonVerExpensas.Dock = DockStyle.Top;
            buttonVerExpensas.FlatAppearance.BorderSize = 0;
            buttonVerExpensas.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonVerExpensas.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonVerExpensas.FlatStyle = FlatStyle.Flat;
            buttonVerExpensas.ForeColor = SystemColors.ControlLight;
            buttonVerExpensas.Location = new Point(0, 204);
            buttonVerExpensas.Name = "buttonVerExpensas";
            buttonVerExpensas.Padding = new Padding(20, 0, 0, 0);
            buttonVerExpensas.Size = new Size(186, 40);
            buttonVerExpensas.TabIndex = 4;
            buttonVerExpensas.Text = "Ver Expensas";
            buttonVerExpensas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerExpensas.UseVisualStyleBackColor = true;
            buttonVerExpensas.Click += buttonVerExpensas_Click;
            // 
            // buttonPagarExpensas
            // 
            buttonPagarExpensas.Dock = DockStyle.Top;
            buttonPagarExpensas.FlatAppearance.BorderSize = 0;
            buttonPagarExpensas.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonPagarExpensas.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonPagarExpensas.FlatStyle = FlatStyle.Flat;
            buttonPagarExpensas.ForeColor = SystemColors.ControlLight;
            buttonPagarExpensas.Location = new Point(0, 164);
            buttonPagarExpensas.Name = "buttonPagarExpensas";
            buttonPagarExpensas.Padding = new Padding(20, 0, 0, 0);
            buttonPagarExpensas.Size = new Size(186, 40);
            buttonPagarExpensas.TabIndex = 3;
            buttonPagarExpensas.Text = "Pagar Expensas";
            buttonPagarExpensas.TextAlign = ContentAlignment.MiddleLeft;
            buttonPagarExpensas.UseVisualStyleBackColor = true;
            buttonPagarExpensas.Click += buttonPagarExpensas_Click;
            // 
            // buttonInicio
            // 
            buttonInicio.Dock = DockStyle.Top;
            buttonInicio.FlatAppearance.BorderSize = 0;
            buttonInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio.FlatStyle = FlatStyle.Flat;
            buttonInicio.ForeColor = SystemColors.ControlLight;
            buttonInicio.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio.Location = new Point(0, 124);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Padding = new Padding(20, 0, 0, 0);
            buttonInicio.Size = new Size(186, 40);
            buttonInicio.TabIndex = 2;
            buttonInicio.Text = "Inicio";
            buttonInicio.TextAlign = ContentAlignment.MiddleLeft;
            buttonInicio.UseVisualStyleBackColor = true;
            buttonInicio.Click += buttonInicio_Click;
            // 
            // panelSessionInfo
            // 
            panelSessionInfo.Controls.Add(pictureBox2);
            panelSessionInfo.Controls.Add(labelUsername);
            panelSessionInfo.Controls.Add(labelSESION);
            panelSessionInfo.Dock = DockStyle.Top;
            panelSessionInfo.Location = new Point(0, 0);
            panelSessionInfo.Name = "panelSessionInfo";
            panelSessionInfo.Size = new Size(186, 124);
            panelSessionInfo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.ForeColor = SystemColors.ControlLight;
            labelUsername.Location = new Point(12, 93);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(71, 19);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username";
            // 
            // labelSESION
            // 
            labelSESION.AutoSize = true;
            labelSESION.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSESION.ForeColor = SystemColors.ControlLight;
            labelSESION.Location = new Point(12, 79);
            labelSESION.Name = "labelSESION";
            labelSESION.Size = new Size(111, 15);
            labelSESION.TabIndex = 0;
            labelSESION.Text = "SESION ACTIVA";
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(8, 14, 26);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Controls.Add(labelBienvenida);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(186, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(698, 636);
            panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelBienvenida
            // 
            labelBienvenida.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = SystemColors.ControlLight;
            labelBienvenida.Location = new Point(241, 83);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(219, 38);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(884, 636);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(900, 675);
            Name = "Form1";
            Text = "Form1";
            panelSideMenu.ResumeLayout(false);
            panelSessionInfo.ResumeLayout(false);
            panelSessionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private Panel panelSideMenu;
        private Panel panelSessionInfo;
        private Button buttonInicio;
        private Button buttonPagarExpensas;
        private Button buttonModificarPerfil;
        private Button buttonVerExpensas;
        private Button buttonLogout;
        private Panel panelChildForm;
        private Label labelBienvenida;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelUsername;
        private Label labelSESION;
    }
}
