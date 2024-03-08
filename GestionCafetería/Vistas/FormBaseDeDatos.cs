using GestionCafetería.Controladores;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionCafetería.Vistas
{
    public partial class FormBaseDeDatos : Form
    {
        public FormBaseDeDatos()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FormInicioAdmin inicio = new FormInicioAdmin();
            inicio.Show();
            this.Close();
        }

        private void FormBaseDeDatos_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.databaseLaTazaDataSet1.Producto);
            this.clienteTableAdapter.Fill(this.databaseLaTazaDataSet3.Cliente);
            this.empleadoTableAdapter.Fill(this.databaseLaTazaDataSet2.Empleado);
            this.administradorTableAdapter.Fill(this.databaseLaTazaDataSet.Administrador);
            
            dgvEmpleados.ReadOnly = true;
            dgvClientes.ReadOnly = true;
            dgvProductos.ReadOnly = true;

            administradoresDataTable = ControladorAdministrador.ObtenerAdministradores();
            dgvAdministradores.DataSource = administradoresDataTable;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvAdministradores.SelectedRows.Count > 0)
            {
                int rowIndex = dgvAdministradores.SelectedRows[0].Index;

                int idColumnIndex = -1;
                for (int i = 0; i < dgvAdministradores.Columns.Count; i++)
                {
                    if (dgvAdministradores.Columns[i].HeaderText == "Id")
                    {
                        idColumnIndex = i;
                        break;
                    }
                }

                if (idColumnIndex != -1)
                {
                    string idSeleccionado = dgvAdministradores.Rows[rowIndex].Cells[idColumnIndex].Value.ToString();

                    DialogResult resultado = MessageBox.Show("¿Está seguro de eliminar esta entrada de la base de datos?",
                                                              "Eliminar entrada",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (ControladorAdministrador.EliminarAdministrador(idSeleccionado))
                        {
                            dgvAdministradores.Rows.RemoveAt(rowIndex);
                            MessageBox.Show("Entrada eliminada correctamente.");                            
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la entrada.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el Id.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una entrada entera para eliminar.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable administradoresDataTable;

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

            if (ControladorAdministrador.ActualizarAdministradores(administradoresDataTable))
            {
                MessageBox.Show("Cambios guardados correctamente.");
            }
            else
            {
                MessageBox.Show("Error al guardar los cambios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizarE_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = ControladorEmpleado.ObtenerListaEmpleados();

        }

        private void btnActualizarC_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = ControladorCliente.ObtenerListaClientes();

        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = ControladorProducto.ObtenerListaProductos();
        }
    }
}
