/*
3. Construa um algoritmo onde o usuário informar uma data (dia, mês e ano) e verifica se é 
uma data válida em 2022. Exemplos:  -30/08/2022 é uma data válida em 2022.  -31/Fev/2005 não é uma data válido, pois não fevereiro não tem 31 dias e o ano é diferente 
de 2022. 
*/
using System;

class exe3{
    public static void Main(string[] args){
        int dia, mes, ano;
        string[] data;
        Console.WriteLine("== VÁLIDAR DADA ==");
        Console.WriteLine("Digite uma data (dd/mm/aaaa):");
        data = Console.ReadLine().Split("/");
        dia = int.Parse(data[0]);
        mes = int.Parse(data[1]);
        ano = int.Parse(data[2]);
        if(ano != 2022){
            Console.WriteLine("Data inválida!");
        }
        else{
            if(mes == 02 && dia > 28){
                Console.WriteLine("Data inválida!");
            }
            else if(mes >= 01 && mes <= 12){
                if(dia >= 01 && dia <= 31){
                    Console.WriteLine("Data válida!");
                }
                else{
                    Console.WriteLine("Data inválida!");
                }
            }
        }
    }
}

