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
            groupBox1 = new GroupBox();
            dataGridViewEdificios = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(dataGridViewEdificios);
            groupBox1.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(36, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(601, 551);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "EDIFICIOS";
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
            Controls.Add(groupBox1);
            Name = "formEdificiosA";
            Text = "formEdificiosA";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdificios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridViewEdificios;
    }
}