using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using GestionCafetería.Clases;

namespace GestionCafetería.Controladores
{
    public class ControladorAdministrador
    {
        public static string ConstruirCadenaConexión()
        {
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../DatabaseLaTaza.mdf"));
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;

        }

        public static bool ValidarAdmin(string nombre, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
            {
                string query = "SELECT COUNT(*) FROM Administrador WHERE Nombre = @Nombre AND Contrasena = @Contrasena";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Contrasena", contrasena);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }
        public static void InsertarAdmin(Administrador admin)
        {
            string query = "INSERT INTO Administrador (Id, Nombre, Contrasena, Correo, Cargo, NumEmpleados) " +
                                  "VALUES (@Id, @Nombre, @Contrasena, @Correo, @Cargo, @NumEmpleados)";

            using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
            {
                connection.Open();
                   
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", admin.Id);
                command.Parameters.AddWithValue("@Nombre", admin.Nombre);
                command.Parameters.AddWithValue("@Contrasena", admin.Contrasena);
                command.Parameters.AddWithValue("@Correo", admin.Correo);
                command.Parameters.AddWithValue("@Cargo", admin.Cargo);
                command.Parameters.AddWithValue("@NumEmpleados", admin.NumEmpleados);
                try
                {
                    int registrosAfectados = command.ExecuteNonQuery();
                    MessageBox.Show($"Se insertó correctamente el registro. Registros afectados: {registrosAfectados}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al insertar el registro: {ex.Message}");
                }

            }
        }

        public static bool AdminIdExistente(string id)
        {
            using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Administradores WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al verificar si el ID de administrador existe en la base de datos: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool EliminarAdministrador(string id)
        {
            bool resultado = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
                {
                    connection.Open();
                    string query = "DELETE FROM Administrador WHERE Id = @Id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", id);
                    int filasEliminadas = command.ExecuteNonQuery();

                    if (filasEliminadas == 0)
                    {
                        resultado = false;
                    }

                    command.Dispose();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar el administrador: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }

        public static DataTable ObtenerAdministradores()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
                {
                    string query = "SELECT * FROM Administrador";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    dataAdapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener administradores: " + ex.Message);
            }

            return dataTable;
        }

        public static bool ActualizarAdministradores(DataTable dataTable)
        {
            bool resultado = true;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
                {
                    string selectQuery = "SELECT * FROM Administrador";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Update(dataTable);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar administradores: " + ex.Message);
                resultado = false;
            }

            return resultado;
        }
    }
}
