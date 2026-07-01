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
            labelUsername_Form1Gestor = new Label();
            labelSESION_Form1Gestor = new Label();
            buttonHistorial_Form1Gestor = new Button();
            buttonVerEdificios_Form1Gestor = new Button();
            buttonCargarExpensas_Form1Gestor = new Button();
            buttonInicio_Form1Gestor = new Button();
            panelSideMenu = new Panel();
            buttonGestionarUnidades_Form1Gestor = new Button();
            buttonRecaudacion_Form1Gestor = new Button();
            buttonLogout_Form1Gestor = new Button();
            panelChildForm = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelBienvenida_Form1Gestor = new Label();
            cboIdiomaShell = new ComboBox();
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
            panelSessionInfo.Controls.Add(cboIdiomaShell);
            panelSessionInfo.Controls.Add(pictureBox2);
            panelSessionInfo.Controls.Add(labelUsername_Form1Gestor);
            panelSessionInfo.Controls.Add(labelSESION_Form1Gestor);
            panelSessionInfo.Dock = DockStyle.Top;
            panelSessionInfo.Location = new Point(0, 0);
            panelSessionInfo.Name = "panelSessionInfo";
            panelSessionInfo.Size = new Size(186, 150);
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
            // labelUsername_Form1Gestor
            // 
            labelUsername_Form1Gestor.AutoSize = true;
            labelUsername_Form1Gestor.ForeColor = SystemColors.ControlLight;
            labelUsername_Form1Gestor.Location = new Point(12, 93);
            labelUsername_Form1Gestor.Name = "labelUsername_Form1Gestor";
            labelUsername_Form1Gestor.Size = new Size(60, 15);
            labelUsername_Form1Gestor.TabIndex = 1;
            labelUsername_Form1Gestor.Text = "Username";
            // 
            // labelSESION_Form1Gestor
            // 
            labelSESION_Form1Gestor.AutoSize = true;
            labelSESION_Form1Gestor.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSESION_Form1Gestor.ForeColor = SystemColors.ControlLight;
            labelSESION_Form1Gestor.Location = new Point(12, 79);
            labelSESION_Form1Gestor.Name = "labelSESION_Form1Gestor";
            labelSESION_Form1Gestor.Size = new Size(121, 16);
            labelSESION_Form1Gestor.TabIndex = 0;
            labelSESION_Form1Gestor.Text = "SESION ACTIVA";
            //
            // cboIdiomaShell
            //
            cboIdiomaShell.FormattingEnabled = true;
            cboIdiomaShell.Location = new Point(12, 114);
            cboIdiomaShell.Name = "cboIdiomaShell";
            cboIdiomaShell.Size = new Size(162, 23);
            cboIdiomaShell.TabIndex = 3;
            //
            // buttonHistorial_Form1Gestor
            // 
            buttonHistorial_Form1Gestor.Dock = DockStyle.Top;
            buttonHistorial_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonHistorial_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonHistorial_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonHistorial_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonHistorial_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonHistorial_Form1Gestor.Location = new Point(0, 244);
            buttonHistorial_Form1Gestor.Name = "buttonHistorial_Form1Gestor";
            buttonHistorial_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonHistorial_Form1Gestor.Size = new Size(186, 40);
            buttonHistorial_Form1Gestor.TabIndex = 5;
            buttonHistorial_Form1Gestor.Text = "Historial";
            buttonHistorial_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonHistorial_Form1Gestor.UseVisualStyleBackColor = true;
            buttonHistorial_Form1Gestor.Click += buttonHistorial_Click;
            // 
            // buttonVerEdificios_Form1Gestor
            // 
            buttonVerEdificios_Form1Gestor.Dock = DockStyle.Top;
            buttonVerEdificios_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonVerEdificios_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonVerEdificios_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonVerEdificios_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonVerEdificios_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonVerEdificios_Form1Gestor.Location = new Point(0, 204);
            buttonVerEdificios_Form1Gestor.Name = "buttonVerEdificios_Form1Gestor";
            buttonVerEdificios_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonVerEdificios_Form1Gestor.Size = new Size(186, 40);
            buttonVerEdificios_Form1Gestor.TabIndex = 4;
            buttonVerEdificios_Form1Gestor.Text = "Reporte consorcios";
            buttonVerEdificios_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerEdificios_Form1Gestor.UseVisualStyleBackColor = true;
            buttonVerEdificios_Form1Gestor.Click += buttonVerEdificios_Click;
            // 
            // buttonCargarExpensas_Form1Gestor
            // 
            buttonCargarExpensas_Form1Gestor.Dock = DockStyle.Top;
            buttonCargarExpensas_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonCargarExpensas_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonCargarExpensas_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonCargarExpensas_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonCargarExpensas_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonCargarExpensas_Form1Gestor.Location = new Point(0, 164);
            buttonCargarExpensas_Form1Gestor.Name = "buttonCargarExpensas_Form1Gestor";
            buttonCargarExpensas_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonCargarExpensas_Form1Gestor.Size = new Size(186, 40);
            buttonCargarExpensas_Form1Gestor.TabIndex = 3;
            buttonCargarExpensas_Form1Gestor.Text = "Liquidar Expensas";
            buttonCargarExpensas_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonCargarExpensas_Form1Gestor.UseVisualStyleBackColor = true;
            buttonCargarExpensas_Form1Gestor.Click += buttonCargarExpensas_Click;
            // 
            // buttonInicio_Form1Gestor
            // 
            buttonInicio_Form1Gestor.Dock = DockStyle.Top;
            buttonInicio_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonInicio_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonInicio_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonInicio_Form1Gestor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio_Form1Gestor.Location = new Point(0, 124);
            buttonInicio_Form1Gestor.Name = "buttonInicio_Form1Gestor";
            buttonInicio_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonInicio_Form1Gestor.Size = new Size(186, 40);
            buttonInicio_Form1Gestor.TabIndex = 2;
            buttonInicio_Form1Gestor.Text = "Inicio";
            buttonInicio_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonInicio_Form1Gestor.UseVisualStyleBackColor = true;
            buttonInicio_Form1Gestor.Click += buttonInicio_Click;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonGestionarUnidades_Form1Gestor);
            panelSideMenu.Controls.Add(buttonRecaudacion_Form1Gestor);
            panelSideMenu.Controls.Add(buttonLogout_Form1Gestor);
            panelSideMenu.Controls.Add(buttonHistorial_Form1Gestor);
            panelSideMenu.Controls.Add(buttonVerEdificios_Form1Gestor);
            panelSideMenu.Controls.Add(buttonCargarExpensas_Form1Gestor);
            panelSideMenu.Controls.Add(buttonInicio_Form1Gestor);
            panelSideMenu.Controls.Add(panelSessionInfo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(186, 636);
            panelSideMenu.TabIndex = 3;
            // 
            // buttonGestionarUnidades_Form1Gestor
            // 
            buttonGestionarUnidades_Form1Gestor.Dock = DockStyle.Top;
            buttonGestionarUnidades_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonGestionarUnidades_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonGestionarUnidades_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonGestionarUnidades_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonGestionarUnidades_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonGestionarUnidades_Form1Gestor.Location = new Point(0, 324);
            buttonGestionarUnidades_Form1Gestor.Name = "buttonGestionarUnidades_Form1Gestor";
            buttonGestionarUnidades_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonGestionarUnidades_Form1Gestor.Size = new Size(186, 40);
            buttonGestionarUnidades_Form1Gestor.TabIndex = 8;
            buttonGestionarUnidades_Form1Gestor.Text = "Gestionar consorcios y unidades";
            buttonGestionarUnidades_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonGestionarUnidades_Form1Gestor.UseVisualStyleBackColor = true;
            buttonGestionarUnidades_Form1Gestor.Click += buttonGestionarUnidades_Click;
            // 
            // buttonRecaudacion_Form1Gestor
            // 
            buttonRecaudacion_Form1Gestor.Dock = DockStyle.Top;
            buttonRecaudacion_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonRecaudacion_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonRecaudacion_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonRecaudacion_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonRecaudacion_Form1Gestor.ForeColor = SystemColors.ControlLight;
            buttonRecaudacion_Form1Gestor.Location = new Point(0, 284);
            buttonRecaudacion_Form1Gestor.Name = "buttonRecaudacion_Form1Gestor";
            buttonRecaudacion_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonRecaudacion_Form1Gestor.Size = new Size(186, 40);
            buttonRecaudacion_Form1Gestor.TabIndex = 7;
            buttonRecaudacion_Form1Gestor.Text = "Ver recaudación";
            buttonRecaudacion_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonRecaudacion_Form1Gestor.UseVisualStyleBackColor = true;
            buttonRecaudacion_Form1Gestor.Click += buttonRecaudacion_Click;
            // 
            // buttonLogout_Form1Gestor
            // 
            buttonLogout_Form1Gestor.Dock = DockStyle.Bottom;
            buttonLogout_Form1Gestor.FlatAppearance.BorderSize = 0;
            buttonLogout_Form1Gestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_Form1Gestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_Form1Gestor.FlatStyle = FlatStyle.Flat;
            buttonLogout_Form1Gestor.ForeColor = Color.FromArgb(220, 58, 89);
            buttonLogout_Form1Gestor.Location = new Point(0, 596);
            buttonLogout_Form1Gestor.Name = "buttonLogout_Form1Gestor";
            buttonLogout_Form1Gestor.Padding = new Padding(20, 0, 0, 0);
            buttonLogout_Form1Gestor.Size = new Size(186, 40);
            buttonLogout_Form1Gestor.TabIndex = 6;
            buttonLogout_Form1Gestor.Text = "Salir";
            buttonLogout_Form1Gestor.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout_Form1Gestor.UseVisualStyleBackColor = true;
            buttonLogout_Form1Gestor.Click += buttonLogout_Click;
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
            groupBox1.Controls.Add(labelBienvenida_Form1Gestor);
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
            // labelBienvenida_Form1Gestor
            // 
            labelBienvenida_Form1Gestor.Anchor = AnchorStyles.None;
            labelBienvenida_Form1Gestor.AutoSize = true;
            labelBienvenida_Form1Gestor.Font = new Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida_Form1Gestor.ForeColor = SystemColors.ControlLight;
            labelBienvenida_Form1Gestor.Location = new Point(247, 93);
            labelBienvenida_Form1Gestor.Name = "labelBienvenida_Form1Gestor";
            labelBienvenida_Form1Gestor.Size = new Size(188, 40);
            labelBienvenida_Form1Gestor.TabIndex = 0;
            labelBienvenida_Form1Gestor.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida_Form1Gestor.TextAlign = ContentAlignment.TopCenter;
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
            FormClosing += Form1Gestor_FormClosing;
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
        private Label labelUsername_Form1Gestor;
        private Label labelSESION_Form1Gestor;
        private Button buttonHistorial_Form1Gestor;
        private Button buttonVerEdificios_Form1Gestor;
        private Button buttonCargarExpensas_Form1Gestor;
        private Button buttonInicio_Form1Gestor;
        private Panel panelSideMenu;
        private Button buttonLogout_Form1Gestor;
        private Button buttonRecaudacion_Form1Gestor;
        private Panel panelChildForm;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelBienvenida_Form1Gestor;
        private Button buttonGestionarUnidades_Form1Gestor;
        private ComboBox cboIdiomaShell;
    }
}