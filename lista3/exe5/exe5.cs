/*
5. Construa um programa que escreva na tela do monitor de vídeo os anos bissextos que ocorreram
desde 1900 até 2022. Utilize estrutura de repetição com teste no final (do-while).
*/
using System;

class exe5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("== ANOS BISSEXTOS DE 1900 A 2022 ==");
        int ano = 1900;
        do
        {
            if(ano % 4 == 0)
            {
                Console.WriteLine($"{ano} foi um ano bissexto.");
            }
            ano++;
        }while(ano <= 2022);
    }
}