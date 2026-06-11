/*
9. Construa um algoritmo que, a partir do peso e altura informados pelo usuário, calcule e 
apresente o IMC de uma pessoa e a sua classificação conforme tabela a seguir: 
*/
using System;
using System.Globalization;

class exe9{
    public static void Main(string[] args){
        double peso, altura, IMC;
        Console.WriteLine("== TABELA IMC ==");
        Console.WriteLine("Digite seu peso:");
        peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Digite sua altura:");
        altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        IMC = peso / (altura * altura);
        if(IMC < 18.5){
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Abaixo do peso");
        }
        else if(IMC > 18.5 && IMC <= 24.9){
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Peso ideal (parabéns)");
        }
        else if(IMC >= 25.0 && IMC <= 29.9){
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Levemente acima do peso");
        }
        else if(IMC >= 30.0 && IMC <= 34.9){
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Obesidade grau 1");
        }
        else if(IMC >= 35.0 && IMC <= 39.9){
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Obesidade grau 2 (severa)");
        }
        else{
            Console.WriteLine($"Classificação IMC({IMC.ToString("F1", CultureInfo.InvariantCulture)}): Obesidade 3 (mórbida)");
        }
    }
}