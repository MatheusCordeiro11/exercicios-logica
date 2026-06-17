/*
1. Faça um algoritmo que lê o número de um funcionário, seu número de horas trabalhadas e o
valor que recebe por hora. O algoritmo deve calcular e mostrar o salário deste funcionário.
*/
using System;
using System.Globalization;

class exe1
{
    public static void Main(string[] args)
    {
        int numFuncionario, horasTrabalhadas;
        double valorHora, salario;
        Console.WriteLine("== CÁLCULO DE HORAS TRABALHADAS ==");
        Console.WriteLine("Digite seu número de acesso:");
        numFuncionario = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite seu número de horas trabalhadas:");
        horasTrabalhadas = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor que recebe por hora:");
        valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        salario = horasTrabalhadas * valorHora;
        Console.WriteLine($"O sálario a receber do funcionário {numFuncionario} é R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

    }
}