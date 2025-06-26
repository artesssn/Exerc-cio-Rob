using interfacePaga;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CartaoCredito
{
    public class PagamentoCartaoCredito : IPaga
    {
        public void ProcessarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor:F2} processado no cartão de crédito.");
        }
        public override string ToString()
        {
            return "Cartão de Crédito";
        }

    }
}