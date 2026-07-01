namespace ConsorAdmin
{
    partial class formExpC
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
            buttonGuardar_FormExpC = new Button();
            buttonImprimir_FormExpC = new Button();
            groupBoxExpensas = new GroupBox();
            dataGridExpensas = new DataGridView();
            groupBox2.SuspendLayout();
            groupBoxExpensas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(buttonGuardar_FormExpC);
            groupBox2.Controls.Add(buttonImprimir_FormExpC);
            groupBox2.Controls.Add(groupBoxExpensas);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // buttonGuardar_FormExpC
            // 
            buttonGuardar_FormExpC.Anchor = AnchorStyles.None;
            buttonGuardar_FormExpC.BackColor = Color.Transparent;
            buttonGuardar_FormExpC.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonGuardar_FormExpC.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonGuardar_FormExpC.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonGuardar_FormExpC.FlatStyle = FlatStyle.Flat;
            buttonGuardar_FormExpC.ForeColor = SystemColors.ControlLight;
            buttonGuardar_FormExpC.Location = new Point(276, 421);
            buttonGuardar_FormExpC.Name = "buttonGuardar_FormExpC";
            buttonGuardar_FormExpC.Size = new Size(202, 36);
            buttonGuardar_FormExpC.TabIndex = 15;
            buttonGuardar_FormExpC.Text = "Guardar en PDF";
            buttonGuardar_FormExpC.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir_FormExpC
            // 
            buttonImprimir_FormExpC.Anchor = AnchorStyles.None;
            buttonImprimir_FormExpC.BackColor = Color.FromArgb(39, 133, 243);
            buttonImprimir_FormExpC.FlatAppearance.BorderSize = 0;
            buttonImprimir_FormExpC.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir_FormExpC.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir_FormExpC.FlatStyle = FlatStyle.Flat;
            buttonImprimir_FormExpC.ForeColor = SystemColors.ControlLight;
            buttonImprimir_FormExpC.Location = new Point(44, 421);
            buttonImprimir_FormExpC.Name = "buttonImprimir_FormExpC";
            buttonImprimir_FormExpC.Size = new Size(202, 36);
            buttonImprimir_FormExpC.TabIndex = 14;
            buttonImprimir_FormExpC.Text = "Imprimir Expensa Seleccionada(s)";
            buttonImprimir_FormExpC.UseVisualStyleBackColor = false;
            // 
            // groupBoxExpensas
            // 
            groupBoxExpensas.Anchor = AnchorStyles.None;
            groupBoxExpensas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxExpensas.Controls.Add(dataGridExpensas);
            groupBoxExpensas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxExpensas.ForeColor = SystemColors.ControlLight;
            groupBoxExpensas.Location = new Point(14, 95);
            groupBoxExpensas.Name = "groupBoxExpensas";
            groupBoxExpensas.Size = new Size(655, 303);
            groupBoxExpensas.TabIndex = 5;
            groupBoxExpensas.TabStop = false;
            // 
            // dataGridExpensas
            // 
            dataGridExpensas.Anchor = AnchorStyles.None;
            dataGridExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExpensas.Location = new Point(30, 16);
            dataGridExpensas.Name = "dataGridExpensas";
            dataGridExpensas.Size = new Size(591, 276);
            dataGridExpensas.TabIndex = 0;
            // 
            // formExpC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formExpC";
            Text = "formExpC";
            FormClosing += formExpC_FormClosing;
            Load += formExpC_Load;
            groupBox2.ResumeLayout(false);
            groupBoxExpensas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxExpensas;
        private DataGridView dataGridExpensas;
        private Button buttonImprimir_FormExpC;
        private Button buttonGuardar_FormExpC;
    }
}