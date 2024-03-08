using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GestionCafetería.Vistas
{
    public partial class FormListaAdmins : Form
    {
        internal PrintPreviewDialog PrintPreviewDialog1;
        internal System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
        public FormListaAdmins()
        {
            InitializeComponent();
            document.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(document_PrintPage);


            listViewAdministradores.View = View.Details;

            listViewAdministradores.Columns.Add("ID", 80);
            listViewAdministradores.Columns.Add("Nombre", 120);
            listViewAdministradores.Columns.Add("Correo", 170);
            listViewAdministradores.Columns.Add("Cargo", 100);
            listViewAdministradores.Columns.Add("Numero Empleados", 100);

            CargarDatosListView();
        }

        private void CargarDatosListView()
        {
            DataSet dataSet = new DataSet();

            try
            {
                string query = "SELECT Id, Nombre, Correo, Cargo, NumEmpleados FROM Administrador";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, ControladorAdministrador.ConstruirCadenaConexión()))
                {
                    adapter.Fill(dataSet, "Administrador");
                }

                MostrarDatosListView(dataSet.Tables["Administrador"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base de datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDatosListView(DataTable dataTable)
        {
            listViewAdministradores.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem(row["Id"].ToString());

                item.SubItems.Add(row["Nombre"].ToString());
                item.SubItems.Add(row["Correo"].ToString());
                item.SubItems.Add(row["Cargo"].ToString());
                item.SubItems.Add(row["NumEmpleados"].ToString());

                listViewAdministradores.Items.Add(item);
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1 = new PrintPreviewDialog();

            PrintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            PrintPreviewDialog1.Location = new System.Drawing.Point(29, 29);
            PrintPreviewDialog1.Name = "PrintPreviewDialog1";
            PrintPreviewDialog1.MinimumSize = new System.Drawing.Size(375, 250);

            document.DocumentName = "Administradores";
            PrintPreviewDialog1.Document = document;

            PrintPreviewDialog1.ShowDialog();
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float yPos = 0;
            int contador = 0;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            Font font = new Font("Arial", 10);

            yPos = topMargin + (contador * (font.Size + 4));
            e.Graphics.DrawString("LISTADO DE ADMINISTRADORES", font, Brushes.Black, leftMargin, yPos, new StringFormat());
            contador++;

            foreach (ListViewItem item in listViewAdministradores.Items)
            {
                string adminInfo = "";
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    adminInfo += subItem.Text + " ";
                }
                yPos = topMargin + (contador * (font.Size + 10));
                e.Graphics.DrawString(adminInfo, font, Brushes.Black, leftMargin, yPos, new StringFormat());
                contador++;
            }

        }
    }

}
