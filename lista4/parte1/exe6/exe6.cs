/*
6. Faça um algoritmo para calcular a área de um triângulo, exibindo o resultado final. A base e
a altura são dados que devem ser lidos com a entrada. Lembrem-se de validar os dados.
*/
using System;

class exe6
{
    public static void Main(string[] args)
    {
        int altura, A, Base;
        Console.WriteLine("Digite o valor da base do triângulo:");
        Base = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do triângulo:");
        altura = int.Parse(Console.ReadLine());
        A = (Base * altura) / 2;
        Console.WriteLine($"A área do triângulo de base {Base} e altura {altura} é {A}.");
    }
}