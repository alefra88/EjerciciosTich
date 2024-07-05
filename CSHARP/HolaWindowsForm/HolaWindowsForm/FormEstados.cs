using HolaWindowsForm.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HolaWindowsForm
{
    public partial class FormEstados : Form
    {
        CrudADO _ocrudADO = new CrudADO();
        public FormEstados()
        {
            InitializeComponent();
        }

    

        private void FormEstados_Load(object sender, EventArgs e)
        {
            
            List<Estado>listaEstados = _ocrudADO.Consultar();
            cbxEstado.DataSource = listaEstados;
            cbxEstado.DisplayMember = "nombre";
            cbxEstado.ValueMember = "id";
            
            dgvEstados.DataSource = listaEstados;

            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           int id = Convert.ToInt16(cbxEstado.SelectedValue);
            Estado oEstado = _ocrudADO.Consultar(id);
            txtID.Text = oEstado.id.ToString();
            txtNombre.Text = oEstado.name;
        }

        private void cBDetalles_CheckedChanged(object sender, EventArgs e)
        {
           pnlDetalles.Visible= cBDetalles.Checked ? true : false;
        }

       
    }
}
