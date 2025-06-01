using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora nuevo=new Calculadora();
string? opcion = "";

Console.WriteLine("Calculadora");
Console.WriteLine("\nComandos: sumar, restar, multiplicar, dividir, limpiar, salir");

    while (true)
    {
         Console.Write("\nIngrese comando: ");
         opcion = Console.ReadLine()?.ToLower();

        if (opcion == "salir") break;

        if (opcion == "limpiar")
        {
            nuevo.Limpiar();
            Console.WriteLine("Resultado limpiado.");
            continue;
        }

        Console.Write("Ingrese valor: ");
        if (!double.TryParse(Console.ReadLine(), out double valor))
        {
            Console.WriteLine("Valor inválido.");
            continue;
        }

        switch (opcion)
        {
            case "sumar":
                nuevo.Sumar(valor);
                break;
            case "restar":
                nuevo.Restar(valor);
                break;
            case "multiplicar":
                nuevo.Multiplicar(valor);
                break;
            case "dividir":
                nuevo.Dividir(valor);
                break;
            default:
                Console.WriteLine("Comando no reconocido.");
                continue;
        }

        Console.WriteLine($"Resultado actual: {nuevo.Resultado}");
    }

Console.WriteLine("Programa terminado.");