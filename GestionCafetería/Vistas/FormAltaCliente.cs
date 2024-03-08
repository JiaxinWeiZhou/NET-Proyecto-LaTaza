using System;
using System.Drawing;
using System.Windows.Forms;
using GestionCafetería.Clases;
using GestionCafetería.Controladores;

namespace GestionCafetería.Vistas
{
    public partial class FormAltaCliente : Form
    {
        public FormAltaCliente()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            mtbTelefono.Clear();
            txtIDCliente.Focus();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (comprobar())
            {
                string id = txtIDCliente.Text;

                if (ControladorCliente.ClienteIdExistente(id))
                {
                    MessageBox.Show("El ID ya existe. Por favor, elija un ID diferente.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Cliente c = new Cliente(txtIDCliente.Text, txtNombre.Text, mtbTelefono.Text, txtCorreo.Text);
                    ControladorCliente.listaCliente.Add(c);
                    LimpiarCampos();

                    ControladorCliente.EscribirCliente();
                    ControladorCliente.InsertarCliente(c);
                }
            }
            else
            {
                MessageBox.Show("Datos inválidos.");
            }
        }
        private bool comprobar()
        {
            bool correcto = true;

            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                txtIDCliente.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtIDCliente.BackColor = Color.White;
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

            if (mtbTelefono.MaskCompleted)
            {
                mtbTelefono.BackColor = Color.White;
                
            }
            else
            {
                mtbTelefono.BackColor = Color.Red;
                correcto = false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains("@"))
            {
                txtCorreo.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtCorreo.BackColor = Color.White;
            }
            return correcto;
        }

        private bool EsNumero(string str)
        {
            return int.TryParse(str, out _);
        }
    }
}
