namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelSessionInfo = new Panel();
            pictureBox2 = new PictureBox();
            labelUsername = new Label();
            labelSESION = new Label();
            buttonModificarPerfil = new Button();
            buttonVerExpensas = new Button();
            buttonPagarExpensas = new Button();
            buttonInicio = new Button();
            panelSideMenu = new Panel();
            buttonLogout = new Button();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelBienvenida = new Label();
            buttonRecaudacion = new Button();
            panelSessionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSideMenu.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            buttonModificarPerfil.Text = "Historial";
            buttonModificarPerfil.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificarPerfil.UseVisualStyleBackColor = true;
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
            buttonVerExpensas.Text = "Mis Edificios";
            buttonVerExpensas.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerExpensas.UseVisualStyleBackColor = true;
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
            buttonPagarExpensas.Text = "Cargar Expensas";
            buttonPagarExpensas.TextAlign = ContentAlignment.MiddleLeft;
            buttonPagarExpensas.UseVisualStyleBackColor = true;
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
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonRecaudacion);
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
            panelSideMenu.TabIndex = 3;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(labelBienvenida);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(884, 636);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 134);
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
            labelBienvenida.Location = new Point(433, 93);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(219, 38);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRecaudacion
            // 
            buttonRecaudacion.Dock = DockStyle.Top;
            buttonRecaudacion.FlatAppearance.BorderSize = 0;
            buttonRecaudacion.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonRecaudacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonRecaudacion.FlatStyle = FlatStyle.Flat;
            buttonRecaudacion.ForeColor = SystemColors.ControlLight;
            buttonRecaudacion.Location = new Point(0, 284);
            buttonRecaudacion.Name = "buttonRecaudacion";
            buttonRecaudacion.Padding = new Padding(20, 0, 0, 0);
            buttonRecaudacion.Size = new Size(186, 40);
            buttonRecaudacion.TabIndex = 7;
            buttonRecaudacion.Text = "Recaudación";
            buttonRecaudacion.TextAlign = ContentAlignment.MiddleLeft;
            buttonRecaudacion.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(884, 636);
            Controls.Add(panelSideMenu);
            Controls.Add(groupBox1);
            MinimumSize = new Size(900, 675);
            Name = "Form1";
            Text = "Form1";
            panelSessionInfo.ResumeLayout(false);
            panelSessionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSideMenu.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSessionInfo;
        private PictureBox pictureBox2;
        private Label labelUsername;
        private Label labelSESION;
        private Button buttonModificarPerfil;
        private Button buttonVerExpensas;
        private Button buttonPagarExpensas;
        private Button buttonInicio;
        private Panel panelSideMenu;
        private Button buttonLogout;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelBienvenida;
        private Button buttonRecaudacion;
    }
}