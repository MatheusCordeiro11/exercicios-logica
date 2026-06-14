/*
6. Faça um algoritmo que calcule o fatorial de um número informado pelo usuário.
Ex. 5! = 5x4x3x2x1 = 120
*/
using System;

class exe6
{
    public static void Main(string[] args)
    {
        int num, value;
        Console.WriteLine("== CALCULA FATORIAL ==");
        Console.WriteLine("Digite um número inteiro para o fatorial:");
        num = int.Parse(Console.ReadLine());
        value = num;
        do
        {
            num--;
            value *=  num;
        }while(num >= 2);
        Console.WriteLine($"Resultado:{value}");
    }
}