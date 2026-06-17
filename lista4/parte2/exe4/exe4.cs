/*
4. Faça um algoritmo que imprima a tabuada do 8 utilizando uma estrutura de repetição.
*/

using System;

class exe4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("== TABUADA DO 8 ==");
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i} * 8 = {i * 8}");
        }
    }
}