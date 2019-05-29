using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

            Posicao posicao = new Posicao(0, 0);

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.ExistePeca(posicao) && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.AlterarPosicao(posicao.Linha - 1, posicao.Coluna);
            }

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.ExistePeca(posicao) && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.AlterarPosicao(posicao.Linha + 1, posicao.Coluna);
            }

            posicao.AlterarPosicao(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.ExistePeca(posicao) && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.AlterarPosicao(posicao.Linha, posicao.Coluna - 1);
            }

            posicao.AlterarPosicao(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
                if (Tabuleiro.ExistePeca(posicao) && Tabuleiro.GetPeca(posicao).Cor != Cor)
                {
                    break;
                }

                posicao.AlterarPosicao(posicao.Linha, posicao.Coluna + 1);
            }

            return matriz;
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.GetPeca(posicao);

            return peca == null || peca.Cor != Cor;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
