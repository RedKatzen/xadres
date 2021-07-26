using System;
using tabuleiro;

namespace chess
{
    class PartidaDeXadrez{
        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }

        public PartidaDeXadrez() {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colocarPecas();
        }

        public void executaMovimento(Position origem, Position destino) {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQtdMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        private void colocarPecas() {
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PositionChess('c', 1).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PositionChess('c', 2).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PositionChess('d', 2).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Branca), new PositionChess('e', 1).toPosition());
            tab.colocarPeca(new Rei(tab, Cor.Branca), new PositionChess('d', 1).toPosition());

            tab.colocarPeca(new Torre(tab, Cor.Preta), new PositionChess('c', 7).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PositionChess('c', 8).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PositionChess('d', 7).toPosition());
            tab.colocarPeca(new Torre(tab, Cor.Preta), new PositionChess('e', 8).toPosition());
            tab.colocarPeca(new Rei(tab, Cor.Preta), new PositionChess('d', 8).toPosition());

        }
    }
}
