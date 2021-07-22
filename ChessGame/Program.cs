using System;
using tabuleiro;
using chess;

namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Position(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Position(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Position(2, 4));

            Tela.imprimirTabuleiro(tab);


            Console.ReadLine();
        }
    }
}
