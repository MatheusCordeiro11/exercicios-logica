/*
9. Faça um programa que mostre uma contagem na tela de 233 a 456, só que contando de 3 em 3
quando estiver entre 300 e 400 e de 5 em 5 quando não estiver entre 300 e 400.
*/
using System;

class exe9
{
    public static void Main(string[] args)
    {
        Console.WriteLine("== CONTAGEM ==");
        for(int i = 233; i <= 456;)
        {
            if(i >= 300 && i <= 400)
            {
                Console.WriteLine(i);
                i += 3;
            }
            else
            {
                 Console.WriteLine(i);
                i += 5;
            }
        }
    }
}