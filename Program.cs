//Exercicio 002
//Faça um Programa que peça um número e então mostre a mensagem O número informado foi [número].

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"O número informado foi {num}");
    }
}