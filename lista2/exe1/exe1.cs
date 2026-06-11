/*
1.Identificar se um inteiro lido é par ou não. Se o número for menor ou 
igual a zero, informe ao usuário que o número deve ser maior que zero.
*/

using System;

class exe1{
    public static void Main(string[] args){
        int num;
        Console.WriteLine("== VERIFICA SE É PAR OU ÍMPAR ==");
        Console.WriteLine("Digite um valor inteiro:");
        num = int.Parse(Console.ReadLine());
        if(num <= 0){
            Console.WriteLine("Digite um valor positivo!");
        }
        else{
            if(num % 2 == 0){
                Console.WriteLine($"O número {num} é par!");
            }
            else{
                Console.WriteLine($"O número {num} é Ímpar!");
            }
        }
    }
}