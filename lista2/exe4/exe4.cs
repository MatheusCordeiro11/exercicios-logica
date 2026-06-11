/*
4.Crie um algoritmo que leia números e mostre o maior, o menor e 
indique o elemento do meio dentre os três números.
*/

using System;

class exe4{
    public static void Main(string[] args){
        int num1, num2, num3, maior, meio, menor;
        string[] valores;
        Console.WriteLine("== MAIOR, MEIO, MENOR ==");
        Console.WriteLine("Digite 3 números inteiros:");
        valores = Console.ReadLine().Split(' ');
        num1 = int.Parse(valores[0]);
        num2 = int.Parse(valores[1]);
        num3 = int.Parse(valores[2]);
        if(num1 >= num2 && num1 >= num3){
            maior = num1;
            if(num2 >= num3){
                meio = num2;
                menor = num3;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
            else{
                meio = num3;
                menor = num2;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
        }
        else if(num2 >= num1 && num2 >= num3){
            maior = num2;
            if(num1 >= num3){
                meio = num1;
                menor = num3;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
            else{
                meio = num3;
                menor = num1;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
        }
        else{
            maior = num3;
            if(num1 >= num2){
                meio = num1;
                menor = num2;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
            else{
                meio = num2;
                menor = num1;
                Console.WriteLine($"MAIOR:{maior}/MEIO:{meio}/MENOR:{menor}");
            }
        }
    }
}