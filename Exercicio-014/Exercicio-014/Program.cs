/*
Exercicio 014
 João Papo-de-Pescador, homem de bem, comprou um microcomputador para controlar o rendimento diário de seu trabalho.
 Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de São Paulo (50 quilos)
deve pagar uma multa de R$ 4,00 por quilo excedente.
 João precisa que você faça um programa que leia a variável peso (peso de peixes) e calcule o excesso.
 Gravar na variável excesso a quantidade de quilos além do limite e na variável multa o valor da multa que João deverá pagar. 
 Imprima os dados do programa com as mensagens adequadas.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe quantos kilos de peixe foram pegos: ");
        int peso = int.Parse(Console.ReadLine());
        int multa;

        if (peso > 50)
        {
            int excesso = peso - 50;
            multa = excesso * 4;
            Console.WriteLine($"A quantidade de peixes excedeu o limite em {excesso} kg, totalizando uma multa de {multa} R$");
        }
        else
            Console.WriteLine("A quantidade de peso está dentro do limite");

    }
}