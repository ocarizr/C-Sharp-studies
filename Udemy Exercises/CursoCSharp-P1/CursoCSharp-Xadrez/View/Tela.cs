using CursoCSharp_Xadrez.Tabuleiro;
using System;
using CursoCSharp_Xadrez.Xadrez;

namespace CursoCSharp_Xadrez.View
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro.Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write($"{8 - i} ");
                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (tabuleiro.ExistePeca(new Posicao(i, j)))
                        ImprimirPeca(tabuleiro.GetPeca(i, j));
                    else Console.Write("- ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1].ToString());

            return new PosicaoXadrez(coluna, linha);
        }

        private static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(peca);
                Console.ForegroundColor = color;
            }

            Console.Write(" ");
        }
    }
}
