//Faça um Programa que peça a temperatura em graus Celsius, transforme e mostre em graus Fahrenheit.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma temperatura em graus Celsius para ser transformada em graus Fahrenheit: ");
        float celsius = float.Parse(Console.ReadLine());

        float fahrenheit = (9 * (celsius) / 5) + 32;

        Console.WriteLine($"A temperatura em graus Farenheit foi: {fahrenheit:F2} °F");
    }
}