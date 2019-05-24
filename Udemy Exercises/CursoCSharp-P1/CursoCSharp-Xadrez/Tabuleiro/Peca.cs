namespace CursoCSharp_Xadrez.Tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdDeMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Tabuleiro = tabuleiro;
            Cor = cor;
            QtdDeMovimentos = 0;
        }

        public void IncrementaQteDeMovimentos()
        {
            QtdDeMovimentos++;
        }
    }
}
