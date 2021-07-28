using System;
using tabuleiro;

namespace chess
{
    class PartidaDeXadrez{
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public Cor jogadorAtual { get; private set; }
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

        public void realizaJogada(Position origem, Position destino) {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Position pos) { 
            if(tab.peca(pos) == null) {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida.");
            }
            if(jogadorAtual != tab.peca(pos).cor) {
                throw new TabuleiroException("A peça de origem escolhida não é sua.");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis()) {
                throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida.");
            }
        }

        public void validarPosicaoDeDestino(Position origem, Position destino) {
            if (!tab.peca(origem).podeMoverPara(destino)) {
                throw new TabuleiroException("Posição de destino inválida.");
            }
        }


        private void mudaJogador() { 
            if(jogadorAtual == Cor.Branca) {
               jogadorAtual = Cor.Preta;
            }
            else {
                jogadorAtual = Cor.Branca;
            }
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
