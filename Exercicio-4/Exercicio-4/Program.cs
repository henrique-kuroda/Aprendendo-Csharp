//Faça um Programa que peça o raio de um círculo, calcule e mostre sua área.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe o raio do circulo para obter sua área: ");

        double raio = double.Parse(Console.ReadLine());
        double area = Math.Pow(raio,2) * Math.PI ;

        Console.WriteLine($"A área do circulo de raio {raio} é: {area:F2}");
    }
}
