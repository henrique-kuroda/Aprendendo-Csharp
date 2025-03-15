//Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.
//Calcule e mostre o total do seu salário no referido mês.
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe quanto você ganha por hora: ");
        float ganho = float.Parse(Console.ReadLine());
        Console.WriteLine("Informe o número de horas que você trabalhou no mês: ");
        int horas = int.Parse(Console.ReadLine());

        float total = horas * ganho;

        Console.WriteLine($"Seu total ganho neste mês foi: R$ {total:F2}");

    }
}