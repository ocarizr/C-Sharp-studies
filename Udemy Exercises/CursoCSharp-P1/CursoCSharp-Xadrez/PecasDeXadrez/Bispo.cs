using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "B";
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }
    }
}
