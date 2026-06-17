/*
3. Faça um algoritmo que lê o código da peça 1, a quantidade vendida de peças 1, o valor unitário
da peça 1, o código da peça 2, a quantidade vendida de peças 2, o valor unitário da peça 2 e
a porcentagem do IPI a ser acrescentada. O algoritmo deve calcular o valor total a ser pago.
*/
using System;
using System.Globalization;

class exe3
{
    public static void Main(string[] args)
    {
        string[] peca1, peca2;
        int porcentagem, qPeca1, qPeca2;
        double SubvalorFinal, valorFinal, valorPeca1, valorPeca2;
        Console.WriteLine("Digite o código da peça 1, a quantidade vendida e o valor unitário. (Separados por /)");
        Console.WriteLine("Exemplo: 12154/5/21.45");
        peca1 = Console.ReadLine().Split("/");
        qPeca1 = int.Parse(peca1[1]);
        valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o código da peça 2, a quantidade vendida e o valor unitário. (Separados por /)");
        Console.WriteLine("Exemplo: 12154/5/21.45");
        peca2 = Console.ReadLine().Split("/");
        qPeca2 = int.Parse(peca2[1]);
        valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);
        Console.WriteLine("Agora digite a porcentagem do IPI:");
        porcentagem = int.Parse(Console.ReadLine());
        SubvalorFinal = (qPeca1 * valorPeca1) + (qPeca2 * valorPeca2);
        valorFinal = SubvalorFinal + ((SubvalorFinal * porcentagem ) / 100);
        Console.WriteLine($"O valor final a se pagar em todas as peças são de R$ {valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}