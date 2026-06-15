namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formPermisosA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxFamilia = new GroupBox();
            labelCodigo = new Label();
            textBoxCodigo = new TextBox();
            labelNombre = new Label();
            textBoxNombre = new TextBox();
            buttonCrearFamilia = new Button();
            groupBoxAsignar = new GroupBox();
            labelFamilia = new Label();
            comboBoxFamilias = new ComboBox();
            labelPatente = new Label();
            comboBoxPatentes = new ComboBox();
            buttonAgregar = new Button();
            groupBoxFamiliaEnFamilia = new GroupBox();
            labelContenedor = new Label();
            comboBoxContenedor = new ComboBox();
            labelFamiliaAgregar = new Label();
            comboBoxFamiliaAgregar = new ComboBox();
            buttonAgregarFamilia = new Button();
            labelArbol = new Label();
            treeViewPermisos = new TreeView();
            groupBoxFamilia.SuspendLayout();
            groupBoxAsignar.SuspendLayout();
            groupBoxFamiliaEnFamilia.SuspendLayout();
            SuspendLayout();
            //
            // groupBoxFamilia
            //
            groupBoxFamilia.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxFamilia.Controls.Add(buttonCrearFamilia);
            groupBoxFamilia.Controls.Add(textBoxNombre);
            groupBoxFamilia.Controls.Add(labelNombre);
            groupBoxFamilia.Controls.Add(textBoxCodigo);
            groupBoxFamilia.Controls.Add(labelCodigo);
            groupBoxFamilia.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxFamilia.ForeColor = SystemColors.ControlLight;
            groupBoxFamilia.Location = new Point(12, 12);
            groupBoxFamilia.Name = "groupBoxFamilia";
            groupBoxFamilia.Size = new Size(295, 130);
            groupBoxFamilia.TabIndex = 0;
            groupBoxFamilia.TabStop = false;
            groupBoxFamilia.Text = "Nueva Familia";
            //
            // labelCodigo
            //
            labelCodigo.AutoSize = true;
            labelCodigo.ForeColor = SystemColors.ControlLight;
            labelCodigo.Location = new Point(8, 30);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(56, 14);
            labelCodigo.TabIndex = 0;
            labelCodigo.Text = "Código:";
            //
            // textBoxCodigo
            //
            textBoxCodigo.BackColor = Color.FromArgb(13, 22, 40);
            textBoxCodigo.ForeColor = SystemColors.ControlLight;
            textBoxCodigo.Location = new Point(80, 27);
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(200, 22);
            textBoxCodigo.TabIndex = 1;
            //
            // labelNombre
            //
            labelNombre.AutoSize = true;
            labelNombre.ForeColor = SystemColors.ControlLight;
            labelNombre.Location = new Point(8, 60);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(56, 14);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre:";
            //
            // textBoxNombre
            //
            textBoxNombre.BackColor = Color.FromArgb(13, 22, 40);
            textBoxNombre.ForeColor = SystemColors.ControlLight;
            textBoxNombre.Location = new Point(80, 57);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(200, 22);
            textBoxNombre.TabIndex = 3;
            //
            // buttonCrearFamilia
            //
            buttonCrearFamilia.BackColor = Color.FromArgb(0, 187, 118);
            buttonCrearFamilia.FlatAppearance.BorderSize = 0;
            buttonCrearFamilia.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonCrearFamilia.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonCrearFamilia.FlatStyle = FlatStyle.Flat;
            buttonCrearFamilia.ForeColor = SystemColors.ControlLight;
            buttonCrearFamilia.Location = new Point(8, 90);
            buttonCrearFamilia.Name = "buttonCrearFamilia";
            buttonCrearFamilia.Size = new Size(272, 28);
            buttonCrearFamilia.TabIndex = 4;
            buttonCrearFamilia.Text = "Crear Familia";
            buttonCrearFamilia.UseVisualStyleBackColor = false;
            buttonCrearFamilia.Click += buttonCrearFamilia_Click;
            //
            // groupBoxAsignar
            //
            groupBoxAsignar.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxAsignar.Controls.Add(buttonAgregar);
            groupBoxAsignar.Controls.Add(comboBoxPatentes);
            groupBoxAsignar.Controls.Add(labelPatente);
            groupBoxAsignar.Controls.Add(comboBoxFamilias);
            groupBoxAsignar.Controls.Add(labelFamilia);
            groupBoxAsignar.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxAsignar.ForeColor = SystemColors.ControlLight;
            groupBoxAsignar.Location = new Point(12, 158);
            groupBoxAsignar.Name = "groupBoxAsignar";
            groupBoxAsignar.Size = new Size(295, 130);
            groupBoxAsignar.TabIndex = 1;
            groupBoxAsignar.TabStop = false;
            groupBoxAsignar.Text = "Asignar Patente a Familia";
            //
            // labelFamilia
            //
            labelFamilia.AutoSize = true;
            labelFamilia.ForeColor = SystemColors.ControlLight;
            labelFamilia.Location = new Point(8, 30);
            labelFamilia.Name = "labelFamilia";
            labelFamilia.Size = new Size(56, 14);
            labelFamilia.TabIndex = 0;
            labelFamilia.Text = "Familia:";
            //
            // comboBoxFamilias
            //
            comboBoxFamilias.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxFamilias.ForeColor = SystemColors.ControlLight;
            comboBoxFamilias.FormattingEnabled = true;
            comboBoxFamilias.Location = new Point(80, 27);
            comboBoxFamilias.Name = "comboBoxFamilias";
            comboBoxFamilias.Size = new Size(200, 22);
            comboBoxFamilias.TabIndex = 1;
            //
            // labelPatente
            //
            labelPatente.AutoSize = true;
            labelPatente.ForeColor = SystemColors.ControlLight;
            labelPatente.Location = new Point(8, 60);
            labelPatente.Name = "labelPatente";
            labelPatente.Size = new Size(60, 14);
            labelPatente.TabIndex = 2;
            labelPatente.Text = "Patente:";
            //
            // comboBoxPatentes
            //
            comboBoxPatentes.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxPatentes.ForeColor = SystemColors.ControlLight;
            comboBoxPatentes.FormattingEnabled = true;
            comboBoxPatentes.Location = new Point(80, 57);
            comboBoxPatentes.Name = "comboBoxPatentes";
            comboBoxPatentes.Size = new Size(200, 22);
            comboBoxPatentes.TabIndex = 3;
            //
            // buttonAgregar
            //
            buttonAgregar.BackColor = Color.FromArgb(0, 187, 118);
            buttonAgregar.FlatAppearance.BorderSize = 0;
            buttonAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonAgregar.FlatStyle = FlatStyle.Flat;
            buttonAgregar.ForeColor = SystemColors.ControlLight;
            buttonAgregar.Location = new Point(8, 90);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(272, 28);
            buttonAgregar.TabIndex = 4;
            buttonAgregar.Text = "Agregar a familia";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            //
            // groupBoxFamiliaEnFamilia
            //
            groupBoxFamiliaEnFamilia.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxFamiliaEnFamilia.Controls.Add(buttonAgregarFamilia);
            groupBoxFamiliaEnFamilia.Controls.Add(comboBoxFamiliaAgregar);
            groupBoxFamiliaEnFamilia.Controls.Add(labelFamiliaAgregar);
            groupBoxFamiliaEnFamilia.Controls.Add(comboBoxContenedor);
            groupBoxFamiliaEnFamilia.Controls.Add(labelContenedor);
            groupBoxFamiliaEnFamilia.Font = new Font("Unispace", 9F, FontStyle.Bold);
            groupBoxFamiliaEnFamilia.ForeColor = SystemColors.ControlLight;
            groupBoxFamiliaEnFamilia.Location = new Point(12, 304);
            groupBoxFamiliaEnFamilia.Name = "groupBoxFamiliaEnFamilia";
            groupBoxFamiliaEnFamilia.Size = new Size(295, 130);
            groupBoxFamiliaEnFamilia.TabIndex = 2;
            groupBoxFamiliaEnFamilia.TabStop = false;
            groupBoxFamiliaEnFamilia.Text = "Agregar Familia a Familia";
            //
            // labelContenedor
            //
            labelContenedor.AutoSize = true;
            labelContenedor.ForeColor = SystemColors.ControlLight;
            labelContenedor.Location = new Point(8, 30);
            labelContenedor.Name = "labelContenedor";
            labelContenedor.Size = new Size(70, 14);
            labelContenedor.TabIndex = 0;
            labelContenedor.Text = "Contenedor:";
            //
            // comboBoxContenedor
            //
            comboBoxContenedor.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxContenedor.ForeColor = SystemColors.ControlLight;
            comboBoxContenedor.FormattingEnabled = true;
            comboBoxContenedor.Location = new Point(120, 27);
            comboBoxContenedor.Name = "comboBoxContenedor";
            comboBoxContenedor.Size = new Size(160, 22);
            comboBoxContenedor.TabIndex = 1;
            //
            // labelFamiliaAgregar
            //
            labelFamiliaAgregar.AutoSize = true;
            labelFamiliaAgregar.ForeColor = SystemColors.ControlLight;
            labelFamiliaAgregar.Location = new Point(8, 60);
            labelFamiliaAgregar.Name = "labelFamiliaAgregar";
            labelFamiliaAgregar.Size = new Size(74, 14);
            labelFamiliaAgregar.TabIndex = 2;
            labelFamiliaAgregar.Text = "A agregar:";
            //
            // comboBoxFamiliaAgregar
            //
            comboBoxFamiliaAgregar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxFamiliaAgregar.ForeColor = SystemColors.ControlLight;
            comboBoxFamiliaAgregar.FormattingEnabled = true;
            comboBoxFamiliaAgregar.Location = new Point(120, 57);
            comboBoxFamiliaAgregar.Name = "comboBoxFamiliaAgregar";
            comboBoxFamiliaAgregar.Size = new Size(160, 22);
            comboBoxFamiliaAgregar.TabIndex = 3;
            //
            // buttonAgregarFamilia
            //
            buttonAgregarFamilia.BackColor = Color.FromArgb(0, 187, 118);
            buttonAgregarFamilia.FlatAppearance.BorderSize = 0;
            buttonAgregarFamilia.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonAgregarFamilia.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonAgregarFamilia.FlatStyle = FlatStyle.Flat;
            buttonAgregarFamilia.ForeColor = SystemColors.ControlLight;
            buttonAgregarFamilia.Location = new Point(8, 90);
            buttonAgregarFamilia.Name = "buttonAgregarFamilia";
            buttonAgregarFamilia.Size = new Size(272, 28);
            buttonAgregarFamilia.TabIndex = 4;
            buttonAgregarFamilia.Text = "Agregar familia a familia";
            buttonAgregarFamilia.UseVisualStyleBackColor = false;
            buttonAgregarFamilia.Click += buttonAgregarFamilia_Click;
            //
            // labelArbol
            //
            labelArbol.AutoSize = true;
            labelArbol.Font = new Font("Unispace", 9F, FontStyle.Bold);
            labelArbol.ForeColor = SystemColors.ControlLight;
            labelArbol.Location = new Point(320, 12);
            labelArbol.Name = "labelArbol";
            labelArbol.Size = new Size(140, 14);
            labelArbol.TabIndex = 2;
            labelArbol.Text = "Árbol de permisos:";
            //
            // treeViewPermisos
            //
            treeViewPermisos.BackColor = Color.FromArgb(13, 22, 40);
            treeViewPermisos.ForeColor = SystemColors.ControlLight;
            treeViewPermisos.Location = new Point(320, 35);
            treeViewPermisos.Name = "treeViewPermisos";
            treeViewPermisos.Size = new Size(340, 440);
            treeViewPermisos.TabIndex = 3;
            //
            // formPermisosA
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 14, 26);
            ClientSize = new Size(672, 452);
            Controls.Add(treeViewPermisos);
            Controls.Add(labelArbol);
            Controls.Add(groupBoxFamiliaEnFamilia);
            Controls.Add(groupBoxAsignar);
            Controls.Add(groupBoxFamilia);
            Name = "formPermisosA";
            Text = "Gestión de Familias y Permisos";
            groupBoxFamilia.ResumeLayout(false);
            groupBoxFamilia.PerformLayout();
            groupBoxAsignar.ResumeLayout(false);
            groupBoxAsignar.PerformLayout();
            groupBoxFamiliaEnFamilia.ResumeLayout(false);
            groupBoxFamiliaEnFamilia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxFamilia;
        private Label labelCodigo;
        private TextBox textBoxCodigo;
        private Label labelNombre;
        private TextBox textBoxNombre;
        private Button buttonCrearFamilia;
        private GroupBox groupBoxAsignar;
        private Label labelFamilia;
        private ComboBox comboBoxFamilias;
        private Label labelPatente;
        private ComboBox comboBoxPatentes;
        private Button buttonAgregar;
        private GroupBox groupBoxFamiliaEnFamilia;
        private Label labelContenedor;
        private ComboBox comboBoxContenedor;
        private Label labelFamiliaAgregar;
        private ComboBox comboBoxFamiliaAgregar;
        private Button buttonAgregarFamilia;
        private Label labelArbol;
        private TreeView treeViewPermisos;
    }
}
