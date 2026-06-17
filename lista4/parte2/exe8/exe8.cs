/*
8. Faça um algoritmo que receba uma sequência de números e retorne o maior e o menor número
da sequência. A quantidade de números n é fornecida pelo usuário.
*/
using System;

class exe8
{
    public static void Main(string[] args)
    {
        int n, num, menor = int.MaxValue, maior = int.MinValue ;
        Console.WriteLine("Digite o valor de n:");
        n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Digite um número:");
            num = int.Parse(Console.ReadLine());
            if(num <= menor)
            {
                menor = num;
            }
            else if(num >= maior)
            {
                maior = num;
            }
        }
        Console.WriteLine($"Da sequência de {n} números digitados, o menor foi {menor} e o maior foi {maior}");

    }
}