using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormAltaEmpleado : Form
    {
        public FormAltaEmpleado()
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

                if (ControladorEmpleado.EmpleadoIdExistente(id))
                {
                    MessageBox.Show("El ID ya existe. Por favor, elija un ID diferente.", "Error de ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Empleado empleado = new Empleado(
                                txtNombre.Text,
                                txtContraseña.Text,
                                txtCorreo.Text,
                                txtId.Text,
                                Convert.ToDouble(txtSalario.Text)
            );

                    ControladorEmpleado.listaEmpleado.Add(empleado);
                    ControladorEmpleado.InsertarEmpleado(empleado);
                    ControladorEmpleado.EscribirEmpleados();
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


            if (!double.TryParse(txtSalario.Text, out double salario) || salario < 0)
            {
                txtSalario.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtSalario.BackColor = Color.White;
            }


            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtId.BackColor = Color.Red;
                correcto = false;
            }
            else
            {
                txtId.BackColor = Color.White;
            }

            return correcto;
        }


        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtId.Clear();
            txtSalario.Clear();
            txtNombre.Focus();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

    }
}
