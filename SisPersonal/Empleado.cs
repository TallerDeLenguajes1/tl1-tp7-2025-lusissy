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
        public char EstadoCivil { get; set; } // 'C' para casado
        public DateTime FechaIngreso { get; set; }
        public double SueldoBasico { get; set; }
        public Cargo CargoEmpleado { get; set; }

        public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil,
                        DateTime fechaIngreso, double sueldoBasico, Cargo cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            EstadoCivil = estadoCivil;
            FechaIngreso = fechaIngreso;
            SueldoBasico = sueldoBasico;
            CargoEmpleado = cargo;
        }

        // a.i) Antigüedad
        public int Antiguedad()
        {
            return DateTime.Now.Year - FechaIngreso.Year;
        }


        // a.ii) Edad
        public int Edad (){
            return DateTime.Now.Year - FechaNacimiento.Year;
        }

        // a.iii) Años hasta la jubilación
        public int AniosParaJubilarse(){
            return Math.Max(65 - Edad(), 0);
        }

        // b) Salario calculado
        public double Salario
        {
            get
            {
                double adicional = 0;

                // i) Por antigüedad
                int años = Antiguedad();
                if (años <= 20)
                    adicional += SueldoBasico * (0.01 * años);
                else
                    adicional += SueldoBasico * 0.25;

                // ii) Cargo Ingeniero o Especialista
                if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
                    adicional *= 1.5;

                // iii) Casado
                if (EstadoCivil == 'C' || EstadoCivil == 'c')
                    adicional += 150000;

                return SueldoBasico + adicional;
            }
        }

        // mostrar los datos 
        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre} {Apellido}");
            Console.WriteLine($"Edad: {Edad()}");
            Console.WriteLine($"Antigüedad: {Antiguedad()} años");
            Console.WriteLine($"Años hasta jubilarse: {AniosParaJubilarse()}");
            Console.WriteLine($"Cargo: {CargoEmpleado}");
            Console.WriteLine($"Salario total: ${Salario:F2}");
            Console.WriteLine("---------------------------");
        }
    }
}
