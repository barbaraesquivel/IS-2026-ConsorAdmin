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
            label1 = new Label();
            comboBoxEdificios = new ComboBox();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            dataGridViewExpensas = new DataGridView();
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
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(779, 796);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 63);
            label1.Name = "label1";
            label1.Size = new Size(170, 18);
            label1.TabIndex = 0;
            label1.Text = "Buscar por codigo:";
            // 
            // comboBoxEdificios
            // 
            comboBoxEdificios.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificios.ForeColor = SystemColors.ControlLight;
            comboBoxEdificios.FormattingEnabled = true;
            comboBoxEdificios.Location = new Point(59, 85);
            comboBoxEdificios.Margin = new Padding(3, 4, 3, 4);
            comboBoxEdificios.Name = "comboBoxEdificios";
            comboBoxEdificios.Size = new Size(301, 26);
            comboBoxEdificios.TabIndex = 11;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Anchor = AnchorStyles.None;
            buttonBuscar.BackColor = Color.Transparent;
            buttonBuscar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonBuscar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonBuscar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonBuscar.FlatStyle = FlatStyle.Flat;
            buttonBuscar.ForeColor = SystemColors.ControlLight;
            buttonBuscar.Location = new Point(577, 84);
            buttonBuscar.Margin = new Padding(3, 4, 3, 4);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(138, 26);
            buttonBuscar.TabIndex = 35;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Anchor = AnchorStyles.None;
            buttonLimpiar.BackColor = Color.Transparent;
            buttonLimpiar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonLimpiar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonLimpiar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonLimpiar.FlatStyle = FlatStyle.Flat;
            buttonLimpiar.ForeColor = SystemColors.ControlLight;
            buttonLimpiar.Location = new Point(406, 85);
            buttonLimpiar.Margin = new Padding(3, 4, 3, 4);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(138, 26);
            buttonLimpiar.TabIndex = 36;
            buttonLimpiar.Text = "Limpiar Vista";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewExpensas
            // 
            dataGridViewExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExpensas.Location = new Point(60, 138);
            dataGridViewExpensas.Name = "dataGridViewExpensas";
            dataGridViewExpensas.RowHeadersWidth = 51;
            dataGridViewExpensas.Size = new Size(655, 630);
            dataGridViewExpensas.TabIndex = 37;
            // 
            // FormHistorialG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(779, 796);
            Controls.Add(groupBox2);
            Name = "FormHistorialG";
            Text = "FormHistorialG";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label1;
        private ComboBox comboBoxEdificios;
        private Button buttonLimpiar;
        private Button buttonBuscar;
        private DataGridView dataGridViewExpensas;
    }
}