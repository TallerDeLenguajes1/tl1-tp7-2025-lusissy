using EspacioCalculadora;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora nuevo=new Calculadora();
nuevo.Sumar(22);
nuevo.Sumar(10);
Console.WriteLine($"El resultado es: {nuevo.GetResultado()}");