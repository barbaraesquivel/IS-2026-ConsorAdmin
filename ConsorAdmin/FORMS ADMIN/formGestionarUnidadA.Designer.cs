namespace ConsorAdmin.FORMS_ADMIN
{
    partial class formGestionarUnidadA
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
            groupBox3 = new GroupBox();
            label2 = new Label();
            buttonEliminar = new Button();
            label14 = new Label();
            label9 = new Label();
            dataGridUnidades = new DataGridView();
            comboBoxUnidadEliminar = new ComboBox();
            groupBox1 = new GroupBox();
            comboBoxConsorcista = new ComboBox();
            label8 = new Label();
            comboBoxGestoAgregar = new ComboBox();
            label7 = new Label();
            comboBoxTipoVinculo = new ComboBox();
            label15 = new Label();
            buttonGuardarUnidad = new Button();
            label13 = new Label();
            textBoxPisoAgregar = new TextBox();
            comboBoxEdificioAgregar = new ComboBox();
            label12 = new Label();
            label11 = new Label();
            textBoxDptoAgregar = new TextBox();
            label10 = new Label();
            textBoxSuperficieAgregar = new TextBox();
            groupBoxEstado = new GroupBox();
            comboBoxConsorcistaModificar = new ComboBox();
            label18 = new Label();
            comboBoxGestorModificar = new ComboBox();
            label19 = new Label();
            comboBoxTipoVinculoModificar = new ComboBox();
            label16 = new Label();
            comboBoxUnidadModificar = new ComboBox();
            textBoxPisoModificar = new TextBox();
            label1 = new Label();
            buttonGuardar = new Button();
            textBoxDptoModificar = new TextBox();
            textBoxSuperficieModificar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxEdificioModificar = new ComboBox();
            label6 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).BeginInit();
            groupBox1.SuspendLayout();
            groupBoxEstado.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(8, 14, 26);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(groupBoxEstado);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            groupBox2.ForeColor = SystemColors.ControlLight;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(824, 597);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(buttonEliminar);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(dataGridUnidades);
            groupBox3.Controls.Add(comboBoxUnidadEliminar);
            groupBox3.Location = new Point(0, 402);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(818, 195);
            groupBox3.TabIndex = 43;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Location = new Point(42, 17);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 38;
            label2.Text = "Unidades:";
            // 
            // buttonEliminar
            // 
            buttonEliminar.Anchor = AnchorStyles.Bottom;
            buttonEliminar.BackColor = Color.FromArgb(255, 83, 113);
            buttonEliminar.FlatAppearance.BorderSize = 0;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.ForeColor = SystemColors.ControlLight;
            buttonEliminar.Location = new Point(621, 104);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(177, 31);
            buttonEliminar.TabIndex = 42;
            buttonEliminar.Text = "Eliminar Unidad";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Bottom;
            label14.AutoSize = true;
            label14.Location = new Point(621, 58);
            label14.Name = "label14";
            label14.Size = new Size(57, 15);
            label14.TabIndex = 25;
            label14.Text = "Unidad:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom;
            label9.AutoSize = true;
            label9.Location = new Point(621, 33);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 41;
            label9.Text = "Eliminar Unidad:";
            // 
            // dataGridUnidades
            // 
            dataGridUnidades.Anchor = AnchorStyles.Bottom;
            dataGridUnidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridUnidades.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridUnidades.Location = new Point(42, 34);
            dataGridUnidades.Margin = new Padding(3, 2, 3, 2);
            dataGridUnidades.Name = "dataGridUnidades";
            dataGridUnidades.RowHeadersWidth = 51;
            dataGridUnidades.Size = new Size(573, 151);
            dataGridUnidades.TabIndex = 37;
            // 
            // comboBoxUnidadEliminar
            // 
            comboBoxUnidadEliminar.Anchor = AnchorStyles.Bottom;
            comboBoxUnidadEliminar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxUnidadEliminar.ForeColor = SystemColors.ControlLight;
            comboBoxUnidadEliminar.FormattingEnabled = true;
            comboBoxUnidadEliminar.Location = new Point(621, 75);
            comboBoxUnidadEliminar.Name = "comboBoxUnidadEliminar";
            comboBoxUnidadEliminar.Size = new Size(181, 23);
            comboBoxUnidadEliminar.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.BackColor = Color.FromArgb(17, 30, 53);
            groupBox1.Controls.Add(comboBoxConsorcista);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(comboBoxGestoAgregar);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(comboBoxTipoVinculo);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(buttonGuardarUnidad);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(textBoxPisoAgregar);
            groupBox1.Controls.Add(comboBoxEdificioAgregar);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBoxDptoAgregar);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxSuperficieAgregar);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(42, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 189);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Unidades";
            // 
            // comboBoxConsorcista
            // 
            comboBoxConsorcista.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxConsorcista.ForeColor = SystemColors.ControlLight;
            comboBoxConsorcista.FormattingEnabled = true;
            comboBoxConsorcista.Location = new Point(520, 77);
            comboBoxConsorcista.Name = "comboBoxConsorcista";
            comboBoxConsorcista.Size = new Size(209, 23);
            comboBoxConsorcista.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(520, 60);
            label8.Name = "label8";
            label8.Size = new Size(86, 15);
            label8.TabIndex = 41;
            label8.Text = "Consorcista:";
            // 
            // comboBoxGestoAgregar
            // 
            comboBoxGestoAgregar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxGestoAgregar.ForeColor = SystemColors.ControlLight;
            comboBoxGestoAgregar.FormattingEnabled = true;
            comboBoxGestoAgregar.Location = new Point(520, 34);
            comboBoxGestoAgregar.Name = "comboBoxGestoAgregar";
            comboBoxGestoAgregar.Size = new Size(209, 23);
            comboBoxGestoAgregar.TabIndex = 40;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(520, 17);
            label7.Name = "label7";
            label7.Size = new Size(116, 15);
            label7.TabIndex = 39;
            label7.Text = "Gestor Asignado:";
            // 
            // comboBoxTipoVinculo
            // 
            comboBoxTipoVinculo.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxTipoVinculo.ForeColor = SystemColors.ControlLight;
            comboBoxTipoVinculo.FormattingEnabled = true;
            comboBoxTipoVinculo.Location = new Point(520, 123);
            comboBoxTipoVinculo.Name = "comboBoxTipoVinculo";
            comboBoxTipoVinculo.Size = new Size(209, 23);
            comboBoxTipoVinculo.TabIndex = 38;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(520, 106);
            label15.Name = "label15";
            label15.Size = new Size(110, 15);
            label15.TabIndex = 37;
            label15.Text = "Tipo de Vinculo:";
            // 
            // buttonGuardarUnidad
            // 
            buttonGuardarUnidad.Anchor = AnchorStyles.None;
            buttonGuardarUnidad.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuardarUnidad.FlatAppearance.BorderSize = 0;
            buttonGuardarUnidad.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardarUnidad.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardarUnidad.FlatStyle = FlatStyle.Flat;
            buttonGuardarUnidad.ForeColor = SystemColors.ControlLight;
            buttonGuardarUnidad.Location = new Point(217, 150);
            buttonGuardarUnidad.Name = "buttonGuardarUnidad";
            buttonGuardarUnidad.Size = new Size(338, 32);
            buttonGuardarUnidad.TabIndex = 20;
            buttonGuardarUnidad.Text = "Guardar Cambios";
            buttonGuardarUnidad.UseVisualStyleBackColor = false;
            buttonGuardarUnidad.Click += buttonGuardarUnidad_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 18);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 25;
            label13.Text = "Edificio:";
            // 
            // textBoxPisoAgregar
            // 
            textBoxPisoAgregar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxPisoAgregar.ForeColor = SystemColors.ControlLight;
            textBoxPisoAgregar.Location = new Point(37, 81);
            textBoxPisoAgregar.Name = "textBoxPisoAgregar";
            textBoxPisoAgregar.Size = new Size(208, 21);
            textBoxPisoAgregar.TabIndex = 33;
            // 
            // comboBoxEdificioAgregar
            // 
            comboBoxEdificioAgregar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificioAgregar.ForeColor = SystemColors.ControlLight;
            comboBoxEdificioAgregar.FormattingEnabled = true;
            comboBoxEdificioAgregar.Location = new Point(37, 35);
            comboBoxEdificioAgregar.Name = "comboBoxEdificioAgregar";
            comboBoxEdificioAgregar.Size = new Size(209, 23);
            comboBoxEdificioAgregar.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(37, 64);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 28;
            label12.Text = "Piso:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(262, 18);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 29;
            label11.Text = "Dpto:";
            // 
            // textBoxDptoAgregar
            // 
            textBoxDptoAgregar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxDptoAgregar.ForeColor = SystemColors.ControlLight;
            textBoxDptoAgregar.Location = new Point(263, 35);
            textBoxDptoAgregar.Name = "textBoxDptoAgregar";
            textBoxDptoAgregar.Size = new Size(208, 21);
            textBoxDptoAgregar.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 106);
            label10.Name = "label10";
            label10.Size = new Size(184, 15);
            label10.TabIndex = 30;
            label10.Text = "Superficie (mts cuadrados):";
            // 
            // textBoxSuperficieAgregar
            // 
            textBoxSuperficieAgregar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxSuperficieAgregar.ForeColor = SystemColors.ControlLight;
            textBoxSuperficieAgregar.Location = new Point(37, 123);
            textBoxSuperficieAgregar.Name = "textBoxSuperficieAgregar";
            textBoxSuperficieAgregar.Size = new Size(208, 21);
            textBoxSuperficieAgregar.TabIndex = 31;
            // 
            // groupBoxEstado
            // 
            groupBoxEstado.Anchor = AnchorStyles.Top;
            groupBoxEstado.BackColor = Color.FromArgb(17, 30, 53);
            groupBoxEstado.Controls.Add(comboBoxConsorcistaModificar);
            groupBoxEstado.Controls.Add(label18);
            groupBoxEstado.Controls.Add(comboBoxGestorModificar);
            groupBoxEstado.Controls.Add(label19);
            groupBoxEstado.Controls.Add(comboBoxTipoVinculoModificar);
            groupBoxEstado.Controls.Add(label16);
            groupBoxEstado.Controls.Add(comboBoxUnidadModificar);
            groupBoxEstado.Controls.Add(textBoxPisoModificar);
            groupBoxEstado.Controls.Add(label1);
            groupBoxEstado.Controls.Add(buttonGuardar);
            groupBoxEstado.Controls.Add(textBoxDptoModificar);
            groupBoxEstado.Controls.Add(textBoxSuperficieModificar);
            groupBoxEstado.Controls.Add(label3);
            groupBoxEstado.Controls.Add(label4);
            groupBoxEstado.Controls.Add(label5);
            groupBoxEstado.Controls.Add(comboBoxEdificioModificar);
            groupBoxEstado.Controls.Add(label6);
            groupBoxEstado.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            groupBoxEstado.ForeColor = SystemColors.ControlLight;
            groupBoxEstado.Location = new Point(42, 207);
            groupBoxEstado.Name = "groupBoxEstado";
            groupBoxEstado.Size = new Size(745, 189);
            groupBoxEstado.TabIndex = 39;
            groupBoxEstado.TabStop = false;
            groupBoxEstado.Text = "Editar Unidades";
            // 
            // comboBoxConsorcistaModificar
            // 
            comboBoxConsorcistaModificar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxConsorcistaModificar.ForeColor = SystemColors.ControlLight;
            comboBoxConsorcistaModificar.FormattingEnabled = true;
            comboBoxConsorcistaModificar.Location = new Point(503, 77);
            comboBoxConsorcistaModificar.Name = "comboBoxConsorcistaModificar";
            comboBoxConsorcistaModificar.Size = new Size(209, 23);
            comboBoxConsorcistaModificar.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(503, 60);
            label18.Name = "label18";
            label18.Size = new Size(86, 15);
            label18.TabIndex = 45;
            label18.Text = "Consorcista:";
            // 
            // comboBoxGestorModificar
            // 
            comboBoxGestorModificar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxGestorModificar.ForeColor = SystemColors.ControlLight;
            comboBoxGestorModificar.FormattingEnabled = true;
            comboBoxGestorModificar.Location = new Point(503, 34);
            comboBoxGestorModificar.Name = "comboBoxGestorModificar";
            comboBoxGestorModificar.Size = new Size(209, 23);
            comboBoxGestorModificar.TabIndex = 44;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(503, 17);
            label19.Name = "label19";
            label19.Size = new Size(116, 15);
            label19.TabIndex = 43;
            label19.Text = "Gestor Asignado:";
            // 
            // comboBoxTipoVinculoModificar
            // 
            comboBoxTipoVinculoModificar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxTipoVinculoModificar.ForeColor = SystemColors.ControlLight;
            comboBoxTipoVinculoModificar.FormattingEnabled = true;
            comboBoxTipoVinculoModificar.Location = new Point(503, 121);
            comboBoxTipoVinculoModificar.Name = "comboBoxTipoVinculoModificar";
            comboBoxTipoVinculoModificar.Size = new Size(181, 23);
            comboBoxTipoVinculoModificar.TabIndex = 40;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(503, 103);
            label16.Name = "label16";
            label16.Size = new Size(110, 15);
            label16.TabIndex = 39;
            label16.Text = "Tipo de Vinculo:";
            // 
            // comboBoxUnidadModificar
            // 
            comboBoxUnidadModificar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxUnidadModificar.ForeColor = SystemColors.ControlLight;
            comboBoxUnidadModificar.FormattingEnabled = true;
            comboBoxUnidadModificar.Location = new Point(24, 35);
            comboBoxUnidadModificar.Name = "comboBoxUnidadModificar";
            comboBoxUnidadModificar.Size = new Size(209, 23);
            comboBoxUnidadModificar.TabIndex = 23;
            comboBoxUnidadModificar.SelectedIndexChanged += comboBoxUnidadModificar_SelectedIndexChanged;
            // 
            // textBoxPisoModificar
            // 
            textBoxPisoModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxPisoModificar.ForeColor = SystemColors.ControlLight;
            textBoxPisoModificar.Location = new Point(24, 83);
            textBoxPisoModificar.Name = "textBoxPisoModificar";
            textBoxPisoModificar.Size = new Size(208, 21);
            textBoxPisoModificar.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 22;
            label1.Text = "Unidad:";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Anchor = AnchorStyles.None;
            buttonGuardar.BackColor = Color.FromArgb(0, 187, 118);
            buttonGuardar.FlatAppearance.BorderSize = 0;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(2, 146, 95);
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.ForeColor = SystemColors.ControlLight;
            buttonGuardar.Location = new Point(121, 151);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(504, 32);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Actualizar Cambios";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // textBoxDptoModificar
            // 
            textBoxDptoModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxDptoModificar.ForeColor = SystemColors.ControlLight;
            textBoxDptoModificar.Location = new Point(262, 83);
            textBoxDptoModificar.Name = "textBoxDptoModificar";
            textBoxDptoModificar.Size = new Size(208, 21);
            textBoxDptoModificar.TabIndex = 19;
            // 
            // textBoxSuperficieModificar
            // 
            textBoxSuperficieModificar.BackColor = Color.FromArgb(13, 22, 40);
            textBoxSuperficieModificar.ForeColor = SystemColors.ControlLight;
            textBoxSuperficieModificar.Location = new Point(24, 125);
            textBoxSuperficieModificar.Name = "textBoxSuperficieModificar";
            textBoxSuperficieModificar.Size = new Size(208, 21);
            textBoxSuperficieModificar.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 108);
            label3.Name = "label3";
            label3.Size = new Size(184, 15);
            label3.TabIndex = 16;
            label3.Text = "Superficie (mts cuadrados):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(261, 66);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 15;
            label4.Text = "Dpto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 66);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Piso:";
            // 
            // comboBoxEdificioModificar
            // 
            comboBoxEdificioModificar.BackColor = Color.FromArgb(13, 22, 40);
            comboBoxEdificioModificar.ForeColor = SystemColors.ControlLight;
            comboBoxEdificioModificar.FormattingEnabled = true;
            comboBoxEdificioModificar.Location = new Point(261, 35);
            comboBoxEdificioModificar.Name = "comboBoxEdificioModificar";
            comboBoxEdificioModificar.Size = new Size(209, 23);
            comboBoxEdificioModificar.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(261, 18);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 0;
            label6.Text = "Edificio:";
            // 
            // formGestionarUnidadA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 597);
            Controls.Add(groupBox2);
            MinimumSize = new Size(840, 636);
            Name = "formGestionarUnidadA";
            Text = "formGestionarUnidadA";
            Load += formGestionarUnidadA_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUnidades).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxEstado.ResumeLayout(false);
            groupBoxEstado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Button buttonEliminar;
        private Label label14;
        private Label label9;
        private DataGridView dataGridUnidades;
        private ComboBox comboBoxUnidadEliminar;
        private GroupBox groupBox1;
        private ComboBox comboBoxTipoVinculo;
        private Label label15;
        private Button buttonGuardarUnidad;
        private Label label13;
        private TextBox textBoxPisoAgregar;
        private ComboBox comboBoxEdificioAgregar;
        private Label label12;
        private Label label11;
        private TextBox textBoxDptoAgregar;
        private Label label10;
        private TextBox textBoxSuperficieAgregar;
        private GroupBox groupBoxEstado;
        private ComboBox comboBoxTipoVinculoModificar;
        private Label label16;
        private ComboBox comboBoxUnidadModificar;
        private TextBox textBoxPisoModificar;
        private Label label1;
        private Button buttonGuardar;
        private TextBox textBoxDptoModificar;
        private TextBox textBoxSuperficieModificar;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxEdificioModificar;
        private Label label6;
        private ComboBox comboBoxConsorcista;
        private Label label8;
        private ComboBox comboBoxGestoAgregar;
        private Label label7;
        private ComboBox comboBoxConsorcistaModificar;
        private Label label18;
        private ComboBox comboBoxGestorModificar;
        private Label label19;
    }
}