using System;
using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] MovimentosPossiveis()
        {
            var movimentosPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            var posicao = new Posicao(0, 0);

            if (Cor == Cor.Branco)
            {
                posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QtdDeMovimentos == 0)
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }
            }
            else
            {
                posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QtdDeMovimentos == 0)
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }

                posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
                }
            }

            return movimentosPossiveis;
        }

        private bool ExisteInimigo(Posicao posicao)
        {
            Peca peca = Tabuleiro.GetPeca(posicao);

            return peca != null && peca.Cor != Cor;
        }

        private bool Livre(Posicao posicao) => Tabuleiro.GetPeca(posicao) == null;
    }
}
