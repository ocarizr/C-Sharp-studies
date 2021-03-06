﻿using CursoCSharp_Xadrez.PecasDeXadrez;
using CursoCSharp_Xadrez.Tabuleiro;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CursoCSharp_Xadrez.Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro.Tabuleiro Tabuleiro { get; }
        public bool Terminada { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Xeque { get; private set; }

        private HashSet<Peca> _pecas;
        private HashSet<Peca> _pecasCapturadas;

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro.Tabuleiro(8, 8);
            Terminada = false;
            Turno = 1;
            JogadorAtual = Cor.Branco;
            Xeque = false;

            _pecas = new HashSet<Peca>();
            _pecasCapturadas = new HashSet<Peca>();

            ColocarPecas();
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = ExecutaMovimento(origem, destino);

            if (EstaEmXeque(JogadorAtual))
            {
                DesfazMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você não pode se colocar em Xeque!");
            }

            Peca peca = Tabuleiro.GetPeca(destino);

            // Jogada especial
            // Promoção
            if (peca is Peao)
            {
                if ((peca.Cor == Cor.Branco && destino.Linha == 0) ||
                    (peca.Cor == Cor.Preto && destino.Linha == 7))
                {
                    peca = Tabuleiro.RetirarPeca(destino);
                    _pecas.Remove(peca);
                    Peca rainha = new Rainha(Tabuleiro, peca.Cor);
                    Tabuleiro.ColocarPeca(rainha, destino);
                }
            }

            Xeque = EstaEmXeque(Adversário(JogadorAtual));

            if (XequeMate(Adversário(JogadorAtual)))
            {
                Terminada = true;
            }
            else
            {
                Turno++;
                AlternaJogador();
            }
        }

        private Peca ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = null;

            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementaQteDeMovimentos();

            if (Tabuleiro.ExistePeca(destino))
            {
                pecaCapturada = Tabuleiro.RetirarPeca(destino);
                _pecasCapturadas.Add(pecaCapturada);
                _pecas.Remove(pecaCapturada);
            }

            Tabuleiro.ColocarPeca(peca, destino);

            // Jogada especial
            // Roque
            if (peca is Rei && destino.Coluna == origem.Coluna + 2)
            {
                var origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                var destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);

                Peca torre = Tabuleiro.RetirarPeca(origemTorre);
                torre.IncrementaQteDeMovimentos();
                Tabuleiro.ColocarPeca(torre, destinoTorre);
            }
            else if (peca is Rei && destino.Coluna == origem.Coluna - 2)
            {
                var origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                var destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);

                Peca torre = Tabuleiro.RetirarPeca(origemTorre);
                torre.IncrementaQteDeMovimentos();
                Tabuleiro.ColocarPeca(torre, destinoTorre);
            }

            return pecaCapturada;
        }

        private void DesfazMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca peca = Tabuleiro.RetirarPeca(destino);
            peca.DecrementaQteDeMovimentos();

            Tabuleiro.ColocarPeca(peca, origem);

            if (pecaCapturada != null)
            {
                Tabuleiro.ColocarPeca(pecaCapturada, destino);
                _pecas.Add(pecaCapturada);
                _pecasCapturadas.Remove(pecaCapturada);
            }

            if (peca is Rei && destino.Coluna == origem.Coluna + 2)
            {
                var origemTorre = new Posicao(origem.Linha, origem.Coluna + 3);
                var destinoTorre = new Posicao(origem.Linha, origem.Coluna + 1);

                Peca torre = Tabuleiro.RetirarPeca(destinoTorre);
                torre.DecrementaQteDeMovimentos();
                Tabuleiro.ColocarPeca(torre, origemTorre);
            }
            else if (peca is Rei && destino.Coluna == origem.Coluna - 2)
            {
                var origemTorre = new Posicao(origem.Linha, origem.Coluna - 4);
                var destinoTorre = new Posicao(origem.Linha, origem.Coluna - 1);

                Peca torre = Tabuleiro.RetirarPeca(destinoTorre);
                torre.DecrementaQteDeMovimentos();
                Tabuleiro.ColocarPeca(torre, origemTorre);
            }
        }

        private void AlternaJogador() => JogadorAtual = (JogadorAtual == Cor.Branco) ? Cor.Preto : Cor.Branco;

        public HashSet<Peca> PecasCapturadas(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();

            foreach (Peca pecaCapturada in _pecasCapturadas)
            {
                if (pecaCapturada.Cor == cor) auxiliar.Add(pecaCapturada);
            }

            return auxiliar;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> auxiliar = new HashSet<Peca>();

            foreach (Peca peca in _pecas)
            {
                if (peca.Cor == cor) auxiliar.Add(peca);
            }

            return auxiliar;
        }

        public bool EstaEmXeque(Cor cor)
        {
            Peca rei = GetRei(cor);

            if (rei == null) throw new TabuleiroException($"A cor {cor} não tem rei!");

            foreach (Peca peca in PecasEmJogo(Adversário(cor)))
            {
                bool[,] movimentosPossiveis = peca.MovimentosPossiveis();
                if (movimentosPossiveis[rei.Posicao.Linha, rei.Posicao.Coluna])
                {
                    return true;
                }
            }

            return false;
        }

        public bool XequeMate(Cor cor)
        {
            if (!EstaEmXeque(cor)) return false;

            foreach (Peca peca in PecasEmJogo(cor))
            {
                bool[,] movimentosPossiveis = peca.MovimentosPossiveis();

                for (int i = 0; i < Tabuleiro.Linhas; i++)
                {
                    for (int j = 0; j < Tabuleiro.Colunas; j++)
                    {
                        if (movimentosPossiveis[i, j])
                        {
                            Posicao origem = peca.Posicao;
                            Posicao destino = new Posicao(i, j);
                            Peca pecaCapturada = ExecutaMovimento(origem, destino);
                            bool testeXeque = EstaEmXeque(cor);
                            DesfazMovimento(origem, destino, pecaCapturada);

                            if (!testeXeque) return false;
                        }
                    }
                }
            }

            return true;
        }

        public void ValidarPosicaoDeOrigem(Posicao origem)
        {
            if (Tabuleiro.GetPeca(origem) == null) throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            if (JogadorAtual != Tabuleiro.GetPeca(origem).Cor) throw new TabuleiroException("A peça de origem escolhida não é sua.");
            if (!Tabuleiro.GetPeca(origem).ExisteMovimentosPossiveis()) throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida.");
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tabuleiro.GetPeca(origem).MovimentoPossivel(destino))
            {
                throw new TabuleiroException("Posição de destino inválida.");
            }
        }

        public void ColocarNovaPeca(char coluna, int linha, Peca peca)
        {
            Tabuleiro.ColocarPeca(peca, new PosicaoXadrez(coluna, linha).ToPosicao());
            _pecas.Add(peca);
        }

        private void ColocarPecas()
        {
            ColocarNovaPeca('a', 1, new Torre(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('h', 1, new Torre(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('b', 1, new Cavalo(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('g', 1, new Cavalo(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('c', 1, new Bispo(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('f', 1, new Bispo(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branco, this));
            ColocarNovaPeca('e', 1, new Rainha(Tabuleiro, Cor.Branco));

            ColocarNovaPeca('a', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('h', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('b', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('g', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('c', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('f', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('d', 2, new Peao(Tabuleiro, Cor.Branco));
            ColocarNovaPeca('e', 2, new Peao(Tabuleiro, Cor.Branco));

            ColocarNovaPeca('a', 8, new Torre(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('h', 8, new Torre(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('b', 8, new Cavalo(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('g', 8, new Cavalo(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('c', 8, new Bispo(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('f', 8, new Bispo(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('e', 8, new Rei(Tabuleiro, Cor.Preto, this));
            ColocarNovaPeca('d', 8, new Rainha(Tabuleiro, Cor.Preto));

            ColocarNovaPeca('a', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('h', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('b', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('g', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('c', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('f', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('d', 7, new Peao(Tabuleiro, Cor.Preto));
            ColocarNovaPeca('e', 7, new Peao(Tabuleiro, Cor.Preto));
        }

        private Cor Adversário(Cor cor) => cor == Cor.Branco ? Cor.Preto : Cor.Branco;

        private Peca GetRei(Cor cor)
        {
            foreach (Peca peca in PecasEmJogo(cor))
            {
                if (peca is Rei) return peca;
            }

            return null;
        }
    }
}
