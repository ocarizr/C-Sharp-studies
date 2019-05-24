namespace CursoCSharp_Xadrez.Tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private readonly Peca[,] _pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            _pecas = new Peca[Linhas, Colunas];
        }

        public Peca GetPeca(int linha, int coluna)
        {
            ValidarPosicao(new Posicao(linha, coluna));
            return _pecas[linha, coluna];
        }

        public Peca GetPeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return _pecas[posicao.Linha, posicao.Coluna];
        }

        public bool ExistePeca(Posicao posicao)
        {
            return GetPeca(posicao) != null;
        }

        public void ColocarPeca(Peca peca, Posicao posicao)
        {
            if (ExistePeca(posicao)) throw new TabuleiroException("Já existe peça nesta posição.");

            _pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public Peca RetirarPeca(Posicao posicao)
        {
            if (ExistePeca(posicao))
            {
                Peca peca = GetPeca(posicao);
                peca.Posicao = null;
                _pecas[posicao.Linha, posicao.Coluna] = null;
                return peca;
            }

            return null;
        }

        public void ValidarPosicao(Posicao posicao)
        {
            if (!PosicaoValida(posicao)) throw new TabuleiroException("Posição inválida.");
        }

        public bool PosicaoValida(Posicao posicao)
        {
            return posicao.Linha >= 0 && posicao.Linha < Linhas && posicao.Coluna >= 0 && posicao.Coluna < Colunas;
        }
    }
}
