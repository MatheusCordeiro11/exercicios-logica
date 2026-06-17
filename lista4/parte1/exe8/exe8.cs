/*
8. A energia gasta em kcal (calorias) com uma atividade aeróbica qualquer obedece a seguinte
equação:
E = MET × PESO × Tempo atividade/60. O tempo é dado em minutos. O peso é dado em
quilos. METS significa capacidade aeróbica e depende do tipo de exercício. Ciclismo ou
corrida leve tem pontuação de 7.0 METS. A Natação Crawl tem pontuação de 8.0 METS.
Um usuário deve entrar com seu peso, quanto tempo ele corre por semana; quanto tempo
ele pedala por semana e quanto tempo ele nada por semana. O seu algoritmo deve retornar
o número de calorias que este usuário queima por semana com exercícios físicos. (OBS: os
dados acima são reais para pessoas até 40 anos.)
*/
using System;
using System.Globalization;

class exe8
{
    public static void Main(string[] args)
    {
        double E, MET, peso, tempoAtividade = 0, corrida, pedal, natacao;
        Console.WriteLine("== ENERGIA GASTA ==");
        Console.WriteLine("Digite seu peso atual:");
        peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o seu tempo (em minutos) de corrida da semana:");
        corrida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o seu tempo (em minutos) de pedal da semana:");
        pedal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite o seu tempo (em minutos) de natação da semana:");
        natacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        MET = 7.0 + 7.0 + 8.0;
        tempoAtividade += corrida + pedal + natacao;
        E = MET * peso * tempoAtividade / 60;
        Console.WriteLine($"Sua queima de calorias nesta semana foi de {E.ToString("F2", CultureInfo.InvariantCulture)} kcal");

    }
}