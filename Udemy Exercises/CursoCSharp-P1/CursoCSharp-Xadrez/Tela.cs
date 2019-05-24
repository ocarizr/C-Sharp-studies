using CursoCSharp_Xadrez.Tabuleiro;
using System;

namespace CursoCSharp_Xadrez
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    string peca = tabuleiro.ExistePeca(new Posicao(i, j)) ? tabuleiro.GetPeca(i, j).ToString() : "-";
                    Console.Write(peca + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
