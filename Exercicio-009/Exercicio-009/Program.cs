//Faça um Programa que peça a temperatura em graus Farenheit, transforme e mostre a temperatura em graus Celsius. C = (5 * (F-32) / 9).
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe uma temperatura em Farenheit para ser transformada em graus Celsius: ");
        float farenheit = float.Parse(Console.ReadLine());

        float celsius = (5 * (farenheit - 32) / 9);

        Console.WriteLine($"A temperatura em graus Celsiu foi: {celsius:F2}");
    }
}
