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
            buttonAdmin_FormPrincipal = new Button();
            buttonGestor_FormPrincipal = new Button();
            buttonConsorcista_FormPrincipal = new Button();
            buttonProovedor_FormPrincipal = new Button();
            buttonLogout_FormPrincipal = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAdmin_FormPrincipal);
            flowLayoutPanel1.Controls.Add(buttonGestor_FormPrincipal);
            flowLayoutPanel1.Controls.Add(buttonConsorcista_FormPrincipal);
            flowLayoutPanel1.Controls.Add(buttonProovedor_FormPrincipal);
            flowLayoutPanel1.Location = new Point(260, 77);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(283, 209);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdmin_FormPrincipal
            // 
            buttonAdmin_FormPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonAdmin_FormPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonAdmin_FormPrincipal.FlatStyle = FlatStyle.Flat;
            buttonAdmin_FormPrincipal.ForeColor = SystemColors.ControlLight;
            buttonAdmin_FormPrincipal.Location = new Point(3, 3);
            buttonAdmin_FormPrincipal.Name = "buttonAdmin_FormPrincipal";
            buttonAdmin_FormPrincipal.Size = new Size(280, 38);
            buttonAdmin_FormPrincipal.TabIndex = 0;
            buttonAdmin_FormPrincipal.Text = "Admin";
            buttonAdmin_FormPrincipal.UseVisualStyleBackColor = true;
            buttonAdmin_FormPrincipal.Click += buttonAdmin_Click;
            // 
            // buttonGestor_FormPrincipal
            // 
            buttonGestor_FormPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonGestor_FormPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonGestor_FormPrincipal.FlatStyle = FlatStyle.Flat;
            buttonGestor_FormPrincipal.ForeColor = SystemColors.ControlLight;
            buttonGestor_FormPrincipal.Location = new Point(3, 47);
            buttonGestor_FormPrincipal.Name = "buttonGestor_FormPrincipal";
            buttonGestor_FormPrincipal.Size = new Size(280, 38);
            buttonGestor_FormPrincipal.TabIndex = 1;
            buttonGestor_FormPrincipal.Text = "Gestor";
            buttonGestor_FormPrincipal.UseVisualStyleBackColor = true;
            buttonGestor_FormPrincipal.Click += buttonGestor_Click;
            // 
            // buttonConsorcista_FormPrincipal
            // 
            buttonConsorcista_FormPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonConsorcista_FormPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonConsorcista_FormPrincipal.FlatStyle = FlatStyle.Flat;
            buttonConsorcista_FormPrincipal.ForeColor = SystemColors.ControlLight;
            buttonConsorcista_FormPrincipal.Location = new Point(3, 91);
            buttonConsorcista_FormPrincipal.Name = "buttonConsorcista_FormPrincipal";
            buttonConsorcista_FormPrincipal.Size = new Size(280, 38);
            buttonConsorcista_FormPrincipal.TabIndex = 2;
            buttonConsorcista_FormPrincipal.Text = "Consorcista";
            buttonConsorcista_FormPrincipal.UseVisualStyleBackColor = true;
            buttonConsorcista_FormPrincipal.Click += buttonConsorcista_Click;
            // 
            // buttonProovedor_FormPrincipal
            // 
            buttonProovedor_FormPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(16, 34, 62);
            buttonProovedor_FormPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(16, 34, 62);
            buttonProovedor_FormPrincipal.FlatStyle = FlatStyle.Flat;
            buttonProovedor_FormPrincipal.ForeColor = SystemColors.ControlLight;
            buttonProovedor_FormPrincipal.Location = new Point(3, 135);
            buttonProovedor_FormPrincipal.Name = "buttonProovedor_FormPrincipal";
            buttonProovedor_FormPrincipal.Size = new Size(280, 38);
            buttonProovedor_FormPrincipal.TabIndex = 3;
            buttonProovedor_FormPrincipal.Text = "Proovedor";
            buttonProovedor_FormPrincipal.UseVisualStyleBackColor = true;
            buttonProovedor_FormPrincipal.Click += buttonProovedor_Click;
            // 
            // buttonLogout_FormPrincipal
            // 
            buttonLogout_FormPrincipal.Dock = DockStyle.Bottom;
            buttonLogout_FormPrincipal.FlatAppearance.BorderSize = 0;
            buttonLogout_FormPrincipal.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_FormPrincipal.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 28, 47);
            buttonLogout_FormPrincipal.FlatStyle = FlatStyle.Flat;
            buttonLogout_FormPrincipal.ForeColor = Color.FromArgb(220, 58, 89);
            buttonLogout_FormPrincipal.Location = new Point(0, 382);
            buttonLogout_FormPrincipal.Name = "buttonLogout_FormPrincipal";
            buttonLogout_FormPrincipal.Padding = new Padding(20, 0, 0, 0);
            buttonLogout_FormPrincipal.Size = new Size(800, 68);
            buttonLogout_FormPrincipal.TabIndex = 7;
            buttonLogout_FormPrincipal.Text = "Cerrar Sesión";
            buttonLogout_FormPrincipal.UseVisualStyleBackColor = true;
            buttonLogout_FormPrincipal.Click += buttonLogout_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogout_FormPrincipal);
            Controls.Add(flowLayoutPanel1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAdmin_FormPrincipal;
        private Button buttonGestor_FormPrincipal;
        private Button buttonConsorcista_FormPrincipal;
        private Button buttonProovedor_FormPrincipal;
        private Button buttonLogout_FormPrincipal;
    }
}