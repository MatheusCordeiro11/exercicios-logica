/*
12. Crie um algoritmo que leia um número real (float) e mostre sua parte inteira e sua parte
fracionária.
*/
using System;
using System.Globalization;

class exe12
{
    public static void Main(string[] args)
    {
        double num, inteiro, fracionado;
        Console.WriteLine("== PARTE INTEIRA E FRACIONÁDA ==");
        Console.WriteLine("Digite um número real:");
        num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        inteiro = Math.Truncate(num);
        fracionado = num - Math.Truncate(num);
        Console.WriteLine($"PARTE INTEIRA: {inteiro.ToString("F0", CultureInfo.InvariantCulture)}");
        Console.Write($"PARTE FRACIONADA: {fracionado.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}