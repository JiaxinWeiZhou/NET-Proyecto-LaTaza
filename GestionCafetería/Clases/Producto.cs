using System;

namespace GestionCafetería.Clases
{
    public class Producto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Categoria { get; set; }
        public DateTime Fecha { get; set; }
        public bool Seleccionado { get; set; }
        public int Cantidad { get; set; }

        public Producto(string id,string nombre , double precio, string categoria, DateTime fecha)
        {
            Nombre = nombre;
            Id = id;
            Precio = precio;
            Categoria = categoria;
            Fecha = fecha;
        }

        public Producto()
        {
        }

    }
}
