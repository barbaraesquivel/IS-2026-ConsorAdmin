namespace ConsorAdmin
{
    partial class FormPrincipal
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdmin = new Button();
            buttonGestor = new Button();
            buttonConsorcista = new Button();
            buttonProovedor = new Button();
            buttonLogout = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAdmin);
            flowLayoutPanel1.Controls.Add(buttonGestor);
            flowLayoutPanel1.Controls.Add(buttonConsorcista);
            flowLayoutPanel1.Controls.Add(buttonProovedor);
            flowLayoutPanel1.Location = new Point(260, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 209);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdmin
            // 
            buttonAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.ForeColor = SystemColors.ControlLight;
            buttonAdmin.Location = new Point(3, 3);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(280, 38);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonGestor
            // 
            buttonGestor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonGestor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonGestor.FlatStyle = FlatStyle.Flat;
            buttonGestor.ForeColor = SystemColors.ControlLight;
            buttonGestor.Location = new Point(3, 47);
            buttonGestor.Name = "buttonGestor";
            buttonGestor.Size = new Size(280, 38);
            buttonGestor.TabIndex = 1;
            buttonGestor.Text = "Gestor";
            buttonGestor.UseVisualStyleBackColor = true;
            buttonGestor.Click += buttonGestor_Click;
            // 
            // buttonConsorcista
            // 
            buttonConsorcista.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonConsorcista.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonConsorcista.FlatStyle = FlatStyle.Flat;
            buttonConsorcista.ForeColor = SystemColors.ControlLight;
            buttonConsorcista.Location = new Point(3, 91);
            buttonConsorcista.Name = "buttonConsorcista";
            buttonConsorcista.Size = new Size(280, 38);
            buttonConsorcista.TabIndex = 2;
            buttonConsorcista.Text = "Consorcista";
            buttonConsorcista.UseVisualStyleBackColor = true;
            buttonConsorcista.Click += buttonConsorcista_Click;
            // 
            // buttonProovedor
            // 
            buttonProovedor.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonProovedor.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonProovedor.FlatStyle = FlatStyle.Flat;
            buttonProovedor.ForeColor = SystemColors.ControlLight;
            buttonProovedor.Location = new Point(3, 135);
            buttonProovedor.Name = "buttonProovedor";
            buttonProovedor.Size = new Size(280, 38);
            buttonProovedor.TabIndex = 3;
            buttonProovedor.Text = "Proovedor";
            buttonProovedor.UseVisualStyleBackColor = true;
            buttonProovedor.Click += buttonProovedor_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Dock = DockStyle.Bottom;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.ForeColor = Color.FromArgb(220, 58, 89);
            buttonLogout.Location = new Point(0, 382);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(20, 0, 0, 0);
            buttonLogout.Size = new Size(800, 68);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "Cerrar Sesión";
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogout);
            Controls.Add(flowLayoutPanel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdmin;
        private Button buttonGestor;
        private Button buttonConsorcista;
        private Button buttonProovedor;
        private Button buttonLogout;
    }
}