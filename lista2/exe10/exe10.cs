/*
10. Calculadora com as quatro operações aritméticas básicas. Oferecer um menu ao usuário com
as operações. Ler os dois operandos. Calcular e escrever o resultado.
*/
using System;
using System.Globalization;

class exe10
{
    public static void Main(string[] args)
    {
        string[] valores;
        int op, tamanho;
        double resultado = 0;
        Console.WriteLine("== CALCULADORA ==");
        do
        {
            Console.WriteLine("Digite o número da operação aritmética desejada:");
            Console.WriteLine("[1]ADIÇÃO\n[2]SUBTRAÇÃO\n[3]MULTIPLICAÇÃO\n[4]DIVISÃO\n==============");
            op = int.Parse(Console.ReadLine());
        }while(op < 1 || op > 4);
        switch (op)
        {
            case 1:
                Console.WriteLine("Digite sua adição:");
                valores = Console.ReadLine().Split("+");
                tamanho = valores.Length;
                for(int i = 0; i < tamanho; i++)
                {
                    resultado += double.Parse(valores[i], CultureInfo.InvariantCulture);
                }
                break;
            case 2:
                Console.WriteLine("Digite sua subtração:");
                valores = Console.ReadLine().Split("-");
                tamanho = valores.Length;
                for(int i = 1; i < tamanho; i++)
                {
                    resultado -= double.Parse(valores[i], CultureInfo.InvariantCulture);
                }
                break;
            case 3:
                Console.WriteLine("Digite sua multiplicação:");
                valores = Console.ReadLine().Split("*");
                tamanho = valores.Length;
                resultado = 1;
                for(int i = 0; i < tamanho; i++)
                {
                    resultado *= double.Parse(valores[i], CultureInfo.InvariantCulture);
                }
                break;
            default:
                Console.WriteLine("Digite sua divisão:");
                valores = Console.ReadLine().Split("/");
                tamanho = valores.Length;
                resultado = double.Parse(valores[0]);
                for(int i = 1; i < tamanho; i++)
                {
                    resultado /= double.Parse(valores[i], CultureInfo.InvariantCulture);
                }
                break;
        }
        Console.WriteLine($"RESULDADO: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}