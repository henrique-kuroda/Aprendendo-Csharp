/*
Exercicio 015
Faça um Programa que pergunte quanto você ganha por hora e o número de horas trabalhadas no mês.

Calcule e mostre o total do seu salário no referido mês, sabendo-se que são descontados 11% para o Imposto de Renda,
8% para o INSS e 5% para o sindicato, faça um programa que nos dê: salário bruto. quanto pagou ao INSS. 
quanto pagou ao sindicato. o salário líquido. calcule os descontos e o salário líquido, conforme a tabela abaixo:

+Salário Bruto: R$
-IR(11 %) : R$
- INSS (8%) : R$
- Sindicato ( 5%) : R$
= Salário Liquido : R$
Obs.: Salário Bruto - Descontos = Salário Líquido.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe quanto você ganha por hora: ");
        double ganhoHora = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o número de horas trabalhadas no mês: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine());

        double salarioBruto = ganhoHora * horasTrabalhadas;
        double impostoRenda = salarioBruto * (0.11);
        double inss = salarioBruto * (0.08);
        double sindicato = salarioBruto * (0.05);
        double salarioLiquido = salarioBruto - (impostoRenda + inss + sindicato);

        Console.WriteLine($"O salário Bruto total foi de: R${salarioBruto:F2}. Foram descontados as seguintes taxas:\nImposto de Renda: R${impostoRenda:F2}" +
            $"\nINSS: R${inss:F2}\nSindicato: R${sindicato:F2}\nTotalizando um salário liquído de: R$ {salarioLiquido:F2}");


    }
}