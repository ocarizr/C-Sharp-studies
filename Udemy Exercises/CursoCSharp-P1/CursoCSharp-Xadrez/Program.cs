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

                try
                {
                    while (!partida.Terminada)
                    {
                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tabuleiro);

                        Console.WriteLine();

                        Console.WriteLine("Turno: " + partida.Turno);
                        Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);

                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.Tabuleiro.GetPeca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();

                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                }
                catch (TabuleiroException e)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Erro na jogada: {e.Message}.");
                    Console.ReadLine();
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
