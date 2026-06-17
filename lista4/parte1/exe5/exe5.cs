/*
5. Faça um algoritmo que calcule e mostre a área de um trapézio. Sabe-se que a área é definida
por:
A = ((basemaior + basemenor) × altura)/2.
*/
using System;

class exe5
{
    public static void Main(string[] args)
    {
        int baseMaior, baseMenor, altura, A;
        Console.WriteLine("Para calcular um trapézio");
        Console.WriteLine("Digite o valor da base maior:");
        baseMaior = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da base menor:");
        baseMenor = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura");
        altura = int.Parse(Console.ReadLine());
        A = ((baseMaior + baseMenor) * altura) / 2;
        Console.WriteLine($"A área do trapézio é {A}");
    }
}