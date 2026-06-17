/*
7. Um comerciante deseja fazer o levantamento do lucro das mercadorias que ele comercializa.
Para isto, mandou digitar uma linha para cada mercadoria com o código, preço de compra e
preço de venda das mesmas. Faça um algoritmo que determine e escreva quantas mercadorias
proporcionam lucro < 10%, 10% ≤ lucro ≤ 20% e lucro > 20%. Determine também e escreva
o valor total de compra e de venda de todas as mercadorias, assim como o lucro total.
*/
using System;
using System.Globalization;

class exe7
{
    public static void Main(string[] args)
    {
        int m, codigo;
        double precoCompra, precoVenda, valorTotalCompra = 0, valorTotalVenda = 0, lucroPorcentagem, LucroTotal = 0;
        Console.WriteLine("Quantas mercadorias serão cadastradas no momento:");
        m = int.Parse(Console.ReadLine());
        for(int i = 0; i < m; i++)
        {
            Console.WriteLine($"Digite o codigo da mercadoria {i+1}:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o preco de compra da mercadoria {i+1}:");
            precoCompra = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorTotalCompra += precoCompra;
            Console.WriteLine($"Digite o preco de venda da mercadoria {i+1}:");
            precoVenda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorTotalVenda += precoVenda;
            LucroTotal = precoVenda - precoCompra;
            lucroPorcentagem = ((precoVenda - precoCompra) / precoCompra) * 100;
            if(lucroPorcentagem < 10)
            {
                Console.WriteLine($"A porcentagem de lucro da mercadoria {i+1} está abaixo de 10%");
            }
            else if(lucroPorcentagem >= 10 && lucroPorcentagem <= 20)
            {
                Console.WriteLine($"A porcentagem de lucro da mercadoria {i+1} está entre 10% e 20%");
            }
            else if(lucroPorcentagem > 20)
            {
                Console.WriteLine($"A porcentagem de lucro da mercadoria {i+1} está acima de 20%");
            }
        }
        Console.WriteLine($"Valor total de compra: R$ {valorTotalCompra.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor total de venda: R$ {valorTotalVenda.ToString("F2", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Valor total de lucro: R$ {LucroTotal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}