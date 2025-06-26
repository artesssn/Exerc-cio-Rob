using Boleto;
using CartaoCredito;
using interfacePaga;
using Loja;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LojaVirtual loja = new LojaVirtual();
            IPagaB metodoPagamento = null;
            bool executando = true;
            while (executando)
            {
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1- Finalizar o pagamento");
                Console.WriteLine("2- Sair");
                int opcaoInicial = int.Parse(Console.ReadLine());
                switch (opcaoInicial)
                {
                    case 1:
                        Console.WriteLine("Hora de finalizar o pagamento!");
                        Console.WriteLine("Digite o valor da compra: ");
                        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.WriteLine("Como deseja pagar? Digite o número correspondente: \n1- Cartão de crédito \n2- Boleto bancário \n3- PIX ");
                        int opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                metodoPagamento = new PagamentoCartaoCredito();
                                break;

                            case 2:
                                metodoPagamento = new PagamentoBoleto();
                                break;
                            case 3:
                                metodoPagamento = new PagamentoPIX();
                                break;
                            default:
                                Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                                break;
                        }
                        loja.RealizarPagamento(metodoPagamento, valor);
                        break;
                    case 2:
                        executando = false;
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}