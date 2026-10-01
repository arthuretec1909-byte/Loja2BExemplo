using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja2BExemplo
{
    class Pedido
    {         
        // ATRIBUTOS

        public string? NomeDoce { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public int IdadeCliente { get; set; }


        // MÉTODOS


       public double CalcularDesconto()
       {
           double valorTotal = PrecoUnitario * Quantidade;
           if (Quantidade >= 10)
           {
               return valorTotal * 0.10;
           }
               return 0.0;
       }

       //Método para calcular o valor final com o desconto aplicado

       public double CalcularValorFinal()
       {
           double valorTotalBruto = PrecoUnitario * Quantidade;
           double desconto = CalcularDesconto();
           return valorTotalBruto - desconto;
       }

       //Método para calcular o parcelamento em 3x sem juros (se o valor for válido)

       public double CalcularParcela()
       {
        return CalcularValorFinal() / 3.0;
       }

       //Método para validar se o cliente tem direito a um brinde especial (ex: maiores de 18 anos ou compra grande)

      public bool ValidarBrinde()
      {
        return (IdadeCliente >= 18 && Quantidade >= 5) || (CalcularValorFinal() > 100.0);
      }

    }
    
}
