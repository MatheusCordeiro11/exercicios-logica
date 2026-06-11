/*
14. Sabe-se que um cliente pode obter descontos ao comparar parafusos em uma loja. O preço de
cada parafuso é R$ 0,50, e os seguintes descontos podem ser aplicados:
Quantidades de Parafusos Desconto
Entre 101 e 200 10%
Entre 201 e 300 20%
Entre 301 e 400 30%
Acima de 401 40% (desconto máximo)
Construa um algoritmo que recebe o número de parafusos desejados pelo cliente e
informados pelo usuário e determina o valor total da compra. Caso a quantidade seja menor
ou igual a zero, o sistema deverá mostrar uma mensagem informando que a quantidade é
inválida.
*/
using System;
using System.Globalization;

class exe14
{
    public static void Main(string[] args)
    {
        double parafuso = 0.50, valorFinal;
        int quantidadeParafusos;
        Console.WriteLine("== CÁLCULO DE DESCONTO PARA PARAFUSOS ==");
        do
        {
            Console.WriteLine("Digite a quantidade de parafusos que deseja comprar:");
            quantidadeParafusos = int.Parse(Console.ReadLine());
            if(quantidadeParafusos <= 0)
            {
                Console.WriteLine("Quantidade inválida, tente novamente.");
            }
        }while(quantidadeParafusos <= 0);
        if(quantidadeParafusos <= 100)
        {
            valorFinal = quantidadeParafusos * parafuso;
        }
        else if(quantidadeParafusos >= 101 && quantidadeParafusos <= 200)
        {
            valorFinal =  (quantidadeParafusos * parafuso) - (quantidadeParafusos * parafuso) * 0.10;
        }
        else if(quantidadeParafusos >= 201 && quantidadeParafusos <= 300)
        {
            valorFinal =  (quantidadeParafusos * parafuso) - (quantidadeParafusos * parafuso) * 0.20;
        }
        else if(quantidadeParafusos >= 301 && quantidadeParafusos <= 400)
        {
            valorFinal =  (quantidadeParafusos * parafuso) - (quantidadeParafusos * parafuso) * 0.30;
        }
        else
        {
            valorFinal =  (quantidadeParafusos * parafuso) - (quantidadeParafusos * parafuso) * 0.40;
        }
        Console.WriteLine($"{quantidadeParafusos} parafusos dão o total de R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}