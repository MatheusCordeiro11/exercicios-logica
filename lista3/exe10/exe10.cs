/*
10. Faça um programa que leia o salário de 10 funcionários. Ao final, informar na tela do monitor:
• o total dos salários;
• o salário médio;
• o valor do maior salário.
*/
using System;
using System.Globalization;

class exe10
{
    public static void Main(string[] args)
    {
        double salario, maiorSalario = 0, totalSalarios = 0, mediaSalario;
        Console.WriteLine("== CÁLCULO SALÁRIOS ==");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Digite o {i+1}° salário:");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if(salario >= maiorSalario)
            {
                maiorSalario = salario;
            }
            totalSalarios += salario;
        }
        mediaSalario = totalSalarios / 10;
        Console.WriteLine($"O total dos salários:R$ {totalSalarios.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"O salário médio:R$ {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"O valor do maior salário:R$ {maiorSalario.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}