using BE;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formPermisosA : Form
    {
        private readonly IPermisoBLL _bll = new PermisoBLL();

        public formPermisosA()
        {
            InitializeComponent();
            this.Load += formPermisosA_Load;
        }

        private void formPermisosA_Load(object sender, EventArgs e) => CargarDatos();

        private void CargarDatos()
        {
            try
            {
                var arbol = _bll.ObtenerArbolCompleto();
                var todasFamilias = _bll.ObtenerTodasLasFamilias();
                var todasPatentes = _bll.ObtenerTodasLasPatentes();
                PopularTreeView(arbol);
                PopularCombos(todasFamilias, todasPatentes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopularTreeView(List<ComponentePermisoBE> raices)
        {
            treeViewPermisos.BeginUpdate();
            treeViewPermisos.Nodes.Clear();
            foreach (var comp in raices)
                treeViewPermisos.Nodes.Add(CrearNodo(comp, new HashSet<int>()));
            treeViewPermisos.ExpandAll();
            treeViewPermisos.EndUpdate();
        }

        // ancestros: IDs de los nodos ya visitados en el camino actual, para cortar ciclos.
        private TreeNode CrearNodo(ComponentePermisoBE comp, HashSet<int> ancestros)
        {
            string prefijo = comp.Tipo == "F" ? "[F] " : "[P] ";
            var nodo = new TreeNode(prefijo + comp.Nombre) { Tag = comp };
            if (!ancestros.Contains(comp.Id_Permiso))
            {
                var camino = new HashSet<int>(ancestros) { comp.Id_Permiso };
                foreach (var hijo in comp.ObtenerHijos)
                    nodo.Nodes.Add(CrearNodo((ComponentePermisoBE)hijo, camino));
            }
            return nodo;
        }

        private void PopularCombos(List<ComponentePermisoBE> familias, List<ComponentePermisoBE> patentes)
        {
            comboBoxFamilias.Items.Clear();
            comboBoxPatentes.Items.Clear();
            comboBoxContenedor.Items.Clear();
            comboBoxFamiliaAgregar.Items.Clear();

            foreach (var p in familias)
            {
                comboBoxFamilias.Items.Add(new ComboItem { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
                comboBoxContenedor.Items.Add(new ComboItem { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
                comboBoxFamiliaAgregar.Items.Add(new ComboItem { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
            }

            foreach (var p in patentes)
                comboBoxPatentes.Items.Add(new ComboItem { Display = p.Nombre, Value = p });

            comboBoxFamilias.DisplayMember = "Display";
            comboBoxPatentes.DisplayMember = "Display";
            comboBoxContenedor.DisplayMember = "Display";
            comboBoxFamiliaAgregar.DisplayMember = "Display";
        }

        private void buttonCrearFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                _bll.CrearFamilia(textBoxCodigo.Text, textBoxNombre.Text);
                textBoxCodigo.Clear();
                textBoxNombre.Clear();
                CargarDatos();
                MessageBox.Show("Familia creada correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (comboBoxFamilias.SelectedItem is not ComboItem familia ||
                comboBoxPatentes.SelectedItem is not ComboItem patente)
            {
                MessageBox.Show("Seleccione una familia y una patente.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var f = (ComponentePermisoBE)familia.Value;
                var p = (ComponentePermisoBE)patente.Value;
                _bll.AgregarPatenteAFamilia(f.Id_Permiso, p.Id_Permiso);
                CargarDatos();
                MessageBox.Show("Patente agregada a la familia.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (comboBoxContenedor.SelectedItem is not ComboItem contenedor ||
                comboBoxFamiliaAgregar.SelectedItem is not ComboItem aAgregar)
            {
                MessageBox.Show("Seleccione la familia contenedora y la familia a agregar.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var c = (ComponentePermisoBE)contenedor.Value;
                var a = (ComponentePermisoBE)aAgregar.Value;
                _bll.AgregarFamiliaAFamilia(c.Id_Permiso, a.Id_Permiso);
                CargarDatos();
                MessageBox.Show("Familia agregada dentro de la familia contenedora.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private class ComboItem
        {
            public string Display { get; set; }
            public object Value { get; set; }
            public override string ToString() => Display;
        }
    }
}
