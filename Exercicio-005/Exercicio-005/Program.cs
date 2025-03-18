//Faça um Programa que converta metros para centímetros.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um valor em metros para transformar em cm: ");
        float metros = float.Parse(Console.ReadLine());

        float cm = metros * 100;

        Console.WriteLine($"Na conversão {metros} m são iguais a {cm} cm");
    }
}