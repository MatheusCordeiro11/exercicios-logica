/*
Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A 
senha válida é o número 1234. Devem ser impressas as seguintes mensagens:  
ACESSO PERMITIDO - caso a senha seja válida.  
ACESSO NEGADO - caso a senha seja inválida. 
*/
using System;

class exe2{
    public static void Main(string[] args){
        int senha;
        Console.WriteLine("== VERIFICADOR DE SENHA ==");
        Console.WriteLine("Digite a senha:");
        senha = int.Parse(Console.ReadLine());
        if(senha != 1234){
            Console.WriteLine("ACESSO NEGADO");
        }
        else{
            Console.WriteLine("ACESSO PERMITIDO");
        }
    }
}