using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using GestionCafetería.Clases;

namespace GestionCafetería.Controladores
{
    public static class ControladorEmpleado
    {
        public static List<Empleado> listaEmpleado = new List<Empleado>();

        public static string ConstruirCadenaConexión()
        {
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../DatabaseLaTaza.mdf"));
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;

        }

        public static bool ValidarEmpleado(string nombre, string contrasena)
        {
            using (SqlConnection connection = new SqlConnection(ConstruirCadenaConexión()))
            {
                string query = "SELECT COUNT(*) FROM Empleado WHERE Nombre = @Nombre AND Contrasena = @Contrasena";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Contrasena", contrasena);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        public static void EscribirEmpleados()
        {
            try
            {
                using (var writer = new StreamWriter("empleados.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaEmpleado.GetType());
                    serializer.Serialize(writer, listaEmpleado, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml empleados" + e.Message);
            }
        }

        public static List<Empleado> ObtenerListaEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Empleado";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // Crear un objeto Empleado con los datos del DataReader
                        Empleado empleado = new Empleado(
                            reader["Nombre"].ToString(),
                            reader["Correo"].ToString(),
                            reader["Contrasena"].ToString(),
                            reader["IdEmpleado"].ToString(),
                            Convert.ToDouble(reader["Salario"])
                        );

                        empleados.Add(empleado);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener empleados desde la base de datos: " + ex.Message);
            }

            return empleados;
        }


        public static bool EmpleadoIdExistente(string id)
        {
            return listaEmpleado.Any(emp => emp.IdEmpleado == id);
        }

        public static void InsertarEmpleado(Empleado empleado)
        {
            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Empleado (Nombre, Contrasena, Correo, IdEmpleado, Salario) " +
                                   "VALUES (@Nombre, @Contrasena, @Correo, @IdEmpleado, @Salario)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                    command.Parameters.AddWithValue("@Contrasena", empleado.Contrasena);
                    command.Parameters.AddWithValue("@Correo", empleado.Correo);
                    command.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                    command.Parameters.AddWithValue("@Salario", empleado.Salario);

                    connection.Open();
                    int registrosAfectados = command.ExecuteNonQuery();
                    MessageBox.Show($"Se insertó correctamente el empleado. Registros afectados: {registrosAfectados}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar empleado en la base de datos: " + ex.Message);
            }
        }

    }
}
