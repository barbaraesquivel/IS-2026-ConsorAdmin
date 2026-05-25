namespace ConsorAdmin.FORMS_PROOVEDOR
{
    partial class Form1Proovedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Proovedor));
            panelSessionInfo = new Panel();
            pictureBox2 = new PictureBox();
            labelUsername = new Label();
            labelSESION = new Label();
            panelChildForm = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelBienvenida = new Label();
            panelSideMenu = new Panel();
            buttonLogout = new Button();
            buttonModificarPerfil = new Button();
            buttonVerServicios = new Button();
            buttonCargar = new Button();
            buttonInicio = new Button();
            panelSessionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelChildForm.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSideMenu.SuspendLayout();
            SuspendLayout();
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
            labelUsername.Size = new Size(60, 15);
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
            panelChildForm.Controls.Add(groupBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(186, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(698, 636);
            panelChildForm.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(labelBienvenida);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(698, 636);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 397);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelBienvenida
            // 
            labelBienvenida.Anchor = AnchorStyles.None;
            labelBienvenida.AutoSize = true;
            labelBienvenida.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = SystemColors.ControlLight;
            labelBienvenida.Location = new Point(234, 99);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(219, 38);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonLogout);
            panelSideMenu.Controls.Add(buttonModificarPerfil);
            panelSideMenu.Controls.Add(buttonVerServicios);
            panelSideMenu.Controls.Add(buttonCargar);
            panelSideMenu.Controls.Add(buttonInicio);
            panelSideMenu.Controls.Add(panelSessionInfo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(186, 636);
            panelSideMenu.TabIndex = 2;
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
            buttonLogout.Click += buttonLogout_Click;
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
            // buttonVerServicios
            // 
            buttonVerServicios.Dock = DockStyle.Top;
            buttonVerServicios.FlatAppearance.BorderSize = 0;
            buttonVerServicios.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonVerServicios.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonVerServicios.FlatStyle = FlatStyle.Flat;
            buttonVerServicios.ForeColor = SystemColors.ControlLight;
            buttonVerServicios.Location = new Point(0, 204);
            buttonVerServicios.Name = "buttonVerServicios";
            buttonVerServicios.Padding = new Padding(20, 0, 0, 0);
            buttonVerServicios.Size = new Size(186, 40);
            buttonVerServicios.TabIndex = 4;
            buttonVerServicios.Text = "Ver Servicios";
            buttonVerServicios.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerServicios.UseVisualStyleBackColor = true;
            buttonVerServicios.Click += buttonVerServicios_Click;
            // 
            // buttonCargar
            // 
            buttonCargar.Dock = DockStyle.Top;
            buttonCargar.FlatAppearance.BorderSize = 0;
            buttonCargar.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonCargar.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonCargar.FlatStyle = FlatStyle.Flat;
            buttonCargar.ForeColor = SystemColors.ControlLight;
            buttonCargar.Location = new Point(0, 164);
            buttonCargar.Name = "buttonCargar";
            buttonCargar.Padding = new Padding(20, 0, 0, 0);
            buttonCargar.Size = new Size(186, 40);
            buttonCargar.TabIndex = 3;
            buttonCargar.Text = "Cargar Servicio";
            buttonCargar.TextAlign = ContentAlignment.MiddleLeft;
            buttonCargar.UseVisualStyleBackColor = true;
            buttonCargar.Click += buttonCargar_Click;
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
            // Form1Proovedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 636);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Name = "Form1Proovedor";
            Text = "Form1P";
            Load += Form1Proovedor_Load;
            panelSessionInfo.ResumeLayout(false);
            panelSessionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelChildForm.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSideMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSessionInfo;
        private PictureBox pictureBox2;
        private Label labelUsername;
        private Label labelSESION;
        private Panel panelChildForm;
        private Panel panelSideMenu;
        private Button buttonLogout;
        private Button buttonModificarPerfil;
        private Button buttonVerServicios;
        private Button buttonCargar;
        private Button buttonInicio;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelBienvenida;
    }
}