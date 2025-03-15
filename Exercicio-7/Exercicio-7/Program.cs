//Faça um Programa que calcule a área de um quadrado, em seguida mostre o dobro desta área para o usuário.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe as dimensões do quadrado: ");
        float altura = float.Parse(Console.ReadLine());
        float largura = float.Parse(Console.ReadLine());

        float area = altura * largura;

        Console.WriteLine($"A área do quadrado é {area} e seu dobro é {area * 2}");

    }
}
