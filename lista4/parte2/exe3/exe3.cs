/*
3. Faça um algoritmo para ler um valor N (validar para aceitar apenas valores positivos) e
imprimir os N primeiros números inteiros.
*/
using System;

class exe3
{
    public static void Main(string[] args)
    {
        int n;
        do
        {
            Console.WriteLine("Digite um valor n positivo:");
            n = int.Parse(Console.ReadLine());
        }while (n <= 0);
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}