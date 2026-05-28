namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formEdificiosPorGestorA
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
            groupBoxEliminar = new GroupBox();
            comboBoxGestor = new ComboBox();
            label1 = new Label();
            buttonVerEdificios = new Button();
            groupBoxEdificios = new GroupBox();
            dataGridEdificios = new DataGridView();
            groupBoxEliminar.SuspendLayout();
            groupBoxEdificios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEliminar
            // 
            groupBoxEliminar.Anchor = AnchorStyles.None;
            groupBoxEliminar.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEliminar.Controls.Add(comboBoxGestor);
            groupBoxEliminar.Controls.Add(label1);
            groupBoxEliminar.Controls.Add(buttonVerEdificios);
            groupBoxEliminar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEliminar.ForeColor = SystemColors.ControlLight;
            groupBoxEliminar.Location = new Point(15, 12);
            groupBoxEliminar.Name = "groupBoxEliminar";
            groupBoxEliminar.Size = new Size(655, 80);
            groupBoxEliminar.TabIndex = 8;
            groupBoxEliminar.TabStop = false;
            groupBoxEliminar.Text = "Ver Edificios por Gestor";
            // 
            // comboBoxGestor
            // 
            comboBoxGestor.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxGestor.ForeColor = SystemColors.ControlLight;
            comboBoxGestor.FormattingEnabled = true;
            comboBoxGestor.Location = new Point(119, 21);
            comboBoxGestor.Name = "comboBoxGestor";
            comboBoxGestor.Size = new Size(177, 22);
            comboBoxGestor.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 42;
            label1.Text = "Gestor:";
            // 
            // buttonVerEdificios
            // 
            buttonVerEdificios.Anchor = AnchorStyles.None;
            buttonVerEdificios.BackColor = Color.FromArgb(0, 187, 118);
            buttonVerEdificios.FlatAppearance.BorderSize = 0;
            buttonVerEdificios.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonVerEdificios.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonVerEdificios.FlatStyle = FlatStyle.Flat;
            buttonVerEdificios.ForeColor = SystemColors.ControlLight;
            buttonVerEdificios.Location = new Point(92, 48);
            buttonVerEdificios.Name = "buttonVerEdificios";
            buttonVerEdificios.Size = new Size(481, 26);
            buttonVerEdificios.TabIndex = 41;
            buttonVerEdificios.Text = "Buscar Edificios";
            buttonVerEdificios.UseVisualStyleBackColor = false;
            // 
            // groupBoxEdificios
            // 
            groupBoxEdificios.Anchor = AnchorStyles.None;
            groupBoxEdificios.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificios.Controls.Add(dataGridEdificios);
            groupBoxEdificios.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificios.ForeColor = SystemColors.ControlLight;
            groupBoxEdificios.Location = new Point(15, 116);
            groupBoxEdificios.Name = "groupBoxEdificios";
            groupBoxEdificios.Size = new Size(655, 469);
            groupBoxEdificios.TabIndex = 9;
            groupBoxEdificios.TabStop = false;
            groupBoxEdificios.Text = "MIS EDIFICIOS";
            // 
            // dataGridEdificios
            // 
            dataGridEdificios.Anchor = AnchorStyles.None;
            dataGridEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridEdificios.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridEdificios.Location = new Point(7, 21);
            dataGridEdificios.Name = "dataGridEdificios";
            dataGridEdificios.RowHeadersWidth = 51;
            dataGridEdificios.Size = new Size(642, 432);
            dataGridEdificios.TabIndex = 0;
            // 
            // formEdificiosPorGestorA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBoxEdificios);
            Controls.Add(groupBoxEliminar);
            Name = "formEdificiosPorGestorA";
            Text = "formAsignarGestorA";
            groupBoxEliminar.ResumeLayout(false);
            groupBoxEliminar.PerformLayout();
            groupBoxEdificios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridEdificios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEliminar;
        private ComboBox comboBoxGestor;
        private Label label1;
        private Button buttonVerEdificios;
        private GroupBox groupBoxEdificios;
        private DataGridView dataGridEdificios;
    }
}