using System;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormInicioAdmin : Form
    {
        public FormInicioAdmin()
        {
            InitializeComponent();
        }
             

        private void FormInicioAdmin_Load(object sender, EventArgs e)
        { 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormSaliendo salir = new FormSaliendo();
            salir.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLoginEmpleado formlogin = new FormLoginEmpleado();
            formlogin.Show();
            this.Close();
        }

        private void altaAdmin_Click(object sender, EventArgs e)
        {
            FormAltaAdmin formaltaAdmin = new FormAltaAdmin();
            formaltaAdmin.Show();
            this.Close();
        }

        private void listaAdmin_Click(object sender, EventArgs e)
        {
            FormListaAdmins formlistaAdmins = new FormListaAdmins();
            formlistaAdmins.Show();
            this.Close();
        }

        private void altaEmpleado_Click(object sender, EventArgs e)
        {
            FormAltaEmpleado formaltaEmpleado = new FormAltaEmpleado();
            formaltaEmpleado.Show();
            this.Close();
        }

        private void listadoEmpleado_Click(object sender, EventArgs e)
        {
            FormListaEmpleados formlistaEmpleado = new FormListaEmpleados();
            formlistaEmpleado.Show();
            this.Close();
        }

        private void altaProducto_Click(object sender, EventArgs e)
        {
            FormAltaProducto formAltaProducto = new FormAltaProducto();
            formAltaProducto.Show();
            this.Close();
        }

        private void listaProducto_Click(object sender, EventArgs e)
        {
            FormListaProductos formListaProductos = new FormListaProductos();
            formListaProductos.Show();
            this.Close();
        }

        private void altaCliente_Click(object sender, EventArgs e)
        {
            FormAltaCliente formAltaCliente = new FormAltaCliente();    
            formAltaCliente.Show();
            this.Close();
        }

        private void listaCliente_Click(object sender, EventArgs e)
        {
            FormListaClientes formListaClientes = new FormListaClientes();  
            formListaClientes.Show();
            this.Close();
        }

        

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            FormListaProductos formListaProductos = new FormListaProductos();
            formListaProductos.Show();
            this.Close();
        }


        private void btnTPV_Click(object sender, EventArgs e)
        {
            FormTPV TPV = new FormTPV();
            TPV.Show();
            this.Close();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            FormTickets formRecibos = new FormTickets();
            formRecibos.Show();
            this.Close();
        }

        private void TicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTickets frmTickets = new FormTickets();
            frmTickets.Show();
            this.Close();
        }

        private void basededatos_Click(object sender, EventArgs e)
        {
            FormBaseDeDatos frmbase = new FormBaseDeDatos();
            frmbase.Show();
            this.Close();
        }

        private void BBDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBaseDeDatos frmbase = new FormBaseDeDatos();
            frmbase.Show();
            this.Close();
        }
    }
}
