using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using GestionCafetería.Clases;

namespace GestionCafetería.Controladores
{
    public class ControladorCliente
    {
        public static List<Cliente> listaCliente = new List<Cliente>();

        public static List<Cliente> EscribirCliente()
        {
            try
            {
                if (File.Exists("clientes.json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaCliente);
                    File.WriteAllText("clientes.json", jsonString);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return listaCliente;
        }

        public static List<Cliente> ObtenerListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();

            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Cliente";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente(
                            reader["Id"].ToString(),
                            reader["Nombre"].ToString(),
                            reader["Telefono"].ToString(),
                            reader["Correo"].ToString()
                        );

                        clientes.Add(cliente);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener clientes desde la base de datos: " + ex.Message);
            }

            return clientes;
        }

        public static bool ClienteIdExistente(string id)
        {
            return listaCliente.Any(cli => cli.Id == id);
        }

        public static string ConstruirCadenaConexión()
        {
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../DatabaseLaTaza.mdf"));
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;

        }
        public static void InsertarCliente(Cliente cliente)
        {
            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Cliente (Id, Nombre, Telefono, Correo) " +
                                   "VALUES (@Id, @Nombre, @Telefono, @Correo)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", cliente.Id);
                    command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    command.Parameters.AddWithValue("@Correo", cliente.Correo);

                    connection.Open();
                    int registrosAfectados = command.ExecuteNonQuery();
                    MessageBox.Show($"Se insertó correctamente el cliente. Registros afectados: {registrosAfectados}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar empleado en la base de datos: " + ex.Message);
            }
        }
    }
}
