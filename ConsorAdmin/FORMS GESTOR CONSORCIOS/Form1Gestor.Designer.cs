namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class Form1Gestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Gestor));
            panelSessionInfo = new Panel();
            pictureBox2 = new PictureBox();
            labelUsername = new Label();
            labelSESION = new Label();
            buttonHistorial = new Button();
            buttonVerEdificios = new Button();
            buttonCargarExpensas = new Button();
            buttonInicio = new Button();
            panelSideMenu = new Panel();
            buttonRecaudacion = new Button();
            buttonLogout = new Button();
            panelChildForm = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelBienvenida = new Label();
            panelSessionInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSideMenu.SuspendLayout();
            panelChildForm.SuspendLayout();
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
            // buttonHistorial
            // 
            buttonHistorial.Dock = DockStyle.Top;
            buttonHistorial.FlatAppearance.BorderSize = 0;
            buttonHistorial.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonHistorial.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonHistorial.FlatStyle = FlatStyle.Flat;
            buttonHistorial.ForeColor = SystemColors.ControlLight;
            buttonHistorial.Location = new Point(0, 244);
            buttonHistorial.Name = "buttonHistorial";
            buttonHistorial.Padding = new Padding(20, 0, 0, 0);
            buttonHistorial.Size = new Size(186, 40);
            buttonHistorial.TabIndex = 5;
            buttonHistorial.Text = "Historial";
            buttonHistorial.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistorial.UseVisualStyleBackColor = true;
            buttonHistorial.Click += buttonHistorial_Click;
            // 
            // buttonVerEdificios
            // 
            buttonVerEdificios.Dock = DockStyle.Top;
            buttonVerEdificios.FlatAppearance.BorderSize = 0;
            buttonVerEdificios.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonVerEdificios.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonVerEdificios.FlatStyle = FlatStyle.Flat;
            buttonVerEdificios.ForeColor = SystemColors.ControlLight;
            buttonVerEdificios.Location = new Point(0, 204);
            buttonVerEdificios.Name = "buttonVerEdificios";
            buttonVerEdificios.Padding = new Padding(20, 0, 0, 0);
            buttonVerEdificios.Size = new Size(186, 40);
            buttonVerEdificios.TabIndex = 4;
            buttonVerEdificios.Text = "Mis Edificios";
            buttonVerEdificios.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerEdificios.UseVisualStyleBackColor = true;
            buttonVerEdificios.Click += buttonVerEdificios_Click;
            // 
            // buttonCargarExpensas
            // 
            buttonCargarExpensas.Dock = DockStyle.Top;
            buttonCargarExpensas.FlatAppearance.BorderSize = 0;
            buttonCargarExpensas.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonCargarExpensas.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonCargarExpensas.FlatStyle = FlatStyle.Flat;
            buttonCargarExpensas.ForeColor = SystemColors.ControlLight;
            buttonCargarExpensas.Location = new Point(0, 164);
            buttonCargarExpensas.Name = "buttonCargarExpensas";
            buttonCargarExpensas.Padding = new Padding(20, 0, 0, 0);
            buttonCargarExpensas.Size = new Size(186, 40);
            buttonCargarExpensas.TabIndex = 3;
            buttonCargarExpensas.Text = "Cargar Expensas";
            buttonCargarExpensas.TextAlign = ContentAlignment.MiddleLeft;
            buttonCargarExpensas.UseVisualStyleBackColor = true;
            buttonCargarExpensas.Click += buttonCargarExpensas_Click;
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
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonRecaudacion);
            panelSideMenu.Controls.Add(buttonLogout);
            panelSideMenu.Controls.Add(buttonHistorial);
            panelSideMenu.Controls.Add(buttonVerEdificios);
            panelSideMenu.Controls.Add(buttonCargarExpensas);
            panelSideMenu.Controls.Add(buttonInicio);
            panelSideMenu.Controls.Add(panelSessionInfo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(186, 636);
            panelSideMenu.TabIndex = 3;
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
            buttonRecaudacion.Click += buttonRecaudacion_Click;
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
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(8, 14, 26);
            panelChildForm.Controls.Add(groupBox1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(186, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(698, 636);
            panelChildForm.TabIndex = 4;
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
            pictureBox1.Location = new Point(92, 134);
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
            labelBienvenida.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.ForeColor = SystemColors.ControlLight;
            labelBienvenida.Location = new Point(247, 93);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(188, 40);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1Gestor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(884, 636);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            MinimumSize = new Size(900, 675);
            Name = "Form1Gestor";
            Text = "Form1";
            Load += Form1Gestor_Load;
            panelSessionInfo.ResumeLayout(false);
            panelSessionInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSideMenu.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
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
        private Button buttonHistorial;
        private Button buttonVerEdificios;
        private Button buttonCargarExpensas;
        private Button buttonInicio;
        private Panel panelSideMenu;
        private Button buttonLogout;
        private Button buttonRecaudacion;
        private Panel panelChildForm;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelBienvenida;
    }
}