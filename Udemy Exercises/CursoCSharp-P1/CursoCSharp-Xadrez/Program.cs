using System;
using CursoCSharp_Xadrez.PecasDeXadrez;
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
                var tabuleiro = new Tabuleiro.Tabuleiro(8, 8);
                
                tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
                tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preto), new Posicao(0, 1));
                tabuleiro.ColocarPeca(new Peao(tabuleiro, Cor.Branco), new Posicao(6, 5));

                Tela.ImprimirTabuleiro(tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro na operação: " + e);
            }
            Console.ReadLine();
        }
    }
}
