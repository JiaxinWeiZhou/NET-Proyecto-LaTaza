using System;
using System.Windows.Forms;
using GestionCafetería.Controladores;
using GestionCafetería.Vistas;

namespace GestionCafetería
{

    public partial class FormLoginEmpleado : Form
    {
        public FormLoginEmpleado()
        {
            InitializeComponent();

        }

        public int contador = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToLower();
            string contraseña = txtContraseña.Text;

            if (ControladorEmpleado.ValidarEmpleado(usuario, contraseña))
            {
                MessageBox.Show("Bienvenido");
                txtUsuario.Clear();
                txtContraseña.Clear();

                FormTPV tpv = new FormTPV();
                tpv.Show();
                this.Close();
            }
            else
            {
                contador++;
                if (contador >= 3)
                {
                    MessageBox.Show("Has superado el limite de intentos");
                    Application.Exit();
                    return;
                }
                MessageBox.Show("Error de usuario y/o contraseña");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormSaliendo salir = new FormSaliendo();
            salir.Show();
            this.Close();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            FormLoginAdmin loginA = new FormLoginAdmin();
            loginA.Show();
            this.Close();
        }
    }

}
