/*5) Faça um algoritmo que solicita o valor de 3 notas (n1, n2 e n3) e depois mostra: a soma, a
média e o produto das notas.*/

using System;
using System.Globalization;

class exe5
{
    public static void Main(string[] args)
    {
        double n1, n2, n3, soma, media, produto;
        Console.WriteLine("SISTEMA DE NOTAS");
        Console.WriteLine("Digite a nota 1 do aluno:");
        n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a nota 2 do aluno:");
        n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite a nota 3 do aluno:");
        n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        soma = n1 + n2 + n3;
        media = (n1 + n2 + n3) / 3;
        produto = n1 * n2 * n3;
        Console.WriteLine($"RESULTADO FINAL:\nSoma:{soma}\nMedia:{media}\nProduto:{produto}");

    }
}