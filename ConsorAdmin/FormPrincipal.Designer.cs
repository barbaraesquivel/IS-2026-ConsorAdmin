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
            buttonProovedor.Location = new Point(3, 135);
            buttonProovedor.Name = "buttonProovedor";
            buttonProovedor.Size = new Size(280, 38);
            buttonProovedor.TabIndex = 3;
            buttonProovedor.Text = "Proovedor";
            buttonProovedor.UseVisualStyleBackColor = true;
            buttonProovedor.Click += buttonProovedor_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}