using System;
using tabuleiro;


namespace chess
{
    class Rei : Peca{
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { 
        }

        public override string ToString()
        {
            return "R";
        }

        private bool podeMover(Position pos) {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.linhas, tab.colunas];

            Position pos = new Position(0, 0);

            //acima
            pos.definirValores(position.linha - 1, position.coluna);
            if(tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.linha, pos.coluna] = true;
            }

            //nordeste
            pos.definirValores(position.linha - 1, position.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //direita
            pos.definirValores(position.linha, position.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //sudeste
            pos.definirValores(position.linha + 1, position.coluna + 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //abaixo
            pos.definirValores(position.linha + 1, position.coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //sudoeste
            pos.definirValores(position.linha + 1, position.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //esquerda
            pos.definirValores(position.linha, position.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            //noroeste
            pos.definirValores(position.linha - 1, position.coluna - 1);
            if (tab.posicaoValida(pos) && podeMover(pos)){
                mat[pos.linha, pos.coluna] = true;
            }

            return mat;
        }
    }
}
