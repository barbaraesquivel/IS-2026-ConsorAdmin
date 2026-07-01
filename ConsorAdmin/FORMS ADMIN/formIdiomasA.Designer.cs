namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formIdiomasA
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
            labelGestiondeIdiomas_FormIdiomasA = new Label();
            cboIdiomas = new ComboBox();
            labelIdioma_FormIdiomasA = new Label();
            buttonAgregarIdioma_FormIdiomasA = new Button();
            btnGuardarTraducciones_FormIdiomasA = new Button();
            btnAplicarIdioma_FormIdiomasA = new Button();
            btnCancelar_FormIdiomasA = new Button();
            dgvTraducciones = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colOriginal = new DataGridViewTextBoxColumn();
            colTraduccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvTraducciones).BeginInit();
            SuspendLayout();
            //
            // labelGestiondeIdiomas_FormIdiomasA
            //
            labelGestiondeIdiomas_FormIdiomasA.AutoSize = true;
            labelGestiondeIdiomas_FormIdiomasA.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGestiondeIdiomas_FormIdiomasA.ForeColor = SystemColors.ControlLight;
            labelGestiondeIdiomas_FormIdiomasA.Location = new Point(79, 20);
            labelGestiondeIdiomas_FormIdiomasA.Name = "labelGestiondeIdiomas_FormIdiomasA";
            labelGestiondeIdiomas_FormIdiomasA.Size = new Size(189, 19);
            labelGestiondeIdiomas_FormIdiomasA.TabIndex = 0;
            labelGestiondeIdiomas_FormIdiomasA.Text = "Gestion de Idiomas";
            //
            // cboIdiomas
            //
            cboIdiomas.FormattingEnabled = true;
            cboIdiomas.Location = new Point(120, 57);
            cboIdiomas.Name = "cboIdiomas";
            cboIdiomas.Size = new Size(180, 23);
            cboIdiomas.TabIndex = 1;
            cboIdiomas.SelectedIndexChanged += cboIdiomas_SelectedIndexChanged;
            //
            // labelIdioma_FormIdiomasA
            //
            labelIdioma_FormIdiomasA.AutoSize = true;
            labelIdioma_FormIdiomasA.Font = new Font("Unispace", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdioma_FormIdiomasA.ForeColor = SystemColors.ControlLight;
            labelIdioma_FormIdiomasA.Location = new Point(30, 61);
            labelIdioma_FormIdiomasA.Name = "labelIdioma_FormIdiomasA";
            labelIdioma_FormIdiomasA.Size = new Size(49, 14);
            labelIdioma_FormIdiomasA.TabIndex = 2;
            labelIdioma_FormIdiomasA.Text = "Idioma";
            //
            // buttonAgregarIdioma_FormIdiomasA
            //
            buttonAgregarIdioma_FormIdiomasA.Location = new Point(330, 57);
            buttonAgregarIdioma_FormIdiomasA.Name = "buttonAgregarIdioma_FormIdiomasA";
            buttonAgregarIdioma_FormIdiomasA.Size = new Size(150, 23);
            buttonAgregarIdioma_FormIdiomasA.TabIndex = 3;
            buttonAgregarIdioma_FormIdiomasA.Text = "+ Agregar Idioma";
            buttonAgregarIdioma_FormIdiomasA.UseVisualStyleBackColor = true;
            buttonAgregarIdioma_FormIdiomasA.Click += btnAgregarIdioma_Click;
            //
            // dgvTraducciones
            //
            dgvTraducciones.AllowUserToAddRows = false;
            dgvTraducciones.AllowUserToDeleteRows = false;
            dgvTraducciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTraducciones.Columns.AddRange(new DataGridViewColumn[] { colClave, colOriginal, colTraduccion });
            dgvTraducciones.Location = new Point(30, 100);
            dgvTraducciones.Name = "dgvTraducciones";
            dgvTraducciones.RowHeadersWidth = 51;
            dgvTraducciones.Size = new Size(620, 420);
            dgvTraducciones.TabIndex = 4;
            //
            // colClave
            //
            colClave.HeaderText = "Clave";
            colClave.Name = "colClave";
            colClave.Visible = false;
            //
            // colOriginal
            //
            colOriginal.HeaderText = "Original";
            colOriginal.Name = "colOriginal";
            colOriginal.ReadOnly = true;
            colOriginal.Width = 280;
            //
            // colTraduccion
            //
            colTraduccion.HeaderText = "Traduccion";
            colTraduccion.Name = "colTraduccion";
            colTraduccion.Width = 280;
            //
            // btnGuardarTraducciones_FormIdiomasA
            //
            btnGuardarTraducciones_FormIdiomasA.Location = new Point(30, 530);
            btnGuardarTraducciones_FormIdiomasA.Name = "btnGuardarTraducciones_FormIdiomasA";
            btnGuardarTraducciones_FormIdiomasA.Size = new Size(180, 47);
            btnGuardarTraducciones_FormIdiomasA.TabIndex = 5;
            btnGuardarTraducciones_FormIdiomasA.Text = "🖫 Guardar Traduccion";
            btnGuardarTraducciones_FormIdiomasA.UseVisualStyleBackColor = true;
            btnGuardarTraducciones_FormIdiomasA.Click += btnGuardarTraducciones_Click;
            //
            // btnAplicarIdioma_FormIdiomasA
            //
            btnAplicarIdioma_FormIdiomasA.Location = new Point(230, 530);
            btnAplicarIdioma_FormIdiomasA.Name = "btnAplicarIdioma_FormIdiomasA";
            btnAplicarIdioma_FormIdiomasA.Size = new Size(180, 47);
            btnAplicarIdioma_FormIdiomasA.TabIndex = 6;
            btnAplicarIdioma_FormIdiomasA.Text = "Aplicar Idioma";
            btnAplicarIdioma_FormIdiomasA.UseVisualStyleBackColor = true;
            btnAplicarIdioma_FormIdiomasA.Click += btnAplicarIdioma_Click;
            //
            // btnCancelar_FormIdiomasA
            //
            btnCancelar_FormIdiomasA.Location = new Point(430, 530);
            btnCancelar_FormIdiomasA.Name = "btnCancelar_FormIdiomasA";
            btnCancelar_FormIdiomasA.Size = new Size(180, 47);
            btnCancelar_FormIdiomasA.TabIndex = 7;
            btnCancelar_FormIdiomasA.Text = "Cancelar";
            btnCancelar_FormIdiomasA.UseVisualStyleBackColor = true;
            btnCancelar_FormIdiomasA.Click += btnCancelar_Click;
            //
            // formIdiomasA
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(682, 597);
            Controls.Add(btnCancelar_FormIdiomasA);
            Controls.Add(btnAplicarIdioma_FormIdiomasA);
            Controls.Add(btnGuardarTraducciones_FormIdiomasA);
            Controls.Add(dgvTraducciones);
            Controls.Add(buttonAgregarIdioma_FormIdiomasA);
            Controls.Add(labelIdioma_FormIdiomasA);
            Controls.Add(cboIdiomas);
            Controls.Add(labelGestiondeIdiomas_FormIdiomasA);
            Name = "formIdiomasA";
            Text = "formIdiomasA";
            FormClosing += formIdiomasA_FormClosing;
            Load += formIdiomasA_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTraducciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGestiondeIdiomas_FormIdiomasA;
        private ComboBox cboIdiomas;
        private Label labelIdioma_FormIdiomasA;
        private Button buttonAgregarIdioma_FormIdiomasA;
        private Button btnGuardarTraducciones_FormIdiomasA;
        private Button btnAplicarIdioma_FormIdiomasA;
        private Button btnCancelar_FormIdiomasA;
        private DataGridView dgvTraducciones;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colOriginal;
        private DataGridViewTextBoxColumn colTraduccion;
    }
}
