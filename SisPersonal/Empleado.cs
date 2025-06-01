namespace EspacioEmpleado
{
    public class Empleado
    {
        public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public char EstadoCivil { get; set; }
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargo CargoEmpleado { get; set; }
        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
        DateTime fechaIngreso, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            CargoEmpleado = cargo;
        }
    }
}