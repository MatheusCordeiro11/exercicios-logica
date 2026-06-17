/*
6. Ler 10 valores e contar quantos estão no intervalo [10,20] e quantos deles estão fora deste
intervalo. Escrever o resultado das duas contagens.
*/

using System;

class exe6
{
    public static void Main(string[] args)
    {
        int dentro = 0, fora = 0, valor;
        for(int i = 0; i< 10; i++)
        {
            Console.WriteLine("Digite um valor:");
            valor = int.Parse(Console.ReadLine());
            if(valor >= 10 && valor <= 20)
            {
                dentro++;
            }
            else
            {
                fora++;
            }
        }
        Console.WriteLine($"Dos 10 valores lidos {dentro} estão dentro do intervalo de 10 a 20 e {fora} estão fora");
    }
}