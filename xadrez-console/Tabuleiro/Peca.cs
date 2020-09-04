using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    abstract class Peca
    {
        public Peca(Cor cor, Tabuleiro tab) {
            Posicao = null;
            Cor = cor;
            this.QteMovimentos = 0;
            Tab = tab;
        }

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public void IncrementarAQuantidadedeMovimentos() {
            QteMovimentos++;
        }
        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossives();
            for (int i = 0; i < Tab.Linhas; i++)
            {
                for (int j = 0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool PodeMoverPara(Posicao pos) {
            return MovimentosPossives()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossives();


    }
}
