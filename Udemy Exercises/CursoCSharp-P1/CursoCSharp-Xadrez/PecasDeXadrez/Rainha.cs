using CursoCSharp_Xadrez.Tabuleiro;

namespace CursoCSharp_Xadrez.PecasDeXadrez
{
    class Rainha : Peca
    {
        public Rainha(Tabuleiro.Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        public override string ToString()
        {
            return "D";
        }
    }
}
