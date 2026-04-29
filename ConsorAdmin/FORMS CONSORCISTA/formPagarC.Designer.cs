namespace ConsorAdmin
{
    partial class formPagarC
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
            groupBoxExpensas = new GroupBox();
            dataGridExpensas = new DataGridView();
            groupBoxPago = new GroupBox();
            buttonPagar = new Button();
            textBoxReferencia = new TextBox();
            label2 = new Label();
            comboBoxMedio = new ComboBox();
            label1 = new Label();
            groupBoxSelected = new GroupBox();
            labelInfoExpensa = new Label();
            labelExpensaTot = new Label();
            groupBox2 = new GroupBox();
            groupBoxExpensas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).BeginInit();
            groupBoxPago.SuspendLayout();
            groupBoxSelected.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxExpensas
            // 
            groupBoxExpensas.Anchor = AnchorStyles.None;
            groupBoxExpensas.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxExpensas.Controls.Add(dataGridExpensas);
            groupBoxExpensas.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxExpensas.ForeColor = SystemColors.ControlLight;
            groupBoxExpensas.Location = new Point(23, 118);
            groupBoxExpensas.Name = "groupBoxExpensas";
            groupBoxExpensas.Size = new Size(264, 303);
            groupBoxExpensas.TabIndex = 4;
            groupBoxExpensas.TabStop = false;
            groupBoxExpensas.Text = "SELECCIONAR EXPENSA";
            // 
            // dataGridExpensas
            // 
            dataGridExpensas.Anchor = AnchorStyles.None;
            dataGridExpensas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridExpensas.Location = new Point(8, 21);
            dataGridExpensas.Name = "dataGridExpensas";
            dataGridExpensas.Size = new Size(249, 276);
            dataGridExpensas.TabIndex = 0;
            // 
            // groupBoxPago
            // 
            groupBoxPago.Anchor = AnchorStyles.None;
            groupBoxPago.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxPago.Controls.Add(buttonPagar);
            groupBoxPago.Controls.Add(textBoxReferencia);
            groupBoxPago.Controls.Add(label2);
            groupBoxPago.Controls.Add(comboBoxMedio);
            groupBoxPago.Controls.Add(label1);
            groupBoxPago.Controls.Add(groupBoxSelected);
            groupBoxPago.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxPago.ForeColor = SystemColors.ControlLight;
            groupBoxPago.Location = new Point(308, 118);
            groupBoxPago.Name = "groupBoxPago";
            groupBoxPago.Size = new Size(350, 303);
            groupBoxPago.TabIndex = 5;
            groupBoxPago.TabStop = false;
            groupBoxPago.Text = "DETALLE DEL PAGO";
            // 
            // buttonPagar
            // 
            buttonPagar.Anchor = AnchorStyles.None;
            buttonPagar.BackColor = Color.FromArgb(0, 187, 118);
            buttonPagar.FlatAppearance.BorderSize = 0;
            buttonPagar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonPagar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonPagar.FlatStyle = FlatStyle.Flat;
            buttonPagar.ForeColor = SystemColors.ControlLight;
            buttonPagar.Location = new Point(6, 246);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(338, 36);
            buttonPagar.TabIndex = 13;
            buttonPagar.Text = "Confirmar Pago";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // textBoxReferencia
            // 
            textBoxReferencia.BackColor = Color.FromArgb(13, 22, 40);
            textBoxReferencia.ForeColor = SystemColors.ControlLight;
            textBoxReferencia.Location = new Point(16, 204);
            textBoxReferencia.Name = "textBoxReferencia";
            textBoxReferencia.Size = new Size(221, 22);
            textBoxReferencia.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 177);
            label2.Name = "label2";
            label2.Size = new Size(98, 14);
            label2.TabIndex = 11;
            label2.Text = "N° REFERENCIA";
            // 
            // comboBoxMedio
            // 
            comboBoxMedio.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxMedio.ForeColor = SystemColors.ControlLight;
            comboBoxMedio.FormattingEnabled = true;
            comboBoxMedio.Location = new Point(16, 130);
            comboBoxMedio.Name = "comboBoxMedio";
            comboBoxMedio.Size = new Size(221, 22);
            comboBoxMedio.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 113);
            label1.Name = "label1";
            label1.Size = new Size(98, 14);
            label1.TabIndex = 9;
            label1.Text = "MEDIO DE PAGO";
            // 
            // groupBoxSelected
            // 
            groupBoxSelected.Anchor = AnchorStyles.None;
            groupBoxSelected.BackColor = Color.FromArgb(13, 22, 40);
            groupBoxSelected.Controls.Add(labelInfoExpensa);
            groupBoxSelected.Controls.Add(labelExpensaTot);
            groupBoxSelected.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxSelected.ForeColor = SystemColors.ControlLight;
            groupBoxSelected.Location = new Point(6, 21);
            groupBoxSelected.Name = "groupBoxSelected";
            groupBoxSelected.Size = new Size(338, 74);
            groupBoxSelected.TabIndex = 8;
            groupBoxSelected.TabStop = false;
            groupBoxSelected.Text = "EXPENSA SELECCIONADA";
            // 
            // labelInfoExpensa
            // 
            labelInfoExpensa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelInfoExpensa.AutoSize = true;
            labelInfoExpensa.Font = new Font("Unispace", 6.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoExpensa.Location = new Point(10, 47);
            labelInfoExpensa.Name = "labelInfoExpensa";
            labelInfoExpensa.Size = new Size(221, 11);
            labelInfoExpensa.TabIndex = 3;
            labelInfoExpensa.Text = "Expensa Ene 2025 - Vencio 10/01/2025";
            // 
            // labelExpensaTot
            // 
            labelExpensaTot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelExpensaTot.AutoSize = true;
            labelExpensaTot.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExpensaTot.Location = new Point(7, 21);
            labelExpensaTot.Name = "labelExpensaTot";
            labelExpensaTot.Size = new Size(139, 19);
            labelExpensaTot.TabIndex = 2;
            labelExpensaTot.Text = "$000000000.00";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(7, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(667, 476);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            // 
            // formPagarC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBoxPago);
            Controls.Add(groupBoxExpensas);
            Controls.Add(groupBox2);
            Name = "formPagarC";
            Text = "formPagarC";
            groupBoxExpensas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridExpensas).EndInit();
            groupBoxPago.ResumeLayout(false);
            groupBoxPago.PerformLayout();
            groupBoxSelected.ResumeLayout(false);
            groupBoxSelected.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxExpensas;
        private DataGridView dataGridExpensas;
        private GroupBox groupBoxPago;
        private GroupBox groupBoxSelected;
        private TextBox textBoxReferencia;
        private Label label2;
        private ComboBox comboBoxMedio;
        private Label label1;
        private Button buttonPagar;
        private GroupBox groupBox2;
        private Label labelInfoExpensa;
        private Label labelExpensaTot;
    }
}