// See https://aka.ms/new-console-template for more information
using EspacioEmpleado;
Console.WriteLine("Hello, World!");
Empleado[] empleados = new Empleado[3];

        empleados[0] = new Empleado("Luis", "Sánchez", new DateTime(1970, 6, 10), 'C', new DateTime(2000, 5, 15), 700000, Empleado.Cargo.Ingeniero);
        empleados[1] = new Empleado("Ana", "Pérez", new DateTime(1985, 3, 20), 'S', new DateTime(2010, 7, 1), 650000, Empleado.Cargo.Administrativo);
        empleados[2] = new Empleado("Carlos", "Gómez", new DateTime(1965, 12, 5), 'C', new DateTime(1990, 1, 10), 800000, Empleado.Cargo.Especialista);

        double montoTotal = 0;
        Empleado proximoAJubilarse = empleados[0];

        Console.WriteLine("===== DATOS DE EMPLEADOS =====");
        foreach (var empleado in empleados)
        {
            empleado.MostrarDatos();
            montoTotal += empleado.Salario;

            if (empleado.AniosParaJubilarse() < proximoAJubilarse.AniosParaJubilarse())
            {
                proximoAJubilarse = empleado;
            }
        }

        Console.WriteLine($"\nMonto total en salarios: ${montoTotal:F2}\n");

        Console.WriteLine("Empleado más próximo a jubilarse:");
        proximoAJubilarse.MostrarDatos();