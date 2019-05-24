using CursoCSharp_Xadrez.Xadrez;
using System;
using CursoCSharp_Xadrez.Tabuleiro;
using CursoCSharp_Xadrez.View;

namespace CursoCSharp_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.ImprimirTabuleiro(partida.Tabuleiro);

                    Console.WriteLine();

                    Console.Write("Origem: ");
                    Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }
                

                Console.ReadLine();
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro de sistema: " + e);
            }
        }
    }
}
