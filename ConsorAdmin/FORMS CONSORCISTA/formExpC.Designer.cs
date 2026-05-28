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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            groupBox2 = new GroupBox();
            buttonGuardar = new Button();
            buttonImprimir = new Button();
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
            groupBox2.Controls.Add(buttonGuardar);
            groupBox2.Controls.Add(buttonImprimir);
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
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.BackColor = Color.Transparent;
            buttonGuardar.FlatAppearance.BorderColor = Color.FromArgb(30, 58, 95);
            buttonGuardar.FlatAppearance.MouseDownBackColor = SystemColors.Highlight;
            buttonGuardar.FlatAppearance.MouseOverBackColor = SystemColors.Highlight;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = SystemColors.ControlLight;
            buttonGuardar.Location = new Point(276, 421);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(202, 36);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar en PDF";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonImprimir
            // 
            buttonImprimir.Anchor = AnchorStyles.None;
            buttonImprimir.BackColor = Color.FromArgb(39, 133, 243);
            buttonImprimir.FlatAppearance.BorderSize = 0;
            buttonImprimir.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 105, 193);
            buttonImprimir.FlatStyle = FlatStyle.Flat;
            buttonImprimir.ForeColor = SystemColors.ControlLight;
            buttonImprimir.Location = new Point(44, 421);
            buttonImprimir.Name = "buttonImprimir";
            buttonImprimir.Size = new Size(202, 36);
            buttonImprimir.TabIndex = 14;
            buttonImprimir.Text = "Imprimir Expensa Seleccionada(s)";
            buttonImprimir.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridExpensas.DefaultCellStyle = dataGridViewCellStyle1;
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
            groupBox2.ResumeLayout(false);
            groupBoxExpensas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBoxExpensas;
        private DataGridView dataGridExpensas;
        private Button buttonImprimir;
        private Button buttonGuardar;
    }
}