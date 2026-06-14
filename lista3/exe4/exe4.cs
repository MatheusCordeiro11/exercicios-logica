/*
4. Construa um programa que escreva na tela do monitor de vídeo os números inteiros de 70 até
40 (ordem decrescente). Utilize estrutura de repetição com teste no início (while). Mostre o valor
da soma dos números.
*/
using System;

class exe4
{
    public static void Main(string[] args)
    {
        int num = 70, soma = 0;
        Console.WriteLine("== ORDEM DESCRESCENTE 70 A 40 ==");
            while(num >= 0)
            {
                Console.WriteLine(num);
                soma += num;
                num--;
            }
        Console.WriteLine($"Soma final:{soma}");
    }
}