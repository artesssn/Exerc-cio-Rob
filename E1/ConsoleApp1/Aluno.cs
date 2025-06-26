using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicio1
{
    public class Aluno
    {
        public string RA { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public static List<Aluno> listaAlunos = new List<Aluno>();
        private static int proximoRA = 1;

        public static void CadastrarAluno()
        {
            Aluno novoAluno = new Aluno();
            novoAluno.RA = proximoRA.ToString();
            Console.WriteLine("Digite o nome do aluno: ");
            novoAluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade do aluno: ");
            novoAluno.Idade = int.Parse(Console.ReadLine());
            listaAlunos.Add(novoAluno);
            Console.WriteLine($"Aluno cadastrado com o RA {novoAluno.RA}");
            proximoRA++;
        }
        public static void ListarAlunos()
        {
            Console.WriteLine("\t Listando dos alunos");
            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"\n RA: {aluno.RA} \n Nome: {aluno.Nome} \n Idade: {aluno.Idade}");
            }
        }
        public static void AlterarDados()
        {
            Console.WriteLine("Digite o RA do aluno que procura: ");
            string ra = Console.ReadLine();
            Aluno alunoEncontrado = listaAlunos.FirstOrDefault(a => a.RA == ra);

            if (alunoEncontrado != null)
            {
                Console.WriteLine("O que você deseja alterar? Digite um número: ");
                Console.WriteLine("1- Nome");
                Console.WriteLine("2- Idade");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"Nome do aluno que deseja alterar:{alunoEncontrado.Nome}");
                        Console.WriteLine("Digite o nome com as alterações: ");
                        string nomeAlterado = Console.ReadLine();
                        alunoEncontrado.Nome = nomeAlterado;
                        Console.WriteLine($"Nome alterado com sucesso! Nome do aluno corrigido: {alunoEncontrado.Nome}");
                        break;
                    case 2:
                        Console.WriteLine($"Idade do aluno que deseja alterar: {alunoEncontrado.Idade}");
                        Console.WriteLine("Digite a nova idade do aluno: ");
                        int idadeAlterada = int.Parse(Console.ReadLine());
                        alunoEncontrado.Idade = idadeAlterada;
                        Console.WriteLine($"Idade alterada com sucesso! Idade corrigida: {alunoEncontrado.Idade}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite 1 ou 2.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno encontrado! Digite um RA válido.");
                Console.ReadLine();

            }
        }
        public static void RemoverAluno()
        {
            Console.WriteLine("Digite o RA do aluno que deseja alterar: ");
            string ra = Console.ReadLine();
            Aluno alunoEncontrado = listaAlunos.FirstOrDefault(a => a.RA == ra);
            if (alunoEncontrado != null)
            {
                Console.WriteLine($"O(a) aluno(a) {alunoEncontrado.Nome} foi removido com sucesso.");
                listaAlunos.Remove(alunoEncontrado);
            }
        }
    }
}