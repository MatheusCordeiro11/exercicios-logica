/*
7. Crie um programa que leia um caracter (tipo char) e mostre se:
- É uma letra do alfabeto maiúscula 
- É uma letra do alfabeto minúscula 
- É um número inteiro entre 0 e 9. 
*/
using System;

class exe7{
    public static void Main(string[] args){
        char letra;
        Console.WriteLine("== MAIÚSCULA OU MINÚSCULA ==");
        Console.WriteLine("Digite uma letra:");
        letra = char.Parse(Console.ReadLine());
        if(char.IsUpper(letra)){
            Console.WriteLine("É uma letra do alfabeto maiúscula");
        }
        else{
            Console.WriteLine("É uma letra do alfabeto minúscula");
        }
    }
}