using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormTickets : Form
    {
        public FormTickets()
        {
            InitializeComponent();

            listViewTickets.View = View.Details;
            listViewTickets.CheckBoxes = true; 
            listViewTickets.Columns.Add("Código", 80);
            listViewTickets.Columns.Add("Fecha Creación", 150);
            listViewTickets.Columns.Add("Precio", 100);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<int> codigosTicketsSeleccionados = new List<int>();
            foreach (ListViewItem item in listViewTickets.CheckedItems)
            {
                int codigoTicket = int.Parse(item.SubItems[0].Text);
                codigosTicketsSeleccionados.Add(codigoTicket);
            }

            if (codigosTicketsSeleccionados.Count > 0)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar los tickets seleccionados?",
                                                          "Eliminar tickets",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    EliminarTickets(codigosTicketsSeleccionados);
                    CargarTickets(); 
                }
            }
            else
            {
                MessageBox.Show("No hay tickets seleccionados para eliminar.", "Eliminar tickets",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void EliminarTickets(List<int> codigosTickets)
        {
            try
            {
                ControladorTicket.listaTicket.RemoveAll(ticket => codigosTickets.Contains(ticket.Codigo));

                // Sobrescribe el archivo con la lista actualizada de tickets
                using (StreamWriter sw = new StreamWriter("ticket.txt"))
                {
                    foreach (Ticket ticket in ControladorTicket.listaTicket)
                    {
                        string linea = $"{ticket.Codigo};{ticket.FechaCreacion};{ticket.Precio}";
                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al eliminar los tickets: {ex.Message}");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            CargarTickets();
        }

        private void CargarTickets()
        {
            ControladorTicket.LeerTickets();

            listViewTickets.Items.Clear();

            foreach (Ticket ticket in ControladorTicket.listaTicket)
            {
                ListViewItem item = new ListViewItem(ticket.Codigo.ToString());
                item.SubItems.Add(ticket.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss"));
                item.SubItems.Add(ticket.Precio.ToString("C2"));

                listViewTickets.Items.Add(item);
            }
        }
    }
}
