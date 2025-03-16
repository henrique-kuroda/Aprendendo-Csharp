//Faça um Programa que peça 2 números inteiros e um número real. Calcule e mostre: o produto do dobro do primeiro com metade do segundo.
//a soma do triplo do primeiro com o terceiro. o terceiro elevado ao cubo.
using System;

class Program {
    static void Main(string[] args){
        Console.WriteLine("Informe dois números inteiros: ");
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Agora informe um número real: ");
        float real = float.Parse(Console.ReadLine());

        float produto = (2 * n1) * (n2 / 2.0f);
        float soma = (3 * n1) + real;
        float cubo = (real * real * real);

        Console.WriteLine($"O produto do dobro do primeiro com metade do segundo é: {produto}");
        Console.WriteLine($"A soma do triplo do primeiro com o terceiro é: {soma}");
        Console.WriteLine($"O terceiro elevado ao cubo é: {cubo}");

    }
}
    