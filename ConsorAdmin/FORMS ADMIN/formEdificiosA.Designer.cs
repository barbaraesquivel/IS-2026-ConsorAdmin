namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formEdificiosA
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
            groupBoxEdificios_FormEdificiosA = new GroupBox();
            dataGridViewEdificios = new DataGridView();
            groupBoxEdificios_FormEdificiosA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEdificios_FormEdificiosA
            // 
            groupBoxEdificios_FormEdificiosA.Anchor = AnchorStyles.None;
            groupBoxEdificios_FormEdificiosA.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEdificios_FormEdificiosA.Controls.Add(dataGridViewEdificios);
            groupBoxEdificios_FormEdificiosA.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxEdificios_FormEdificiosA.ForeColor = SystemColors.ControlLight;
            groupBoxEdificios_FormEdificiosA.Location = new Point(36, 24);
            groupBoxEdificios_FormEdificiosA.Name = "groupBoxEdificios_FormEdificiosA";
            groupBoxEdificios_FormEdificiosA.Size = new Size(601, 551);
            groupBoxEdificios_FormEdificiosA.TabIndex = 22;
            groupBoxEdificios_FormEdificiosA.TabStop = false;
            groupBoxEdificios_FormEdificiosA.Text = "EDIFICIOS";
            // 
            // dataGridViewEdificios
            // 
            dataGridViewEdificios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEdificios.Location = new Point(7, 21);
            dataGridViewEdificios.Name = "dataGridViewEdificios";
            dataGridViewEdificios.Size = new Size(587, 513);
            dataGridViewEdificios.TabIndex = 0;
            // 
            // formEdificiosA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(groupBoxEdificios_FormEdificiosA);
            Name = "formEdificiosA";
            Text = "formEdificiosA";
            FormClosing += formEdificiosA_FormClosing;
            Load += formEdificiosA_Load;
            groupBoxEdificios_FormEdificiosA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEdificios_FormEdificiosA;
        private DataGridView dataGridViewEdificios;
    }
}