using BE;
using BLL;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConsorAdmin.FORMS_ADMIN
{
    public partial class formPermisosA : Form, IIdiomaObserver
    {
        private readonly TraductorBLL _traductorBLL = new TraductorBLL();
        private readonly IPermisoBLL _bll = new PermisoBLL();

        public formPermisosA()
        {
            InitializeComponent();
            this.Load += formPermisosA_Load;
        }

        private void formPermisosA_Load(object sender, EventArgs e)
        {
            AsignarTags();
            SessionManager.SuscribirObservador(this);
            Traducir();
            CargarDatos();
        }

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
                comboBoxFamilias.Items.Add(new ItemCombo { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
                comboBoxContenedor.Items.Add(new ItemCombo { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
                comboBoxFamiliaAgregar.Items.Add(new ItemCombo { Display = $"{p.Codigo} - {p.Nombre}", Value = p });
            }

            foreach (var p in patentes)
                comboBoxPatentes.Items.Add(new ItemCombo { Display = p.Nombre, Value = p });

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
            if (comboBoxFamilias.SelectedItem is not ItemCombo familia ||
                comboBoxPatentes.SelectedItem is not ItemCombo patente)
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
            if (comboBoxContenedor.SelectedItem is not ItemCombo contenedor ||
                comboBoxFamiliaAgregar.SelectedItem is not ItemCombo aAgregar)
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

        private class ItemCombo
        {
            public string Display { get; set; }
            public object Value { get; set; }
            public override string ToString() => Display;
        }

        private void formPermisosA_FormClosing(object sender, FormClosingEventArgs e)
        {
            SessionManager.DesuscribirObservador(this); // evita memory leak / notificar a un form cerrado
        }
        public void ActualizarIdioma(IdiomaBE idioma)
        {
            if (this.InvokeRequired) this.Invoke(() => Traducir(idioma));
            else Traducir(idioma);
        }

        private void Traducir(IdiomaBE idioma = null)
        {
            idioma ??= SessionManager.IdiomaActual ?? _traductorBLL.ObtenerIdiomaDefault();
            var t = _traductorBLL.ObtenerTraducciones(idioma);
            TraducirControles(this.Controls, t);
        }

        private void TraducirControles(Control.ControlCollection controles, Dictionary<string, string> t)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl.Tag is string clave && t.ContainsKey(clave))
                    ctrl.Text = t[clave];
                if (ctrl.Controls.Count > 0)
                    TraducirControles(ctrl.Controls, t);
            }
        }

        private void AsignarTags()
        {
            groupBoxFamilia_FormPermisosA.Tag = "groupBoxFamilia_FormPermisosA";
            buttonCrearFamilia.Tag = "buttonCrearFamilia";
            labelNombre_FormPermisosA.Tag = "labelNombre_FormPermisosA";
            labelCodigo_FormPermisosA.Tag = "labelCodigo_FormPermisosA";
            groupBoxAsignar_FormPermisosA.Tag = "groupBoxAsignar_FormPermisosA";
            buttonAgregar_FormPermisosA.Tag = "buttonAgregar_FormPermisosA";
            labelPatente_FormPermisosA.Tag = "labelPatente_FormPermisosA";
            labelFamilia_FormPermisosA.Tag = "labelFamilia_FormPermisosA";
            groupBoxFamiliaEnFamilia_FormPermisosA.Tag = "groupBoxFamiliaEnFamilia_FormPermisosA";
            buttonAgregarFamilia_FormPermisosA.Tag = "buttonAgregarFamilia_FormPermisosA";
            labelFamiliaAgregar_FormPermisosA.Tag = "labelFamiliaAgregar_FormPermisosA";
            labelContenedor_FormPermisosA.Tag = "labelContenedor_FormPermisosA";
            labelArbol_FormPermisosA.Tag = "labelArbol_FormPermisosA";
        }
    }
}
