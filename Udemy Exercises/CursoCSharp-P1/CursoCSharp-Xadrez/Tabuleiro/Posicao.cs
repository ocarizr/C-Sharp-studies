namespace CursoCSharp_Xadrez.Tabuleiro
{
    class Posicao
    {
        public int Linha { get; private set; }
        public int Coluna { get; private set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void AlterarPosicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public override string ToString()
        {
            return $"({Linha}, {Coluna})";
        }
    }
}
