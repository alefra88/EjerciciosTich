using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADOWinForm.Entidades;
using ADOWinForm.ADO;

namespace ADOWinForm
{
    public partial class frmEstatusAlumnos : Form
    {
        Opcion opcion;
        ADOEstatusAlumno oADOEstatusAlumno = new ADOEstatusAlumno();
        EstatusAlumno _estatusAlumno = new EstatusAlumno();
        public frmEstatusAlumnos()
        {
            InitializeComponent();


        }

        private void frmEstatusAlumnos_Load(object sender, EventArgs e)
        {
            CargarElementos();
        }




        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            pnlDetalles.Visible = true;
            txtBxClave.Text = _estatusAlumno.Clave;
            nomTxtBx.Text = _estatusAlumno.Nombre;
            txtBxClave.Enabled = true;
            nomTxtBx.Enabled = true;
            btnGuardar.Text = "Grabar";
            opcion = Opcion.Agregar;
            cbxEstatusAlumno.Enabled = true;
        }



        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            switch (opcion)
            {
                case Opcion.Agregar:
                    string clave = txtBxClave.Text;
                    string nombre = nomTxtBx.Text;
                    if (string.IsNullOrEmpty(clave) || string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("Debes ingresar valores para clave y nombre");
                        return;
                    }

                    try
                    {


                        _estatusAlumno.Clave = clave;
                        _estatusAlumno.Nombre = nombre;
                        ADOEstatusAlumno oEstatusAlumno1 = new ADOEstatusAlumno();
                        oEstatusAlumno1.Agregar(_estatusAlumno);
                        pnlDetalles.Visible = false;
                        CargarElementos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Algo esta pasando: {ex}");
                    }
                    break;

                case Opcion.Actualizar:

                    pnlDetalles.Visible = true;
                    _estatusAlumno.Id = Convert.ToInt16(cbxEstatusAlumno.SelectedValue);
                    _estatusAlumno.Clave = txtBxClave.Text;
                    _estatusAlumno.Nombre = nomTxtBx.Text;
                    txtBxClave.Enabled = true;
                    nomTxtBx.Enabled = true;
                    btnGuardar.Enabled = true;
                    opcion = Opcion.Actualizar;

                    btnGuardar.Text = "Grabar";

                    oADOEstatusAlumno.Actualizar(_estatusAlumno);
                    pnlDetalles.Visible = false;
                    CargarElementos();
                    break;
                case Opcion.Eliminar:                                   
                    btnGuardar.Enabled = true;
                    btnGuardar.Text = "Grabar";
                    int id = Convert.ToInt16(cbxEstatusAlumno.SelectedValue);
                    oADOEstatusAlumno.Eliminar(id);
                    pnlDetalles.Visible = false;
                    CargarElementos();

                    break;

            }
        }
        private void CargarElementos()
        {
            List<EstatusAlumno> list = oADOEstatusAlumno.ConsultarT();

            cbxEstatusAlumno.DataSource = list;
            cbxEstatusAlumno.DisplayMember = "nombre";
            cbxEstatusAlumno.ValueMember = "id";
            dgvestatus.DataSource = list;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(cbxEstatusAlumno.SelectedValue);
            EstatusAlumno estatusAlumnos = oADOEstatusAlumno.Consultar(id);
            pnlDetalles.Visible = true;
            txtBxClave.Text = estatusAlumnos.Clave;
            nomTxtBx.Text = estatusAlumnos.Nombre;
            txtBxClave.Enabled = true;
            nomTxtBx.Enabled = true;
            btnGuardar.Text = "Grabar";
            opcion = Opcion.Actualizar;




        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(cbxEstatusAlumno.SelectedValue);
            EstatusAlumno estatusAlumnos = oADOEstatusAlumno.Consultar(id);
            pnlDetalles.Visible = true;
            txtBxClave.Text = estatusAlumnos.Clave;
            nomTxtBx.Text = estatusAlumnos.Nombre;
            txtBxClave.Enabled = false;
            nomTxtBx.Enabled = false;
            btnGuardar.Text = "Grabar";
            opcion = Opcion.Eliminar;
        }
    }


}