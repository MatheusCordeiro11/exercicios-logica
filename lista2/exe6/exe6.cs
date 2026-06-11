/*
6. Faça um programa que leia um ponto cartesiano (dois valores numéricos X e Y) e mostre em 
qual quadrante o ponto se encontra. 
*/

using System;

class exe6{
    public static void Main(string[] args){
        int x, y;
        string[] pontoCartesiano;
        Console.WriteLine("== DESCUBRA QUAL O QUADRANTE DO PONTO CARTESIANO ==");
        Console.WriteLine("Escreva o ponto cartesiano (x e y):");
        pontoCartesiano = Console.ReadLine().Split(' ');
        x = int.Parse(pontoCartesiano[0]);
        y = int.Parse(pontoCartesiano[1]);
        if(x > 0 && y > 0){
            Console.WriteLine($"O ponto cartesiano {x} e {y} está no Quadrante 1!");
        }
        else if(x < 0 && y > 0){
            Console.WriteLine($"O ponto cartesiano {x} e {y} está no Quadrante 2!");
        }
        else if(x < 0 && y < 0){
            Console.WriteLine($"O ponto cartesiano {x} e {y} está no Quadrante 3!");
        }
        else{
            Console.WriteLine($"O ponto cartesiano {x} e {y} está no Quadrante 4!");
        }
    }
}