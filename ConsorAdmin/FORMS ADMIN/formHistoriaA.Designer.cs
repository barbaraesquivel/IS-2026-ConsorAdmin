namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formHistoriaA
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
            dataGridViewExpensas = new DataGridView();
            buttonLimpiar = new Button();
            buttonBuscar = new Button();
            comboBoxEdificios = new ComboBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpensas).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(dataGridViewExpensas);
            groupBox2.Controls.Add(buttonLimpiar);
            groupBox2.Controls.Add(buttonBuscar);
            groupBox2.Controls.Add(comboBoxEdificios);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // dataGridViewExpensas
            // 
            dataGridViewExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpensas.Location = new Point(52, 104);
            dataGridViewExpensas.Margin = new Padding(3, 2, 3, 2);
            dataGridViewExpensas.Name = "dataGridViewExpensas";
            dataGridViewExpensas.RowHeadersWidth = 51;
            dataGridViewExpensas.Size = new Size(573, 472);
            dataGridViewExpensas.TabIndex = 37;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Anchor = AnchorStyles.Top;
            buttonLimpiar.BackColor = Color.Transparent;
            buttonLimpiar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonLimpiar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonLimpiar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.ForeColor = SystemColors.ControlLight;
            buttonLimpiar.Location = new Point(386, 64);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(129, 22);
            buttonLimpiar.TabIndex = 36;
            buttonLimpiar.Text = "Limpiar Vista";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.Top;
            buttonBuscar.BackColor = Color.Transparent;
            buttonBuscar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonBuscar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonBuscar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.ForeColor = SystemColors.ControlLight;
            buttonBuscar.Location = new Point(536, 63);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(121, 23);
            buttonBuscar.TabIndex = 35;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(52, 64);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(264, 22);
            comboBoxEdificios.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(133, 14);
            label1.TabIndex = 0;
            label1.Text = "Buscar por codigo:";
            // 
            // formHistoriaA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formHistoriaA";
            Text = "formHistoriaA";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private DataGridView dataGridViewExpensas;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private ComboBox comboBoxEdificios;
        private Label label1;
    }
}