/*6) faça um algoritmo que recebe a altura e peso de uma pessoa e calculo e o seu Índice de Massa
Corporal (IMC).
*/
using System;
using System.Globalization;

class exe6
{
    public static void Main(string[] args)
    {
        double altura, peso, imc;
        Console.WriteLine("-- CALCULO DE IMC --");
        Console.WriteLine("Digite sua altura:");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite seu peso:");
        peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        imc = peso / altura;
        Console.WriteLine($"Seu IMC é {imc.ToString("F2", CultureInfo.InvariantCulture)}.");
    }
}