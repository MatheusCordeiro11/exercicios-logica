/*
8. Crie uma versão para o programa da questão 2, de forma que o limite inferior e limite superior
sejam informador pelo usuário. Utilize a estrutura de Repetição (for).

2. Construa um algoritmo que escreva na tela do monitor os números ímpares de 0 a 50. Utilize
estrutura de repetição com teste no início (while).
*/
using System;

class exe8
{
    public static void Main(string[] args)
    {
        int comeco, fim;
        Console.WriteLine("== NÚMEROS ÍMPARES ==");
        Console.WriteLine("Digite o número para começar a lista:");
        comeco = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número para fechar a lista:");
        fim = int.Parse(Console.ReadLine());
        Console.WriteLine($"Lista de ímpares entre {comeco} e {fim}:");
        for(;fim >= comeco; comeco++)
        {
            if(comeco % 2 != 0)
            {
                Console.WriteLine(comeco);
            }
        }
    }
}
