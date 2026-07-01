namespace ConsorAdmin.FORMS_GESTOR_CONSORCIOS
{
    partial class FormHistorialG
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
            buttonLimpiar_FormHistoG = new Button();
            buttonBuscar_FormHistoG = new Button();
            comboBoxEdificios = new ComboBox();
            labelBuscarPorNombre_FormHistoG = new Label();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpensas).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(dataGridViewExpensas);
            groupBox2.Controls.Add(buttonLimpiar_FormHistoG);
            groupBox2.Controls.Add(buttonBuscar_FormHistoG);
            groupBox2.Controls.Add(comboBoxEdificios);
            groupBox2.Controls.Add(labelBuscarPorNombre_FormHistoG);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 8;
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
            // buttonLimpiar_FormHistoG
            // 
            buttonLimpiar_FormHistoG.Anchor = AnchorStyles.Top;
            buttonLimpiar_FormHistoG.BackColor = Color.Transparent;
            buttonLimpiar_FormHistoG.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonLimpiar_FormHistoG.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonLimpiar_FormHistoG.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonLimpiar_FormHistoG.FlatStyle = FlatStyle.Flat;
            buttonLimpiar_FormHistoG.ForeColor = SystemColors.ControlLight;
            buttonLimpiar_FormHistoG.Location = new Point(352, 58);
            buttonLimpiar_FormHistoG.Name = "buttonLimpiar_FormHistoG";
            buttonLimpiar_FormHistoG.Size = new Size(123, 35);
            buttonLimpiar_FormHistoG.TabIndex = 36;
            buttonLimpiar_FormHistoG.Text = "Limpiar Vista";
            buttonLimpiar_FormHistoG.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar_FormHistoG
            // 
            buttonBuscar_FormHistoG.Anchor = AnchorStyles.Top;
            buttonBuscar_FormHistoG.BackColor = Color.Transparent;
            buttonBuscar_FormHistoG.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonBuscar_FormHistoG.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonBuscar_FormHistoG.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonBuscar_FormHistoG.FlatStyle = FlatStyle.Flat;
            buttonBuscar_FormHistoG.ForeColor = SystemColors.ControlLight;
            buttonBuscar_FormHistoG.Location = new Point(502, 57);
            buttonBuscar_FormHistoG.Name = "buttonBuscar_FormHistoG";
            buttonBuscar_FormHistoG.Size = new Size(123, 35);
            buttonBuscar_FormHistoG.TabIndex = 35;
            buttonBuscar_FormHistoG.Text = "Buscar";
            buttonBuscar_FormHistoG.UseVisualStyleBackColor = false;
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
            // labelBuscarPorNombre_FormHistoG
            // 
            labelBuscarPorNombre_FormHistoG.AutoSize = true;
            labelBuscarPorNombre_FormHistoG.Location = new Point(52, 47);
            labelBuscarPorNombre_FormHistoG.Name = "labelBuscarPorNombre_FormHistoG";
            labelBuscarPorNombre_FormHistoG.Size = new Size(224, 14);
            labelBuscarPorNombre_FormHistoG.TabIndex = 0;
            labelBuscarPorNombre_FormHistoG.Text = "Buscar por nombre de Consorcio:";
            // 
            // FormHistorialG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormHistorialG";
            Text = "FormHistorialG";
            Load += FormHistorialG_Load;
            FormClosing += FormHistorialG_FormClosing;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label labelBuscarPorNombre_FormHistoG;
        private ComboBox comboBoxEdificios;
        private Button buttonLimpiar_FormHistoG;
        private Button buttonBuscar_FormHistoG;
        private DataGridView dataGridViewExpensas;
    }
}