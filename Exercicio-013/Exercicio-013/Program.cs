/*
Exercicio 013
Tendo como dado de entrada a altura (h) de uma pessoa, construa um algoritmo que calcule seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7h) - 58 Para mulheres: (62.1h) - 44.7
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Para descobrir o seu peso ideal informe a sua altura em m: ");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Para homens digite (h) e para mulheres digite (m)");
        char option = char.Parse(Console.ReadLine());

        double resultado;
        if(option == 'h' || option == 'H'){
            resultado = (72.7 * altura) - 58;
            Console.WriteLine($"O seu peso ideal é: {resultado:F2}kg");
        }
        else if(option == 'm' || option == 'M'){
            resultado = (62.1 * altura) - 44.7;
            Console.WriteLine($"O seu peso ideal é: {resultado:F2}kg");
        }
        else{
            Console.WriteLine("Opção inválida!");
        }

    }
}
