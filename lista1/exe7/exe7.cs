/*7) Construa um algoritmo que converte uma temperatura Farenheit em grau Celsius:
Grau Celsius = 5 / 9 * (Farenheit – 32)
Obs: Ao codificar o programa, cuidado com o uso do operador de divisão. Em C, um mesmo
operador é utilizado para divisão inteira e para divisão real – a diferença se dá pelos operandos.
Será executada uma divisão inteira se ambos os operandos forem valores inteiros, caso
contrário, uma divisão real será realizada. 
*/

using System;
using System.Globalization;


class exe7
{
    public static void Main(string[] args)
    {
        double grauFarenheit, grauCelsius;
        Console.WriteLine("-- CONVERSÃO DE GRAUS FARENHEIT PARA CELSIUS --");
        Console.WriteLine("Digite a temperatura em Farenheit:");
        grauFarenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        grauCelsius = (5.0 / 9) * (grauFarenheit - 32);
        Console.WriteLine($"A temperatura {grauFarenheit.ToString("F0", CultureInfo.InvariantCulture)} Farenheit é {grauCelsius.ToString("F0", CultureInfo.InvariantCulture)} Celsius");
    }
}