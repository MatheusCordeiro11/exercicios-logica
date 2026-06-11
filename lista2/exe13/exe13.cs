/*
13. Construa um algoritmo que leia dois pontos cartesianos P1 (x1, y1) e P2 ( x2, y2) e calcule e
mostre a distância de manhattan entre esses dois pontos. Se os pontos forem os mesmos, o seu
algoritmo deverá alertar o usuário.
*/
using System;

class exe13
{
    public static void Main(string[] args)
    {
        int x1, y1, x2, y2, distancia;
        string[] p1, p2;
        Console.WriteLine("== DISTÂNCIA MANHATTAN ==");
        Console.WriteLine("Digite os pontos de P1:");
        p1 = Console.ReadLine().Split(' ');
        Console.WriteLine("Digite os pontos de P2:");
        p2 = Console.ReadLine().Split(' ');
        x1 = int.Parse(p1[0]);
        y1 = int.Parse(p1[1]);
        x2 = int.Parse(p2[0]);
        y2= int.Parse(p2[1]);
        if(x1 == x2 || y1 == y2)
        {
            Console.WriteLine("Os pontos p1 e p2 informados tem coordenadas iguas, tente novamente.");
        }
        else
        {
            distancia = (x2 - x1) + (y2 - y1);
            Console.WriteLine($"A distância é de {distancia}km");
        }
    }
}