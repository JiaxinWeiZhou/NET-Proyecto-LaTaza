using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormListaProductos : Form
    {      
        public FormListaProductos()
        {
            InitializeComponent();

            listViewProductos.View = View.Details;

            listViewProductos.Columns.Add("ID", 80);
            listViewProductos.Columns.Add("Nombre", 120);
            listViewProductos.Columns.Add("Precio", 80);
            listViewProductos.Columns.Add("Categoría", 120);
            listViewProductos.Columns.Add("Fecha", 130);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ControladorProducto.ObtenerListaProductos();

            listViewProductos.Items.Clear();

            foreach (Producto producto in productos)
            {
                ListViewItem item = new ListViewItem(producto.Id);

                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Categoria);
                item.SubItems.Add(producto.Fecha.ToString("dd/MM/yyyy HH:mm:ss"));

                listViewProductos.Items.Add(item);
            }
        }
        
        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            ControladorProducto.ObtenerListaProductos();   
        }


    }
}
