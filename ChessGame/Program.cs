using System;
using tabuleiro;
using chess;


namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PositionChess pos = new PositionChess('a', 1);

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Position(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Position(0, 1));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Position(2, 4));

                tab.colocarPeca(new Torre(tab, Cor.Branca), new Position(3, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }




            Console.ReadLine();
        }
    }
}
