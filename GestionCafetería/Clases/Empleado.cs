namespace GestionCafetería.Clases
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Correo { get; set; }
        public string IdEmpleado { get;set; }
        public double Salario { get;set; }
        public bool Seleccionado { get; set; }

        public Empleado(string nombre, string contrasena, string correo, string idEmpleado, double salario)
        {
            Nombre = nombre;
            Contrasena = contrasena;
            Correo = correo;
            IdEmpleado = idEmpleado;
            Salario = salario;
        }

        public Empleado()
        {
        }
    }

}
