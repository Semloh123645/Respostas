using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1
{
    public class CartaoBandeiraMaster : IPagamentoCartao
    {
        
        public void pagamentoCredito()
        {
            Console.WriteLine("Tipo de pagamento: Crédito!");
            Console.WriteLine("Pago com Master");
        }

        public void pagamentoDebito()
        {
            Console.WriteLine("Tipo de pagamento: Débito!");
            Console.WriteLine("Pago com Master");


        }
    }
}
