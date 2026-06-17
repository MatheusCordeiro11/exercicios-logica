/*
2. Faça um algoritmo para ler dois inteiros (variáveis A e B) e efetuar as operações de adição,
subtração, multiplicação e divisão de A por B apresentando ao final os quatro resultados
obtidos.
*/
using System;

class exe2
{
    public static void Main(string[] args)
    {
        int A, B;
        string[] valores;
        Console.WriteLine("== OPERAÇÕES BÁSICAS ==");
        Console.WriteLine("Digite dois números inteiros:");
        valores = Console.ReadLine().Split(' ');
        A = int.Parse(valores[0]);
        B = int.Parse(valores[1]);
        Console.WriteLine($"Soma: {A+B}");
        Console.WriteLine($"Subtração: {A-B}");
        Console.WriteLine($"Multiplicação: {A*B}");
        if(A == 0)
        {
            Console.WriteLine("Não é possível fazer divisão por 0.");
        }
        else
        {
            Console.WriteLine($"Divisão: {A/B}");

        }

    }
}