/*
8) Faça um Programa em C que receba o número de horas trabalhadas de um funcionário e o
valor do salário mínimo (informados pelo usuário), calcule e mostre o salário a receber seguindo
estas regras:
a) a hora trabalhada vale um décimo do salário mínimo
b) o salário bruto equivale ao número de horas trabalhadas multiplicado pelo valor da hora
trabalhada.
c) o imposto equivale a 5% do salário bruto.
d) o salário a receber equivale ao salário bruto menos o imposto.
*/
using System;
using System.Globalization;

class exe8
{
    public static void Main(string[] args)
    {
        int horasTrabalhadas;
        double salarioMinimo, valorHoraTrabalhada, salarioBruto;
        Console.WriteLine("-- CALCULO DE PAGAMENTO DE SALÁRIO --");
        Console.WriteLine("Digite o número de horas trabalhadas pelo funcionário:");
        horasTrabalhadas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o salário mínimo do funcionário:");
        salarioMinimo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        valorHoraTrabalhada = horasTrabalhadas * (salarioMinimo / 10);
        salarioBruto = horasTrabalhadas * valorHoraTrabalhada;
        salarioBruto += salarioBruto * 0.05;
        Console.WriteLine($"O salário do funcionário final é de R${salarioBruto.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}