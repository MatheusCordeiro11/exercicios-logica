/*
5. Ler 10 valores e escrever quantos destes valores são negativos.
*/
using System;

class exe5
{
    public static void Main(string[] args)
    {   
        int valor, negativo = 0;
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Digite um valor:");
            valor = int.Parse(Console.ReadLine());
            if(valor < 0)
            {
                negativo++;
            }
        }
        Console.WriteLine($"Dos 10 valores lidos {negativo} são negativos.");
    }
}