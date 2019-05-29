using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp_Xadrez.PecasDeXadrez;
using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro.Tabuleiro Tabuleiro { get; }
        public bool Terminada { get; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }

        private HashSet<Peca> _pecas;
        private HashSet<Peca> _pecasCapturadas;

        public PartidaDeXadrez()
        {
            Tabuleiro = new Tabuleiro.Tabuleiro(8, 8);
            Terminada = false;
            Turno = 1;
            JogadorAtual = Cor.Branco;

            _pecas = new HashSet<Peca>();
            _pecasCapturadas = new HashSet<Peca>();

            ColocarPecas();
        }

        public void RealizaJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
            Turno++;
            AlternaJogador();
        }

        private void ExecutaMovimento(Posicao origem, Posicao destino)
        {
            Peca peca = Tabuleiro.RetirarPeca(origem);
            peca.IncrementaQteDeMovimentos();

            if (Tabuleiro.ExistePeca(destino))
            {
                Peca pecaCapturada = Tabuleiro.RetirarPeca(destino);
                _pecasCapturadas.Add(pecaCapturada);
                _pecas.Remove(pecaCapturada);
            }

            Tabuleiro.ColocarPeca(peca, destino);
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

        public void ValidarPosicaoDeOrigem(Posicao origem)
        {
            if (Tabuleiro.GetPeca(origem) == null) throw new TabuleiroException("Não existe peça na posição de origem escolhida!");
            if (JogadorAtual != Tabuleiro.GetPeca(origem).Cor) throw new TabuleiroException("A peça de origem escolhida não é sua.");
            if (!Tabuleiro.GetPeca(origem).ExisteMovimentosPossiveis()) throw new TabuleiroException("Não há movimentos possíveis para a peça de origem escolhida.");
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tabuleiro.GetPeca(origem).PodeMoverPara(destino))
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
            ColocarNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branco));
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
            ColocarNovaPeca('e', 8, new Rei(Tabuleiro, Cor.Preto));
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
    }
}
