using E5;
using System;
class Program
{
    static void Main()
    {
        Competicao comp = null;
        int opcao;

        do
        {
            Console.WriteLine("\n--- MENU COMPETIÇÃO ---");
            Console.WriteLine("1. Criar Competição");
            Console.WriteLine("2. Adicionar Competidor");
            Console.WriteLine("3. Listar Competidores");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome da competição: ");
                    string nome = Console.ReadLine();
                    comp = new Competicao(nome);
                    Console.WriteLine("Competição criada.");
                    break;
                case 2:
                    if (comp == null)
                    {
                        Console.WriteLine("Crie a competição primeiro.");
                        break;
                    }
                    Competidor c = new Competidor();
                    Console.Write("Nome do competidor: ");
                    c.Nome = Console.ReadLine();
                    Console.Write("Idade: ");
                    c.Idade = int.Parse(Console.ReadLine());
                    Console.Write("Modalidade: ");
                    c.Modalidade = Console.ReadLine();
                    comp.AdicionarCompetidor(c);
                    Console.WriteLine("Competidor adicionado.");
                    break;
                case 3:
                    if (comp == null) Console.WriteLine("Nenhuma competição criada.");
                    else comp.ListarCompetidores();
                    break;
            }

        } while (opcao != 4);
    }
}
