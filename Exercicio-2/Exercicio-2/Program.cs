//Faça um Programa que peça as 4 notas bimestrais e mostre a média.
using System;

public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Insira suas 4 notas bimestrais para obter a média: ");

        float n1 = float.Parse(Console.ReadLine());
        float n2 = float.Parse(Console.ReadLine());
        float n3 = float.Parse(Console.ReadLine());
        float n4 = float.Parse(Console.ReadLine());

        float media = (n1 + n2 + n3 + n4) / 4;

        Console.WriteLine($"A média das 4 notas foi: {media}");

    }
}