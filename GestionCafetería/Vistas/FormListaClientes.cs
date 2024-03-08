using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();

            listViewClientes.View = View.Details;

            listViewClientes.Columns.Add("ID", 80);
            listViewClientes.Columns.Add("Nombre", 120);
            listViewClientes.Columns.Add("Teléfono", 100);
            listViewClientes.Columns.Add("Correo", 200);
        }
        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            ControladorCliente.ObtenerListaClientes();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = ControladorCliente.ObtenerListaClientes();

            listViewClientes.Items.Clear();

            foreach (Cliente cliente in clientes)
            {
                ListViewItem item = new ListViewItem(cliente.Id);

                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Telefono);
                item.SubItems.Add(cliente.Correo);

                listViewClientes.Items.Add(item);
            }
        }

    }
}
