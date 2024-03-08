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
    public static class ControladorProducto
    {
        public static List<Producto> listaProducto = new List<Producto>();

        public static void EscribirProducto()
        {
            try
            {
                using (var writer = new StreamWriter("productos.xml"))
                {
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaProducto.GetType());
                    serializer.Serialize(writer, listaProducto, namespaces);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error escribiendo xml de productos" + e.Message);
            }
        }

        public static List<Producto> ObtenerListaProductos()
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Producto";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Producto producto = new Producto(
                            reader["Id"].ToString(),
                            reader["Nombre"].ToString(),
                            Convert.ToDouble(reader["Precio"]),
                            reader["Categoria"].ToString(),
                            Convert.ToDateTime(reader["Fecha"])
                        );

                        productos.Add(producto);
                    }

                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener productos desde la base de datos: " + ex.Message);
            }

            return productos;
        }

        public static bool ProductoIdExistente(string id)
        {
            return listaProducto.Any(prod => prod.Id == id);
        }

        public static string ConstruirCadenaConexión()
        {
            string databaseFileName = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"../../DatabaseLaTaza.mdf"));
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename ={databaseFileName}; Integrated Security = True";
            MessageBox.Show("Cadena de conexión: " + connectionString);
            return connectionString;

        }

        public static void InsertarProducto(Producto producto)
        {
            try
            {
                string connectionString = ConstruirCadenaConexión();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Producto (Id, Nombre, Precio, Categoria, Fecha, Cantidad) " +
                                   "VALUES (@Id, @Nombre, @Precio, @Categoria, @Fecha, @Cantidad)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", producto.Id);
                    command.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    command.Parameters.AddWithValue("@Precio", producto.Precio);
                    command.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    command.Parameters.AddWithValue("@Fecha", producto.Fecha);
                    command.Parameters.AddWithValue("@Cantidad", producto.Cantidad);

                    connection.Open();
                    int registrosAfectados = command.ExecuteNonQuery();
                    MessageBox.Show($"Se insertó correctamente el producto. Registros afectados: {registrosAfectados}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar producto en la base de datos: " + ex.Message);
            }
        }

    }
}
