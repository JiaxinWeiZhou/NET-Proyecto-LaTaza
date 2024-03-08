using System;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormSaliendo : Form
    {
        public FormSaliendo()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 1;
            timer1.Start();
        }
                       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
