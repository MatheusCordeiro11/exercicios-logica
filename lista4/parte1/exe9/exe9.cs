/*
9. Faça um algoritmo que leia a idade de uma pessoa em anos, meses e dias e mostre-a expressa
em dias. (Nota: considere todos os anos com 365 dias e todos os meses com 30 dias).
*/
using System;

class exe9
{
    public static void Main(string[] args)
    {
        int diasTotais = 0, anos, meses, dias;
        string[] idade;
        Console.WriteLine("== IDADE EM DIAS ==");
        Console.WriteLine("Digite sua idade em anos/meses/dias:");
        Console.WriteLine("Exemplo: aa/mm/dd");
        idade = Console.ReadLine().Split("/");
        anos = int.Parse(idade[0]);
        meses = int.Parse(idade[1]);
        dias = int.Parse(idade[2]);
        diasTotais += anos * 365;
        diasTotais += meses * 30;
        diasTotais += dias;
        Console.WriteLine($"Sua idade em dias é {diasTotais}");

    }
}