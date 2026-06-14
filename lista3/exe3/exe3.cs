/*
3. Construa um programa que escreva na tela do monitor de vídeo os números múltiplos de 4
entre 0 e 50. Utilize estrutura de repetição com teste no início (while).
*/
using System;

class exe3
{
    public static void Main(string[] args)
    {
        int num = 0;
        Console.WriteLine("== MÚLTIPLOS DE 4 ==");
        while(num <= 50)
        {
            if(num % 4 == 0)
            {
                Console.WriteLine($"Multiplo de 4: {num}");
            }
            num++;
        }
    }
}