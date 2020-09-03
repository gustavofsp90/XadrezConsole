using System;
using System.Collections.Generic;
using System.Text;
using Tabuleiro;

namespace tabuleiro
{
    class Peca
    {
        public Peca(Posicao posicao, Cor cor, int qteMovimentos, Tabuleiro tab) {
            Posicao = posicao;
            Cor = cor;
            this.qteMovimentos = 0;
            Tab = tab;
        }

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; protected set; }

      
    }
}
