/*
7. Uma loja de animais precisa de um algoritmo para calcular os custos de criação de coelhos.
O custo é calculado com a fórmula . O algoritmo tem como entrada
o número de coelhos, devendo fornecer, como saída, o custo.
*/
using System;
using System.Globalization;

class exe7
{
    public static void Main(string[] args)
    {
        double C;
        int nCoelhos;
        Console.WriteLine("Digite o número de coelhos:");
        nCoelhos = int.Parse(Console.ReadLine());
        C = ((nCoelhos * 0.70) / 18) + 10;
        Console.WriteLine($"{nCoelhos} coelhos tem o custo final de R$ {C.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}