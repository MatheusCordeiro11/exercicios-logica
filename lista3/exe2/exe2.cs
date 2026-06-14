/*
2. Construa um algoritmo que escreva na tela do monitor os números ímpares de 0 a 50. Utilize
estrutura de repetição com teste no início (while).
*/
using System;

class exe2
{
    public static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine("== LISTA IMPARES ==");
        while(num <= 50)
        {
            if(num % 2 != 0)
            {
                Console.WriteLine($"Valor:{num}");
            }
            num++;
        }
    }
}