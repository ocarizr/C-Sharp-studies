using System;

namespace CursoCSharp_Xadrez.Tabuleiro
{
    class TabuleiroException : ApplicationException
    {
        public TabuleiroException(string message) : base(message) { }
    }
}
