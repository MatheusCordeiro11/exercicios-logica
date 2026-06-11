/*4) Faça um algoritmo que solicita para o usuário um número inteiro n (digitado) e posteriormente
o sistema mostra o sucessor de n (ex. se o usuário digitou 15, o sistema deverá imprimir 16).*/

using System;

class exe4
{
    public static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite um número inteiro:");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"O sucessor do número {num} é o número {++num}");
    }
}
