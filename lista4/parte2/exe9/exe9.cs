/*
Uma certa firma fez uma pesquisa de mercado para saber se as pessoas gostaram ou não de
um novo produto lançado no mercado. Para isso, forneceu o sexo do entrevistado e sua
resposta (sim ou não). Sabendo-se que foram entrevistadas 2.000 pessoas, faça um algoritmo
que calcule e escreva:
• o número de pessoas que responderam sim;
• o número de pessoas que responderam não;
• a porcentagem de pessoas do sexo feminino que responderam sim;
• a porcentagem de pessoas do sexo masculino que responderam não.
*/

using System;

class exe9
{
    public static void Main(string[] args)
    {
        int homem = 0, mulher = 0, quantidadesSim = 0, quantidadesNao = 0, mulherSim = 0, homemNao = 0;
        char genero, produtoLancado;
        for(int i = 0; i < 2000; i++)
        {
            Console.WriteLine("A pessoa é homem ou mulher(h/m):");
            genero = char.Parse(Console.ReadLine());
            if(genero == 'h')
            {
                homem++;
                Console.WriteLine("Gostou do produto(s/n):");
                produtoLancado = char.Parse(Console.ReadLine());
                if(produtoLancado == 'n')
                {
                    homemNao++;
                    quantidadesNao++;
                }
                else
                {
                    quantidadesSim++;
                }
            }
            else if(genero == 'm')
            {
                mulher++;
                Console.WriteLine("Gostou do produto(s/n):");
                produtoLancado = char.Parse(Console.ReadLine());
                if(produtoLancado == 's')
                {
                    mulherSim++;
                    quantidadesSim++;
                }
                else
                {
                    quantidadesNao++;
                }
            }
        }
        double porcentagemMuher = ((double)mulherSim/mulher) / 100;
        double porcentagemHomem = ((double)homemNao/homem) / 100;
        Console.WriteLine($"Número de pessoas que responderam sim: {quantidadesSim}");
        Console.WriteLine($"Número de pessoas que responderam não: {quantidadesNao}");
        Console.WriteLine($"Porcentagem de pessoaas do sexo feminino que responderam sim: {porcentagemMuher}%");
        Console.WriteLine($"Porcentagem de pessoaas do sexo masculino que responderam não: {porcentagemHomem}%");
    }
}