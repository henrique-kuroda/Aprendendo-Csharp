//Faça um Programa que peça dois números e imprima a soma.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Insira os dois números que deseja obter a soma: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        int soma = n1 + n2;

        Console.WriteLine($"O resultado da soma dos dois valores foi: {soma}");
    }
}