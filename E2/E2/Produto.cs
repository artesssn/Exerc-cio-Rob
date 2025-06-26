using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace classeProduto
{
    public class Produto
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public static List<Produto> Produtos = new List<Produto>();

        public void CadastrarProduto()
        {
            Produto novoProduto = new Produto();
            Console.WriteLine("\nVamos cadastrar um produto...");
            Console.WriteLine("Digite a descrição do produto: ");
            novoProduto.Descricao = Console.ReadLine();
            Console.WriteLine("Digite o valor do produto: ");
            novoProduto.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Produtos.Add(novoProduto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }
        public void RemoverProduto()
        {
            Console.WriteLine("Digite a descrição do produto que deseja remover: ");
            string descricao = Console.ReadLine();
            Produto produtoEncontrado = Produtos.FirstOrDefault(a => a.Descricao == descricao);

            if (produtoEncontrado != null)
            {
                Produtos.Remove(produtoEncontrado);
                Console.WriteLine("Produto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void PesquisarProduto()
        {
            Console.WriteLine("Digite a descrição do produto que deseja pesquisar: ");
            string descricao = Console.ReadLine();
            Produto produtoEncontrado = Produtos.FirstOrDefault(a => a.Descricao == descricao);

            if (produtoEncontrado != null)
            {
                Console.WriteLine("\n---- DETALHES DO PRODUTO: ----");
                Console.WriteLine($"Descrição do produto: {produtoEncontrado.Descricao} \nValor: R${produtoEncontrado.Valor:F2}");

            }
            else
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }
        public void ProdutoMenorValor()
        {
            double menorValor = double.MaxValue;
            Produto produtoMenor = null;
            for (int i = 0; i < Produtos.Count; i++)
            {
                if (Produtos[i].Valor < menorValor)
                {
                    menorValor = Produtos[i].Valor;
                    produtoMenor = Produtos[i];
                }
            }
            if (produtoMenor != null)
            {
                Console.WriteLine($"Produto com o menor valor: {produtoMenor.Descricao}");
                Console.WriteLine($"Valor: R${produtoMenor.Valor:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum produto encontrado.");
            }

        }
    }
}