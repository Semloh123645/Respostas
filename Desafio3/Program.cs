using System;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("Creme", 100, "acrescimo", 5);
            p.DescontoAcrescimo();
        }
    }
}
