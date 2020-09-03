using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez_console.tabuleiro
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab) {

            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.Peca(i,j) == null)
                    {
                        Console.WriteLine(tab.Peca(i, j));
                    }
                    
                }

            }

        }
    }
}
