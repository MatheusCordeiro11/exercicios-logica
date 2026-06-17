/*
10. Faça um algoritmo para efetuar o cálculo da quantidade de litros de combustível gasta em
uma viagem. Para obter o cálculo, o usuário deverá fornecer o tempo (T) gasto na viagem e a
velocidade (V ) média durante a mesma. O usuário deverá também fornecer o rendimento (R)
médio do automóvel em km por litro. Desta forma, será possível obter a distância percorrida
com a fórmula D = T × V . Tendo o valor da distância, basta calcular a quantidade de litros (L)
de combustível utilizada na viagem com a fórmula: L = D/R. O algoritmo deverá apresentar
os valores do rendimento, da velocidade média, tempo gasto na viagem, a distância percorrida
e a quantidade de litros utilizada na viagem.
*/
using System;
using System.Globalization;

class exe10
{
    public static void Main(string[] args)
    {
        double T, V, R, D, L;
        Console.WriteLine("Digite o tempo gasto na viagem:");
        T = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("A velocidade média da viagem:");
        V = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("O rendimento médio do automóvel em km por litro");
        R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        D = T * V;
        L = D / R;
        Console.WriteLine($"Com {T.ToString("F1", CultureInfo.InvariantCulture)} de tempo gasto na velocidade média {V.ToString("F1", CultureInfo.InvariantCulture)} km/h e com o rendimento médio do automóvel em {R.ToString("F1", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"A distância percorrida foi de {D.ToString("F1", CultureInfo.InvariantCulture)} com {L.ToString("F1", CultureInfo.InvariantCulture)} litros gastos");
    }
}