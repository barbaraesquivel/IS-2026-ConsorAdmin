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
            labelUsername_Form1Proovedor = new Label();
            labelSESION_Form1Proovedor = new Label();
            panelChildForm = new Panel();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            labelBienvenida_Form1Proovedor = new Label();
            panelSideMenu = new Panel();
            buttonLogout_Form1Proovedor = new Button();
            buttonModificarPerfil_Form1Proovedor = new Button();
            buttonVerServicios_Form1Proovedor = new Button();
            buttonCargar_Form1Proovedor = new Button();
            buttonInicio_Form1Proovedor = new Button();
            cboIdiomaShell = new ComboBox();
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
            panelSessionInfo.Controls.Add(cboIdiomaShell);
            panelSessionInfo.Controls.Add(pictureBox2);
            panelSessionInfo.Controls.Add(labelUsername_Form1Proovedor);
            panelSessionInfo.Controls.Add(labelSESION_Form1Proovedor);
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
            // labelUsername_Form1Proovedor
            // 
            labelUsername_Form1Proovedor.AutoSize = true;
            labelUsername_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            labelUsername_Form1Proovedor.Location = new Point(12, 93);
            labelUsername_Form1Proovedor.Name = "labelUsername_Form1Proovedor";
            labelUsername_Form1Proovedor.Size = new Size(60, 15);
            labelUsername_Form1Proovedor.TabIndex = 1;
            labelUsername_Form1Proovedor.Text = "Username";
            // 
            // labelSESION_Form1Proovedor
            // 
            labelSESION_Form1Proovedor.AutoSize = true;
            labelSESION_Form1Proovedor.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSESION_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            labelSESION_Form1Proovedor.Location = new Point(12, 79);
            labelSESION_Form1Proovedor.Name = "labelSESION_Form1Proovedor";
            labelSESION_Form1Proovedor.Size = new Size(111, 15);
            labelSESION_Form1Proovedor.TabIndex = 0;
            labelSESION_Form1Proovedor.Text = "SESION ACTIVA";
            //
            // cboIdiomaShell
            //
            cboIdiomaShell.FormattingEnabled = true;
            cboIdiomaShell.Location = new Point(12, 114);
            cboIdiomaShell.Name = "cboIdiomaShell";
            cboIdiomaShell.Size = new Size(162, 23);
            cboIdiomaShell.TabIndex = 3;
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
            groupBox1.Controls.Add(labelBienvenida_Form1Proovedor);
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
            // labelBienvenida_Form1Proovedor
            // 
            labelBienvenida_Form1Proovedor.Anchor = AnchorStyles.None;
            labelBienvenida_Form1Proovedor.AutoSize = true;
            labelBienvenida_Form1Proovedor.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            labelBienvenida_Form1Proovedor.Location = new Point(234, 99);
            labelBienvenida_Form1Proovedor.Name = "labelBienvenida_Form1Proovedor";
            labelBienvenida_Form1Proovedor.Size = new Size(219, 38);
            labelBienvenida_Form1Proovedor.TabIndex = 0;
            labelBienvenida_Form1Proovedor.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            labelBienvenida_Form1Proovedor.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(13, 22, 40);
            panelSideMenu.Controls.Add(buttonLogout_Form1Proovedor);
            panelSideMenu.Controls.Add(buttonModificarPerfil_Form1Proovedor);
            panelSideMenu.Controls.Add(buttonVerServicios_Form1Proovedor);
            panelSideMenu.Controls.Add(buttonCargar_Form1Proovedor);
            panelSideMenu.Controls.Add(buttonInicio_Form1Proovedor);
            panelSideMenu.Controls.Add(panelSessionInfo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(186, 636);
            panelSideMenu.TabIndex = 2;
            // 
            // buttonLogout_Form1Proovedor
            // 
            buttonLogout_Form1Proovedor.Dock = DockStyle.Bottom;
            buttonLogout_Form1Proovedor.FlatAppearance.BorderSize = 0;
            buttonLogout_Form1Proovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_Form1Proovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_Form1Proovedor.FlatStyle = FlatStyle.Flat;
            buttonLogout_Form1Proovedor.ForeColor = Color.FromArgb(220, 58, 89);
            buttonLogout_Form1Proovedor.Location = new Point(0, 596);
            buttonLogout_Form1Proovedor.Name = "buttonLogout_Form1Proovedor";
            buttonLogout_Form1Proovedor.Padding = new Padding(20, 0, 0, 0);
            buttonLogout_Form1Proovedor.Size = new Size(186, 40);
            buttonLogout_Form1Proovedor.TabIndex = 6;
            buttonLogout_Form1Proovedor.Text = "Salir";
            buttonLogout_Form1Proovedor.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout_Form1Proovedor.UseVisualStyleBackColor = true;
            buttonLogout_Form1Proovedor.Click += buttonLogout_Click;
            // 
            // buttonModificarPerfil_Form1Proovedor
            // 
            buttonModificarPerfil_Form1Proovedor.Dock = DockStyle.Top;
            buttonModificarPerfil_Form1Proovedor.FlatAppearance.BorderSize = 0;
            buttonModificarPerfil_Form1Proovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonModificarPerfil_Form1Proovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonModificarPerfil_Form1Proovedor.FlatStyle = FlatStyle.Flat;
            buttonModificarPerfil_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            buttonModificarPerfil_Form1Proovedor.Location = new Point(0, 244);
            buttonModificarPerfil_Form1Proovedor.Name = "buttonModificarPerfil_Form1Proovedor";
            buttonModificarPerfil_Form1Proovedor.Padding = new Padding(20, 0, 0, 0);
            buttonModificarPerfil_Form1Proovedor.Size = new Size(186, 40);
            buttonModificarPerfil_Form1Proovedor.TabIndex = 5;
            buttonModificarPerfil_Form1Proovedor.Text = "Modificar Perfil";
            buttonModificarPerfil_Form1Proovedor.TextAlign = ContentAlignment.MiddleLeft;
            buttonModificarPerfil_Form1Proovedor.UseVisualStyleBackColor = true;
            buttonModificarPerfil_Form1Proovedor.Click += buttonModificarPerfil_Click;
            // 
            // buttonVerServicios_Form1Proovedor
            // 
            buttonVerServicios_Form1Proovedor.Dock = DockStyle.Top;
            buttonVerServicios_Form1Proovedor.FlatAppearance.BorderSize = 0;
            buttonVerServicios_Form1Proovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonVerServicios_Form1Proovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonVerServicios_Form1Proovedor.FlatStyle = FlatStyle.Flat;
            buttonVerServicios_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            buttonVerServicios_Form1Proovedor.Location = new Point(0, 204);
            buttonVerServicios_Form1Proovedor.Name = "buttonVerServicios_Form1Proovedor";
            buttonVerServicios_Form1Proovedor.Padding = new Padding(20, 0, 0, 0);
            buttonVerServicios_Form1Proovedor.Size = new Size(186, 40);
            buttonVerServicios_Form1Proovedor.TabIndex = 4;
            buttonVerServicios_Form1Proovedor.Text = "Ver Servicios";
            buttonVerServicios_Form1Proovedor.TextAlign = ContentAlignment.MiddleLeft;
            buttonVerServicios_Form1Proovedor.UseVisualStyleBackColor = true;
            buttonVerServicios_Form1Proovedor.Click += buttonVerServicios_Click;
            // 
            // buttonCargar_Form1Proovedor
            // 
            buttonCargar_Form1Proovedor.Dock = DockStyle.Top;
            buttonCargar_Form1Proovedor.FlatAppearance.BorderSize = 0;
            buttonCargar_Form1Proovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonCargar_Form1Proovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonCargar_Form1Proovedor.FlatStyle = FlatStyle.Flat;
            buttonCargar_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            buttonCargar_Form1Proovedor.Location = new Point(0, 164);
            buttonCargar_Form1Proovedor.Name = "buttonCargar_Form1Proovedor";
            buttonCargar_Form1Proovedor.Padding = new Padding(20, 0, 0, 0);
            buttonCargar_Form1Proovedor.Size = new Size(186, 40);
            buttonCargar_Form1Proovedor.TabIndex = 3;
            buttonCargar_Form1Proovedor.Text = "Cargar Servicio";
            buttonCargar_Form1Proovedor.TextAlign = ContentAlignment.MiddleLeft;
            buttonCargar_Form1Proovedor.UseVisualStyleBackColor = true;
            buttonCargar_Form1Proovedor.Click += buttonCargar_Click;
            // 
            // buttonInicio_Form1Proovedor
            // 
            buttonInicio_Form1Proovedor.Dock = DockStyle.Top;
            buttonInicio_Form1Proovedor.FlatAppearance.BorderSize = 0;
            buttonInicio_Form1Proovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio_Form1Proovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonInicio_Form1Proovedor.FlatStyle = FlatStyle.Flat;
            buttonInicio_Form1Proovedor.ForeColor = SystemColors.ControlLight;
            buttonInicio_Form1Proovedor.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInicio_Form1Proovedor.Location = new Point(0, 124);
            buttonInicio_Form1Proovedor.Name = "buttonInicio_Form1Proovedor";
            buttonInicio_Form1Proovedor.Padding = new Padding(20, 0, 0, 0);
            buttonInicio_Form1Proovedor.Size = new Size(186, 40);
            buttonInicio_Form1Proovedor.TabIndex = 2;
            buttonInicio_Form1Proovedor.Text = "Inicio";
            buttonInicio_Form1Proovedor.TextAlign = ContentAlignment.MiddleLeft;
            buttonInicio_Form1Proovedor.UseVisualStyleBackColor = true;
            buttonInicio_Form1Proovedor.Click += buttonInicio_Click;
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
            FormClosing += Form1Proovedor_FormClosing;
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
        private Label labelUsername_Form1Proovedor;
        private Label labelSESION_Form1Proovedor;
        private Panel panelChildForm;
        private Panel panelSideMenu;
        private Button buttonLogout_Form1Proovedor;
        private Button buttonModificarPerfil_Form1Proovedor;
        private Button buttonVerServicios_Form1Proovedor;
        private Button buttonCargar_Form1Proovedor;
        private Button buttonInicio_Form1Proovedor;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label labelBienvenida_Form1Proovedor;
        private ComboBox cboIdiomaShell;
    }
}