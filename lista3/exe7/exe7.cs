/*
7. Crie uma versão para o algoritmo da questão 1, utilizando estrutura de repetição (for).

1. Codifique o algoritmo abaixo em C e escreva na tela do monitor o valor de x ao final da
execução.
declare r, x, y, z : inteiro;
x ← 0;
y ← 10;
z ← 0;
enquanto (z < 3)
r ← y MOD 3;
se (r = 0)
 então x ← x+1;
fimse ;
y ← y + 5;
z ← z + 1;
fimenquanto;
*/

using System;

class exe7
{
    public static void Main(string[] args)
    {
        int r, x = 0, y = 10, z = 0;
        for(; z < 3;)
        {
            r = y % 3;
            if(r == 0)
            {
                x++;
            }
            y += 5;
            z += 1;
        }
    }
}
