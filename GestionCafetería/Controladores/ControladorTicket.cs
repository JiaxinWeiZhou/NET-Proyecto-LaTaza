using GestionCafetería.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GestionCafetería.Controladores
{
    public class ControladorTicket
    {
        public static List<Ticket> listaTicket = new List<Ticket>();

        public static void EscribirTicket(Ticket ticket, double precioTotal)
        {
            try
            {
                ticket.Codigo = ObtenerUltimoCodigo() + 1;
                ticket.FechaCreacion = DateTime.Now;
                ticket.Precio = precioTotal; 

                listaTicket.Add(ticket);

                using (StreamWriter sw = File.AppendText("ticket.txt"))
                {
                    string linea = $"{ticket.Codigo};{ticket.FechaCreacion};{ticket.Precio}";
                    sw.WriteLine(linea);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al guardar el ticket: {ex.Message}");
            }
        }

        public static List<Ticket> LeerTickets()
        {
            try
            {
                if (File.Exists("ticket.txt"))
                {
                    listaTicket = File.ReadLines("ticket.txt")
                        .Select(linea =>
                        {
                            string[] campos = linea.Split(';');
                            return new Ticket
                            {
                                Codigo = int.Parse(campos[0]),
                                FechaCreacion = DateTime.Parse(campos[1]),
                                Precio = double.Parse(campos[2])
                            };
                        })
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer los tickets: {ex.Message}");
            }

            return listaTicket;
        }

        public static int ObtenerUltimoCodigo()
        {
            int ultimoCodigo = 0;

            if (listaTicket.Count > 0)
            {
                ultimoCodigo = listaTicket.Max(ticket => ticket.Codigo);
            }

            return ultimoCodigo;
        }
    }
}
