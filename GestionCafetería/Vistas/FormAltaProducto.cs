using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using Microsoft.OData.Edm;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormAltaProducto : Form
    {
        public FormAltaProducto()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (Comprobar())
            {
                string id = txtIdProducto.Text;

                if (ControladorProducto.ProductoIdExistente(id))
                {
                    MessageBox.Show("El ID ya existe. Por favor, elija un ID diferente.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Producto p = new Producto(txtIdProducto.Text, txtNombre.Text,
                                          double.Parse(txtPrecio.Text),
                                          combCategoria.Text, 
                                          dtpFecha.Value);

                    ControladorProducto.listaProducto.Add(p);
                    ControladorProducto.EscribirProducto();
                    ControladorProducto.InsertarProducto(p);
                    LimpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos.");
            }
        }
        private bool Comprobar()
        {
            bool correcto = true;
            DateTime fecha = dtpFecha.Value;
            if (fecha < DateTime.Today)
            {
                dtpFecha.CalendarForeColor = System.Drawing.Color.Red;
                MessageBox.Show("La fecha fecha seleccionada no puede ser menor a hoy");
                correcto = false;
            }
            else
            {
                dtpFecha.CalendarForeColor = System.Drawing.Color.White;
                correcto = true;
            }

            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                txtIdProducto.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtIdProducto.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                txtNombre.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtNombre.BackColor = Color.White;
            }

            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio) || precio < 0 || txtPrecio.Text.Contains('.'))
            {
                txtPrecio.BackColor = Color.Red;
                correcto = false;
                MessageBox.Show("Por favor, introduzca un precio válido con coma (,).");
            }
            else
            {
                txtPrecio.BackColor = Color.White;
            }

            if (combCategoria.SelectedIndex == -1)
            {
                combCategoria.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                combCategoria.BackColor = Color.White;
            }

            return correcto;
        }

        private void LimpiarCampos()
        {
            txtIdProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            combCategoria.ResetText();
            txtIdProducto.Focus();
            dtpFecha.ResetText();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        
    }
}
