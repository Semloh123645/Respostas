using System;

namespace Desafio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CartaoBandeiraMaster cbm = new CartaoBandeiraMaster();
            cbm.pagamentoDebito();
            
            cartaoBandeiraVisa cbv = new cartaoBandeiraVisa();  
            cbv.pagamentoDebito();
            
        }
    }
}
