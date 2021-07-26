using System;
using tabuleiro;
using chess;


namespace ChessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Position origem = Tela.lerPositionChess().toPosition();
                    Console.Write("Destino: ");
                    Position destino = Tela.lerPositionChess().toPosition();

                    partida.executaMovimento(origem, destino);
                }
            }
            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }




            Console.ReadLine();
        }
    }
}
