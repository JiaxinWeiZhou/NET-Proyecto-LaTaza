using System;


namespace GestionCafetería.Clases
{
    public class Ticket
    {
        public int Codigo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public double Precio { get; set; }

        public Ticket(int codigo, DateTime fechaCreacion, double precio)
        {
            Codigo = codigo;
            FechaCreacion = fechaCreacion;
            Precio = precio;
        }

        public Ticket()
        {
        }
    }

}
