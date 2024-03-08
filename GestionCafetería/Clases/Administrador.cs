namespace GestionCafetería.Clases
{
    public class Administrador
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string Cargo { get; set; }
        public int NumEmpleados { get; set; }
        public bool Seleccionado { get; set; }

        public Administrador(string id, string nombre, string contrasena, string correo, string cargo, int numEmpleados)
        {
            Id = id;
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            Cargo = cargo;
            NumEmpleados = numEmpleados;
        }

        public Administrador()
        {
        }
    }
}
