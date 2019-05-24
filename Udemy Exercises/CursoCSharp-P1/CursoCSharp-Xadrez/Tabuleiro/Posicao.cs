namespace CursoCSharp_Xadrez.Tabuleiro
{
    class Posicao
    {
        private int _linha;
        private int _coluna;

        public int Linha
        {
            get => _linha;
            set
            {
                _linha = value;
                if (value < 0)
                {
                    _linha = 0;
                }
            }
        }

        public int Coluna
        {
            get => _coluna;
            set
            {
                _coluna = value;
                if (value < 0)
                {
                    _coluna = 0;
                }
            }
        }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return $"({_linha}, {_coluna})";
        }
    }
}
