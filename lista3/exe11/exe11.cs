/*
11. Crie uma versão do programa anterior, de forma que possa ser lido um número
indeterminado de salários. Para isto, deverá ser utilizada uma flag: salário igual a zero.
*/
using System;
using System.Globalization;

class exe10
{
    public static void Main(string[] args)
    {
        double salario, maiorSalario = 0, totalSalarios = 0, mediaSalario;
        int quantidade;
        Console.WriteLine("== CÁLCULO SALÁRIOS ==");
        Console.WriteLine("Digite a quantidade de salarios a serem lidos:");
        quantidade = int.Parse(Console.ReadLine());
        for(int i = 0; i < quantidade; i++)
        {
            do
            {
                Console.WriteLine($"Digite o {i+1}° salário:");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }while(salario <= 0);
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