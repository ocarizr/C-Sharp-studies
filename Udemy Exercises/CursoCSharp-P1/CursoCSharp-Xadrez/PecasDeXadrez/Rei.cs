using CursoCSharp_Xadrez.Tabuleiro;
using CursoCSharp_Xadrez.Xadrez;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Rei : Peca
    {
        private PartidaDeXadrez Partida;

        public Rei(Tabuleiro.Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
            Partida = partida;
        }

        public override bool[,] MovimentosPossiveis()
        {
            var movimentosPossiveis = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
            var posicao = new Posicao(0, 0);

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.AlterarPosicao(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                movimentosPossiveis[posicao.Linha, posicao.Coluna] = true;
            }

            // Jogada especial
            // Roque
            if (QtdDeMovimentos == 0 && !Partida.Xeque)
            {
                // Roque pequeno
                var posicaoTorre1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);

                if (PossibilidadeDeRoque(posicaoTorre1))
                {
                    var posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    var posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if (Tabuleiro.GetPeca(posicao1) == null && Tabuleiro.GetPeca(posicao2) == null)
                    {
                        movimentosPossiveis[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                // Roque grande
                var posicaoTorre2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (PossibilidadeDeRoque(posicaoTorre2))
                {
                    var posicao1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    var posicao2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    var posicao3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tabuleiro.GetPeca(posicao1) == null && Tabuleiro.GetPeca(posicao2) == null 
                                                            && Tabuleiro.GetPeca(posicao3) == null)
                    {
                        movimentosPossiveis[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return movimentosPossiveis;
        }

        private bool PossibilidadeDeRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.GetPeca(posicao);
            return peca != null && peca is Torre && peca.QtdDeMovimentos == 0 && peca.Cor == Cor;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
