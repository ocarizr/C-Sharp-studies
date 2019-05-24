using System;
using CursoCSharp_Xadrez.PecasDeXadrez;
using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            var tabuleiro = new Tabuleiro.Tabuleiro(8, 8);

            tabuleiro.ColocarPeca(new Torre(tabuleiro, Cor.Preto), new Posicao(0, 0));
            tabuleiro.ColocarPeca(new Cavalo(tabuleiro, Cor.Preto), new Posicao(0, 1));

            Tela.ImprimirTabuleiro(tabuleiro);

            Console.ReadLine();
        }
    }
}
