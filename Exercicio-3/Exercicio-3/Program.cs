//Faça um Programa que converta metros para centímetros.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um valor em metro para ser convertido em centimetros: ");
        float metros = float.Parse(Console.ReadLine());

        float centimetros = metros * 100;
        Console.WriteLine($"O valor transformado para centímetros ficou: {centimetros} cm");
    }
}



