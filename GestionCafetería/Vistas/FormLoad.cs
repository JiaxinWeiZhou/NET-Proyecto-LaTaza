using System;
using System.Windows.Forms;

namespace GestionCafetería
{
    public partial class FormLoad : Form
    {
        public FormLoad()
        {
            InitializeComponent();
        }

        // Timer para mostrar la barra de carga
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            if(panel2.Width >= 325)
            {
                timer1.Stop();
                FormLoginEmpleado formLogin = new FormLoginEmpleado();
                formLogin.Show();
                this.Hide();
            }
        }

    }
}
