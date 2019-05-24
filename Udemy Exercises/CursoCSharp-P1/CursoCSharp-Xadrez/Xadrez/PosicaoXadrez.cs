using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.Xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }

        public Posicao ToPosicao()
        {
            return new Posicao(8-Linha, char.ToLower(Coluna) - 'a');
        }

        public override string ToString()
        {
            return $"{Coluna}{Linha}";
        }
    }
}
