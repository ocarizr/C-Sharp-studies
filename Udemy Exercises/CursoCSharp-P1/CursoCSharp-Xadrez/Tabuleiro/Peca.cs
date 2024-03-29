﻿namespace CursoCSharp_Xadrez.Tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        protected Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdDeMovimentos = 0;
        }

        public void IncrementaQteDeMovimentos()
        {
            QtdDeMovimentos++;
        }

        public void DecrementaQteDeMovimentos()
        {
            QtdDeMovimentos--;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] movimentosPossiveis = MovimentosPossiveis();

            for (int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for (int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (movimentosPossiveis[i, j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool MovimentoPossivel(Posicao posicao) => MovimentosPossiveis()[posicao.Linha, posicao.Coluna];

        protected bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.GetPeca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public abstract bool[,] MovimentosPossiveis();
    }
}
