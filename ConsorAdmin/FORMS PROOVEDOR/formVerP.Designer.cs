namespace ConsorAdmin.FORMS_PROOVEDOR
{
    partial class formVerP
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
            buttonEditar = new Button();
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
            groupBox2.Controls.Add(buttonEditar);
            groupBox2.Controls.Add(groupBoxExpensas);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(682, 597);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            // 
            // buttonEditar
            // 
            buttonEditar.Anchor = AnchorStyles.None;
            buttonEditar.BackColor = Color.FromArgb(39, 133, 243);
            buttonEditar.FlatAppearance.BorderSize = 0;
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 105, 193);
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 105, 193);
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.ForeColor = SystemColors.ControlLight;
            buttonEditar.Location = new Point(42, 465);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(591, 36);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar Expensa Seleccionada";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // groupBoxExpensas
            // 
            groupBoxExpensas.Anchor = AnchorStyles.None;
            groupBoxExpensas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxExpensas.Controls.Add(dataGridExpensas);
            groupBoxExpensas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxExpensas.ForeColor = SystemColors.ControlLight;
            groupBoxExpensas.Location = new Point(12, 51);
            groupBoxExpensas.Name = "groupBoxExpensas";
            groupBoxExpensas.Size = new Size(655, 408);
            groupBoxExpensas.TabIndex = 5;
            groupBoxExpensas.TabStop = false;
            // 
            // dataGridExpensas
            // 
            dataGridExpensas.Anchor = AnchorStyles.None;
            dataGridExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExpensas.Location = new Point(30, 13);
            dataGridExpensas.Name = "dataGridExpensas";
            dataGridExpensas.Size = new Size(591, 389);
            dataGridExpensas.TabIndex = 0;
            // 
            // formVerP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBox2);
            Name = "formVerP";
            Text = "formVerP";
            groupBox2.ResumeLayout(false);
            groupBoxExpensas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button buttonEditar;
        private GroupBox groupBoxExpensas;
        private DataGridView dataGridExpensas;
    }
}