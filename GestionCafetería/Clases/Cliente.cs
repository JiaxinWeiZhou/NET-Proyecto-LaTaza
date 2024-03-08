
namespace GestionCafetería.Clases
{
    public class Cliente
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public bool Seleccionado { get; set; }

        public Cliente(string id, string nombre, string telefono, string correo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public Cliente() { }
    }

}
