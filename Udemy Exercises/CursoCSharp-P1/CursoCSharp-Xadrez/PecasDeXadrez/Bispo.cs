﻿using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override bool[,] MovimentosPossiveis()
        {
            var movimentosPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            var posicao = new Posicao(0, 0);

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor) break;

                posicao.AlterarPosicao(posicao.Linha - 1, posicao.Coluna - 1);
            }

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor) break;

                posicao.AlterarPosicao(posicao.Linha - 1, posicao.Coluna + 1);
            }

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor) break;

                posicao.AlterarPosicao(posicao.Linha + 1, posicao.Coluna - 1);
            }

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;

                if (Tabuleiro.GetPeca(posicao) != null && Tabuleiro.GetPeca(posicao).Cor != Cor) break;

                posicao.AlterarPosicao(posicao.Linha + 1, posicao.Coluna + 1);
            }

            return movimentosPossiveis;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
