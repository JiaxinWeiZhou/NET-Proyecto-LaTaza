using GestionCafetería.Clases;
using GestionCafetería.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormListaEmpleados : Form
    {
        public FormListaEmpleados()
        {
            InitializeComponent();

            listViewEmpleados.View = View.Details;

            listViewEmpleados.Columns.Add("ID", 80);
            listViewEmpleados.Columns.Add("Nombre", 120);
            listViewEmpleados.Columns.Add("Correo", 170);
            listViewEmpleados.Columns.Add("Salario", 150);

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            List<Empleado> empleados = ControladorEmpleado.ObtenerListaEmpleados();

            listViewEmpleados.Items.Clear();

            foreach (Empleado empleado in empleados)
            {
                ListViewItem item = new ListViewItem(empleado.IdEmpleado);

                item.SubItems.Add(empleado.Nombre);
                item.SubItems.Add(empleado.Correo);
                item.SubItems.Add(empleado.Salario.ToString());

                listViewEmpleados.Items.Add(item);
            }
        }

        private void FormListaEmpleados_Load(object sender, EventArgs e)
        {
            ControladorEmpleado.ObtenerListaEmpleados();
        }
    }
}
