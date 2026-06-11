/*
8. Ler os lados de um triângulo. Verificar e informar se os valores lidos consistem, de fato, em 
um triângulo. Caso seja um triângulo válido, calcular e informar se é ele equilátero, isóscele ou 
escaleno. 
*/
using System;

class exe8{
    public static void Main(string[] args){
        int ladoA, ladoB, ladoC;
        string[] lados;
        Console.WriteLine("== VALIDAR TRIÂNGULO ==");
        Console.WriteLine("Digite o valor dos 3 lados de um triângulo:");
        lados = Console.ReadLine().Split(' ');
        ladoA = int.Parse(lados[0]);
        ladoB = int.Parse(lados[1]);
        ladoC = int.Parse(lados[2]);
        if(ladoA == ladoB && ladoB == ladoC){
            Console.WriteLine($"O triângulo de lado {ladoA}, {ladoB} e {ladoC} é equilátero!");
        }
        else if(ladoA == ladoB && ladoB != ladoC || ladoA == ladoC && ladoC != ladoB || ladoB == ladoC && ladoC != ladoA){
            Console.WriteLine($"O triângulo de lado {ladoA}, {ladoB} e {ladoC} é isósceles!");
        }
        else if(ladoA != ladoB && ladoA != ladoC){
            Console.WriteLine($"O triângulo de lado {ladoA}, {ladoB} e {ladoC} é escaleno!");
        }
        else{
            Console.WriteLine($"O triângulo de lado {ladoA}, {ladoB} e {ladoC} é inválido!");
        }
    }
}
