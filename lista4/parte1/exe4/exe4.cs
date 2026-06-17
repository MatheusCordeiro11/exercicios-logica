/*
4. Um usuário digita três números a, b e c. Faça um algoritmo que calcule a média e o desvio
padrão destes três números. A média é definida como . O desvio padrão é dado
por D =
*/
using System;
using System.Globalization;

class exe4
{
    public static void Main(string[] args)
    {
        int a, b, c;
        double M, D;
        Console.WriteLine("Digite o valor a:");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor b:");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor c:");
        c = int.Parse(Console.ReadLine());
        M = (a + b + c) / 3;
        D = Math.Sqrt((Math.Pow(a - M, 2) + Math.Pow(b - M, 2) + Math.Pow(c - M, 2)) / 2);
        Console.WriteLine($"A média dos valores {a}, {b} e {c} são {M.ToString("F1",CultureInfo.InvariantCulture)} e o desvio é de {D.ToString("F1",CultureInfo.InvariantCulture)}");
    }
}