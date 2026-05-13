namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormInicioG
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
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            labelDeudas = new Label();
            panel4 = new Panel();
            groupBoxRecaudado = new GroupBox();
            labelCobrado = new Label();
            panelGreen = new Panel();
            groupBoxUltimas = new GroupBox();
            dataGridExpensas = new DataGridView();
            groupBoxEdificios = new GroupBox();
            dataGridEdificios = new DataGridView();
            groupBoxProxexp = new GroupBox();
            labelAcobrar = new Label();
            panel2 = new Panel();
            labelServicios = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBoxRecaudado.SuspendLayout();
            groupBoxUltimas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).BeginInit();
            groupBoxEdificios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).BeginInit();
            groupBoxProxexp.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(panel4);
            groupBox2.Controls.Add(groupBoxRecaudado);
            groupBox2.Controls.Add(panelGreen);
            groupBox2.Controls.Add(groupBoxUltimas);
            groupBox2.Controls.Add(groupBoxEdificios);
            groupBox2.Controls.Add(groupBoxProxexp);
            groupBox2.Controls.Add(panel2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(779, 796);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.None;
            groupBox3.BackColor = Color.FromArgb(17, 30, 53);
            groupBox3.Controls.Add(labelServicios);
            groupBox3.Controls.Add(labelDeudas);
            groupBox3.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox3.ForeColor = SystemColors.ControlLight;
            groupBox3.Location = new Point(493, 108);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(182, 84);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "DEUDAS";
            // 
            // labelDeudas
            // 
            labelDeudas.Anchor = AnchorStyles.None;
            labelDeudas.AutoSize = true;
            labelDeudas.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDeudas.Location = new Point(3, 16);
            labelDeudas.Name = "labelDeudas";
            labelDeudas.Size = new Size(22, 24);
            labelDeudas.TabIndex = 4;
            labelDeudas.Text = "X";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(255, 83, 113);
            panel4.Location = new Point(488, 100);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 96);
            panel4.TabIndex = 9;
            // 
            // groupBoxRecaudado
            // 
            groupBoxRecaudado.Anchor = AnchorStyles.None;
            groupBoxRecaudado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxRecaudado.Controls.Add(labelCobrado);
            groupBoxRecaudado.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxRecaudado.ForeColor = SystemColors.ControlLight;
            groupBoxRecaudado.Location = new Point(96, 108);
            groupBoxRecaudado.Margin = new Padding(3, 4, 3, 4);
            groupBoxRecaudado.Name = "groupBoxRecaudado";
            groupBoxRecaudado.Padding = new Padding(3, 4, 3, 4);
            groupBoxRecaudado.Size = new Size(182, 84);
            groupBoxRecaudado.TabIndex = 0;
            groupBoxRecaudado.TabStop = false;
            groupBoxRecaudado.Text = "RECAUDADO";
            // 
            // labelCobrado
            // 
            labelCobrado.Anchor = AnchorStyles.None;
            labelCobrado.AutoSize = true;
            labelCobrado.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCobrado.Location = new Point(3, 16);
            labelCobrado.Name = "labelCobrado";
            labelCobrado.Size = new Size(166, 24);
            labelCobrado.TabIndex = 0;
            labelCobrado.Text = "$000000000.00";
            // 
            // panelGreen
            // 
            panelGreen.Anchor = AnchorStyles.None;
            panelGreen.BackColor = Color.FromArgb(0, 220, 144);
            panelGreen.Location = new Point(91, 100);
            panelGreen.Margin = new Padding(3, 4, 3, 4);
            panelGreen.Name = "panelGreen";
            panelGreen.Size = new Size(191, 96);
            panelGreen.TabIndex = 5;
            // 
            // groupBoxUltimas
            // 
            groupBoxUltimas.Anchor = AnchorStyles.None;
            groupBoxUltimas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxUltimas.Controls.Add(dataGridExpensas);
            groupBoxUltimas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxUltimas.ForeColor = SystemColors.ControlLight;
            groupBoxUltimas.Location = new Point(392, 273);
            groupBoxUltimas.Margin = new Padding(3, 4, 3, 4);
            groupBoxUltimas.Name = "groupBoxUltimas";
            groupBoxUltimas.Padding = new Padding(3, 4, 3, 4);
            groupBoxUltimas.Size = new Size(302, 404);
            groupBoxUltimas.TabIndex = 4;
            groupBoxUltimas.TabStop = false;
            groupBoxUltimas.Text = "ULTIMAS EXPENSAS";
            // 
            // dataGridExpensas
            // 
            dataGridExpensas.Anchor = AnchorStyles.None;
            dataGridExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExpensas.Location = new Point(6, 28);
            dataGridExpensas.Margin = new Padding(3, 4, 3, 4);
            dataGridExpensas.Name = "dataGridExpensas";
            dataGridExpensas.RowHeadersWidth = 51;
            dataGridExpensas.Size = new Size(288, 369);
            dataGridExpensas.TabIndex = 9;
            // 
            // groupBoxEdificios
            // 
            groupBoxEdificios.Anchor = AnchorStyles.None;
            groupBoxEdificios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificios.Controls.Add(dataGridEdificios);
            groupBoxEdificios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificios.ForeColor = SystemColors.ControlLight;
            groupBoxEdificios.Location = new Point(78, 273);
            groupBoxEdificios.Margin = new Padding(3, 4, 3, 4);
            groupBoxEdificios.Name = "groupBoxEdificios";
            groupBoxEdificios.Padding = new Padding(3, 4, 3, 4);
            groupBoxEdificios.Size = new Size(302, 404);
            groupBoxEdificios.TabIndex = 3;
            groupBoxEdificios.TabStop = false;
            groupBoxEdificios.Text = "MIS EDIFICIOS";
            // 
            // dataGridEdificios
            // 
            dataGridEdificios.Anchor = AnchorStyles.None;
            dataGridEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEdificios.Location = new Point(9, 28);
            dataGridEdificios.Margin = new Padding(3, 4, 3, 4);
            dataGridEdificios.Name = "dataGridEdificios";
            dataGridEdificios.RowHeadersWidth = 51;
            dataGridEdificios.Size = new Size(285, 368);
            dataGridEdificios.TabIndex = 0;
            // 
            // groupBoxProxexp
            // 
            groupBoxProxexp.Anchor = AnchorStyles.None;
            groupBoxProxexp.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxProxexp.Controls.Add(labelAcobrar);
            groupBoxProxexp.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxProxexp.ForeColor = SystemColors.ControlLight;
            groupBoxProxexp.Location = new Point(294, 108);
            groupBoxProxexp.Margin = new Padding(3, 4, 3, 4);
            groupBoxProxexp.Name = "groupBoxProxexp";
            groupBoxProxexp.Padding = new Padding(3, 4, 3, 4);
            groupBoxProxexp.Size = new Size(182, 84);
            groupBoxProxexp.TabIndex = 2;
            groupBoxProxexp.TabStop = false;
            groupBoxProxexp.Text = "POR VENCER";
            // 
            // labelAcobrar
            // 
            labelAcobrar.Anchor = AnchorStyles.None;
            labelAcobrar.AutoSize = true;
            labelAcobrar.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAcobrar.Location = new Point(6, 16);
            labelAcobrar.Name = "labelAcobrar";
            labelAcobrar.Size = new Size(22, 24);
            labelAcobrar.TabIndex = 4;
            labelAcobrar.Text = "X";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(255, 189, 20);
            panel2.Location = new Point(290, 100);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 96);
            panel2.TabIndex = 7;
            // 
            // labelServicios
            // 
            labelServicios.Anchor = AnchorStyles.None;
            labelServicios.AutoSize = true;
            labelServicios.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelServicios.Location = new Point(6, 54);
            labelServicios.Name = "labelServicios";
            labelServicios.Size = new Size(147, 14);
            labelServicios.TabIndex = 5;
            labelServicios.Text = "Consorcistas morosos";
            // 
            // FormInicioG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(779, 796);
            Controls.Add(groupBox2);
            Name = "FormInicioG";
            Text = "FormInicioG";
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBoxRecaudado.ResumeLayout(false);
            groupBoxRecaudado.PerformLayout();
            groupBoxUltimas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).EndInit();
            groupBoxEdificios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).EndInit();
            groupBoxProxexp.ResumeLayout(false);
            groupBoxProxexp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelDeudas;
        private Panel panel4;
        private GroupBox groupBoxRecaudado;
        private Label labelCobrado;
        private Panel panelGreen;
        private GroupBox groupBoxUltimas;
        private DataGridView dataGridExpensas;
        private GroupBox groupBoxEdificios;
        private DataGridView dataGridEdificios;
        private GroupBox groupBoxProxexp;
        private Label labelAcobrar;
        private Panel panel2;
        private Label labelServicios;
    }
}