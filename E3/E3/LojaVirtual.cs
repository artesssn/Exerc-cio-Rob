using interfacePaga;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Loja
{
    internal class LojaVirtual
    {
        public void RealizarPagamento(IPaga metodo, double valor)
        {
            if (metodo != null)
            {
                metodo.ProcessarPagamento(valor);
                Console.WriteLine($"[MENSAGEM DA LOJA] Pagamento realizado com sucesso via {metodo}.");
            }
            else
            {
                Console.WriteLine("Pagamento não realizado.");
            }

        }
    }
}