

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
            panelChildForm = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelSideMenu.SuspendLayout();
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
            buttonModificarPerfil.Click += this.buttonModificarPerfil_Click;
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
            buttonVerExpensas.Click += this.buttonVerExpensas_Click;
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
            buttonPagarExpensas.Click += this.buttonPagarExpensas_Click;
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
            buttonInicio.Click += this.buttonInicio_Click;
            // 
            // panelSessionInfo
            // 
            panelSessionInfo.Dock = DockStyle.Top;
            panelSessionInfo.Location = new Point(0, 0);
            panelSessionInfo.Name = "panelSessionInfo";
            panelSessionInfo.Size = new Size(186, 124);
            panelSessionInfo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(8, 14, 26);
            panelChildForm.Controls.Add(pictureBox1);
            panelChildForm.Controls.Add(label1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(186, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(698, 636);
            panelChildForm.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(86, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(532, 404);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(241, 83);
            label1.Name = "label1";
            label1.Size = new Size(219, 38);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido usuari@ a \r\nConsorAdmin";
            label1.TextAlign = ContentAlignment.TopCenter;
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
            MaximizeBox = false;
            MinimumSize = new Size(900, 675);
            Name = "Form1";
            Text = "Form1";
            panelSideMenu.ResumeLayout(false);
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
        private Label label1;
        private PictureBox pictureBox1;
    }
}
