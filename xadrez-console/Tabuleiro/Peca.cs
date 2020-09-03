using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace tabuleiro
{
    class Peca
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

      
    }
}
