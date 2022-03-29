using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1
{
    internal class cartaoBandeiraVisa : IPagamentoCartao
    {
        public void pagamentoCredito()
        {
            Console.WriteLine("Tipo de pagamento: Crédito!");
            Console.WriteLine("Pago com Visa!");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine("Tipo de pagamento: Débito!");
            Console.WriteLine("Pago com Visa!");


        }
    }
}
