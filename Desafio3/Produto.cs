using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio3
{
    public class Produto
    {
        public Produto(string descricao, double Valorreal,
            string operacao, double percentual)
        {
            Operacao = operacao;
            Percentual = percentual;
            valorReal = Valorreal;
            Percentual = percentual;

        }

        public string Descricao { get; set; }
        public double valorReal { get; set; }
        public string Operacao { get; set; }
        public double Percentual { get; set; }
        public double valorFinal { get; set; }

        public void DescontoAcrescimo()
        {
            if (this.Operacao.ToLower() == "desconto")
            {
                this.valorFinal = this.valorReal - (this.valorReal * this.Percentual / 100);
            }
            else if (this.Operacao.ToLower() == "acrescimo")
            {
                this.valorFinal = this.valorReal + (this.valorReal * this.Percentual / 100);

            }

            Console.WriteLine($"O produto com valor {this.valorReal:C}, " +
                $"com o {this.Operacao} de {this.Percentual}% " +
                $" agora tem o valor de: {this.valorFinal:C}" );

        }



    }
}
