/*
10. Reescreva o exercício acima considerando que não se sabe o número de pessoas que foram
entrevistadas.
*/
using System;

class exe9
{
    public static void Main(string[] args)
    {
        int homem = 0, mulher = 0, quantidadesSim = 0, quantidadesNao = 0, mulherSim = 0, homemNao = 0;
        char genero, produtoLancado, continuar;
        Console.WriteLine("Tem um pessoa para cadastrar na pesquisa(s/n):");
        continuar = char.Parse(Console.ReadLine());
        while(continuar == 's'){
            Console.WriteLine("A pessoa é homem ou mulher(h/m):");
            genero = char.Parse(Console.ReadLine());
            if (genero == 'h')
            {
                homem++;
                Console.WriteLine("Gostou do produto(s/n):");
                produtoLancado = char.Parse(Console.ReadLine());
                if (produtoLancado == 'n')
                {
                    homemNao++;
                    quantidadesNao++;
                }
                else
                {
                    quantidadesSim++;
                }
            }
            else if (genero == 'm')
            {
                mulher++;
                Console.WriteLine("Gostou do produto(s/n):");
                produtoLancado = char.Parse(Console.ReadLine());
                if (produtoLancado == 's')
                {
                    mulherSim++;
                    quantidadesSim++;
                }
                else
                {
                    quantidadesNao++;
                }
            }
            Console.WriteLine("Tem um pessoa para cadastrar na pesquisa(s/n):");
            continuar = char.Parse(Console.ReadLine());
        }
        double porcentagemMuher = ((double)mulherSim / mulher) / 100;
        double porcentagemHomem = ((double)homemNao / homem) / 100;
        Console.WriteLine($"Número de pessoas que responderam sim: {quantidadesSim}");
        Console.WriteLine($"Número de pessoas que responderam não: {quantidadesNao}");
        Console.WriteLine($"Porcentagem de pessoaas do sexo feminino que responderam sim: {porcentagemMuher}%");
        Console.WriteLine($"Porcentagem de pessoaas do sexo masculino que responderam não: {porcentagemHomem}%");
        

    }

}