/*
5. Escreva um algoritmo que leia um número inteiro e imprima o valor 1 se o número 
informado for positivo, - 1 se for negativo e 0 se for zero. 
*/
using System;

class exe5{
    public static void Main(string[] args){
        int num;
        Console.WriteLine("== POSITIVO, NEGATIGO OU ZERO ==");
        Console.WriteLine("Digite um número inteiro:");
        num = int.Parse(Console.ReadLine());
        if(num == 0){
            Console.WriteLine("0");
        }
        else if(num > 0){
            Console.WriteLine("1");
        }
        else{
            Console.WriteLine("-1");
        }
    }
}