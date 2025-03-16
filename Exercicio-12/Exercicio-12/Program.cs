//Tendo como dados de entrada a altura de uma pessoa, construa um algoritmo que calcule seu peso ideal, usando a seguinte fórmula:
//(72.7*altura) - 58
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira sua altura em metros para descobrir seu peso ideal: ");
        float altura = float.Parse(Console.ReadLine());

        double peso_ideal = (72.7 * altura) - 58;

        Console.WriteLine($"O peso ideal para uma pessoa de altura {altura} m é de: {peso_ideal:F2} kg");
    }
}