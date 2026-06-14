/*
12. Faça um programa que leia o consumo mensal em quilowatt-hora (kWh) de 10
consumidores. Rejeitar a leitura de consumo negativo. Para cada consumo lido, calcular e
informar o valor a ser pago, sabendo que:
• até 30 kWh: consumo mínimo: R$ 45,00;
• a partir de 30 kw até 100 kw: R$ 1,90 por kWh;
• acima de 100 kw: R$ 3,95 por kWh.
• Adicionar para todos os casos taxa de iluminação pública de R$ 14,00.
Ao final do processo de leitura, informar:
• o consumo médio em kWh;
• o valor em kWh do menor consumo;
• o valor em kWh do maior consumo;
• o número de consumidores que pagaram o consumo mínimo;
• o valor total em reais.
*/
using System;
using System.Globalization;
using System.Linq.Expressions;

class exe12
{
    public static void Main(string[] args)
    {
        double iluminacao = 14.00, consumo, menorConsumo = double.MaxValue, maiorConsumo = 0, valorTotal = 0, numConsumidoresMinimo = 0, consumoMedio = 0;
        int consumoMensal;
        Console.WriteLine("== CONSUMO MENSAL QUILOWATT-HORA ==");
        for(int i = 0; i < 10; i++)
        {
            do
            {
                Console.WriteLine($"Digite o consumo mensal do {i+1}° funcionário:");
                consumoMensal = int.Parse(Console.ReadLine());
            }while (consumoMensal <= 0.0);
            
            if(consumoMensal <= 30)
            {
                consumoMedio += consumoMensal;
                numConsumidoresMinimo++;
                valorTotal += 45.00 + iluminacao;
                Console.WriteLine($"Valor a pagar do {i+1}° funcionário: R$ 59,00");
                
                if(consumoMensal >= maiorConsumo)
                {
                    maiorConsumo = consumoMensal;
                }
                if(consumoMensal <= menorConsumo)
                {
                    menorConsumo = consumoMensal;
                }
            }
            else if(consumoMensal >= 30 && consumoMensal <= 100)
            {
                consumoMedio += consumoMensal;
                consumo = 1.90 * consumoMensal + iluminacao;
                valorTotal += consumo;
                Console.WriteLine($"Valor a pagar do {i+1}° funcionário: R$ {consumo.ToString("F2", CultureInfo.InvariantCulture)}");
                if(consumoMensal >= maiorConsumo)
                {
                    maiorConsumo = consumoMensal;
                }
                if(consumoMensal <= menorConsumo)
                {
                    menorConsumo = consumoMensal;
                }
            }
            else if(consumoMensal > 100)
            {
                consumoMedio += consumoMensal;
                consumo = 3.95 * consumoMensal + iluminacao;
                valorTotal += consumo;
                Console.WriteLine($"Valor a pagar do {i+1}° funcionário: R$ {consumo.ToString("F2", CultureInfo.InvariantCulture)}");
                if(consumoMensal >= maiorConsumo)
                {
                    maiorConsumo = consumoMensal;
                }
                if(consumoMensal <= menorConsumo)
                {
                    menorConsumo = consumoMensal;
                }
            }
        }
        consumoMedio /= 10;
        Console.WriteLine($"O consumo médio em kwh foi de {consumoMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"O valor em kWh do menor consumo foi {menorConsumo.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"O valor em kWh do maior consumo foi {maiorConsumo.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"O número de consumidores que pagaram o consumo mínimo foram de {numConsumidoresMinimo} funcionários.");
        Console.WriteLine($"O valor total em reias foi de R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}