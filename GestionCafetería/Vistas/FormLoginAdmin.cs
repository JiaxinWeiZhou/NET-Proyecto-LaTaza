using System;
using System.Windows.Forms;
using GestionCafetería.Controladores;

namespace GestionCafetería.Vistas
{
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FormLoginEmpleado login = new FormLoginEmpleado();
            login.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtUsuario.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.ToLower();
            string contraseña = txtContraseña.Text;

            if (ControladorAdministrador.ValidarAdmin(usuario, contraseña))
            {
                MessageBox.Show("Bienvenido");
                txtUsuario.Clear();
                txtContraseña.Clear();

                FormInicioAdmin inicioAdmin = new FormInicioAdmin();
                inicioAdmin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error de usuario y/o contraseña");
                txtUsuario.Clear();
                txtContraseña.Clear();
                txtUsuario.Focus();
            }
        }

    }
}
