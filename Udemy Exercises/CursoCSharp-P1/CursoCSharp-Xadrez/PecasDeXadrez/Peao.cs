using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "P";
        }

        public override bool[,] MovimentosPossiveis()
        {
            throw new System.NotImplementedException();
        }
    }
}
