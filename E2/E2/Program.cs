using System;
using System.Collections.Generic;
using System.Linq;
using classeProduto;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto _produto = new Produto();
            Console.WriteLine("\t BEM VINDO AO SISTEMA DE GERENCIAMENTO DE PRODUTO");
            bool executando = true;
            while (executando)
            {

                Console.WriteLine("\nDigite o número correspondente ao que deseja realizar: ");
                Console.WriteLine("1- Cadastrar um produto");
                Console.WriteLine("2- Remover produto");
                Console.WriteLine("3- Pesquisar produto");
                Console.WriteLine("4- Encontrar produto de menor valor");
                Console.WriteLine("5- Sair do sistema");

                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        _produto.CadastrarProduto();
                        break;
                    case 2:
                        _produto.RemoverProduto();
                        break;
                    case 3:
                        _produto.PesquisarProduto();
                        break;
                    case 4:
                        _produto.ProdutoMenorValor();
                        break;
                    case 5:
                        executando = false;
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite um número de 1 a 5.");
                        break;
                }
                Console.WriteLine("\n Pressione qualquer tecla para continuar...");
                Console.ReadKey();

                Console.Clear();
            }

        }
    }
}