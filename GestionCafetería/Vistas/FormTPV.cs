using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormTPV : Form
    {
        private int posicion;
        private int contador;
        private List<CheckBox> checksProducto = new List<CheckBox>();
        private List<NumericUpDown> numericsProducto = new List<NumericUpDown>();
        private StringBuilder productosDetalle = new StringBuilder();

        public FormTPV()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormSaliendo salir = new FormSaliendo();
            salir.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLoginEmpleado login = new FormLoginEmpleado();
            login.Show();
            this.Close();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void FormTPV_Load(object sender, EventArgs e)
        {
            ControladorTicket.LeerTickets();
            List<Producto> productos = ControladorProducto.ObtenerListaProductos();
            if (productos != null && productos.Count > 0)
            {
                ControladorProducto.listaProducto = productos;
                mostrarProductos();
            }
            else
            {
                MessageBox.Show("No se encontraron productos en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mostrarProductos()
        {
            this.groupBoxProductos.Controls.Clear();
            this.contador = 1;
            this.posicion = 15;

            foreach (Producto p in ControladorProducto.listaProducto)
            {
                crearChecksProducto(p);
            }
        }

        private void crearChecksProducto(Producto p)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Font = new Font("Constantia", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox.Location = new Point(10, this.posicion);
            checkBox.Name = "chkProducto" + this.contador;
            checkBox.Size = new Size(200, 20);
            checkBox.Text = p.Nombre + " - " + p.Precio;

            NumericUpDown numericUpDown = new NumericUpDown();
            numericUpDown.Font = new Font("Constantia", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown.Location = new Point((groupBoxProductos.Width - 60), this.posicion);
            numericUpDown.Name = "numProducto" + this.contador;
            numericUpDown.Size = new Size(60, 20);
            numericUpDown.Minimum = 0;
            numericUpDown.Maximum = 100;

            groupBoxProductos.Controls.Add(checkBox);
            groupBoxProductos.Controls.Add(numericUpDown);

            checksProducto.Add(checkBox);
            numericsProducto.Add(numericUpDown);

            this.posicion += 30;
            this.contador++;
        }

        public void mostrarTicket()
        {
            this.contador = 1;
            this.posicion = 15;
            crearEtiquetaTicket();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            mostrarTicket();
        }

        private int cantidad;

        public void crearEtiquetaTicket()
        {
            productosDetalle.Clear();

            for (int i = 0; i < checksProducto.Count; i++)
            {
                if (checksProducto[i].Checked && numericsProducto[i].Value > 0)
                {
                    cantidad = (int)numericsProducto[i].Value;
                    string productoTexto = $"{checksProducto[i].Text} - {cantidad}";
                    productosDetalle.AppendLine(productoTexto);

                    bool productoExistente = false;

                    foreach (var item in listBoxTicket.Items)
                    {
                        if (item is string etiqueta && etiqueta.Contains(checksProducto[i].Name))
                        {
                            if (int.TryParse(etiqueta.Split('-')[1].Trim(), out int cantidadExistente))
                            {
                                listBoxTicket.Items.Remove(item);
                                listBoxTicket.Items.Add($"{checksProducto[i].Text} - {cantidadExistente + cantidad}");
                            }
                            productoExistente = true;
                            break;
                        }
                    }

                    if (!productoExistente)
                    {
                        listBoxTicket.Items.Add($"{checksProducto[i].Text} - {cantidad}");
                    }
                }
            }

            mostrarTotal();
        }

        private void MostrarMensajeTicket()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"ID del Ticket: {ControladorTicket.ObtenerUltimoCodigo()}");
            mensaje.AppendLine($"Fecha: {DateTime.Now}\n");
            mensaje.AppendLine("Productos:");
            foreach (var item in listBoxTicket.Items)
            {
                if (item is string etiqueta)
                {
                    mensaje.AppendLine(etiqueta);
                }
            }
            mensaje.AppendLine($"\nPrecio Total: €{precioTotal}");

            MessageBox.Show(mensaje.ToString(), "Detalles del Ticket", MessageBoxButtons.OK);

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            productosDetalle.Clear();
            contador = 1;

            mostrarTotal();
            crearRecibo();
            MostrarMensajeTicket();
            limpiarTicket();

            lblTotal.Text = "Total: €0.00";
        }

        private void limpiarTicket()
        {
            listBoxTicket.Items.Clear();
            precioTotal = 0;
        }

        private void crearRecibo()
        {
            Ticket ticket = new Ticket();
            ControladorTicket.listaTicket.Add(ticket);
            ControladorTicket.EscribirTicket(ticket, precioTotal);
        }

        private double precioTotal = 0;

        private void mostrarTotal()
        {
            precioTotal = 0;

            foreach (var item in listBoxTicket.Items)
            {
                if (item is string etiqueta)
                {
                    double precioProducto = double.Parse(etiqueta.Split('-')[1].Trim().Replace("€", ""));
                    int cantidadP = int.Parse(etiqueta.Split('-')[2]);
                    precioTotal += (precioProducto * cantidadP);
                }
            }

            lblTotal.Text = $"Total: €{precioTotal}";
        }
    }
}
