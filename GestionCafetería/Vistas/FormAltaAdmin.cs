using System;
using System.Drawing;
using System.Windows.Forms;
using GestionCafetería.Clases;
using GestionCafetería.Controladores;

namespace GestionCafetería.Vistas
{
    public partial class FormAltaAdmin : Form
    {
        public FormAltaAdmin()
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
                string id = txtId.Text;
                if (ControladorAdministrador.AdminIdExistente(id))
                {
                    MessageBox.Show("El ID ya existe. Por favor, elija un ID diferente.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Administrador a = new Administrador(txtId.Text, txtNombre.Text, txtContraseña.Text,
                                                      txtCorreo.Text, combCargo.Text,
                                                      (int)numEmpleados.Value);

                ControladorAdministrador.InsertarAdmin(a);
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("Datos inválidos.");
            }
        }

        private bool Comprobar()
        {
            bool correcto = true;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtId.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtId.BackColor = Color.White;
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

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtContraseña.BackColor = Color.White;
            }

            if ((!txtCorreo.Text.Contains("@")) || (string.IsNullOrWhiteSpace(txtCorreo.Text)))
            {
                txtCorreo.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtCorreo.BackColor = Color.White;
            }

            if (combCargo.Text.Equals("Supervisor") || combCargo.Text.Equals("Gerente")
                || combCargo.Text.Equals("Encargado") || !(string.IsNullOrWhiteSpace(combCargo.Text)))
            {
                combCargo.BackColor = Color.White;
            }
            else
            {
                combCargo.BackColor = Color.Red;
                correcto = false;
            }

            if (numEmpleados.Value <= 0)
            {
                numEmpleados.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                numEmpleados.BackColor = Color.White;
            }
            return correcto;

        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            combCargo.ResetText();
            numEmpleados.ResetText();
            txtId.Focus();

        }
    }
}
