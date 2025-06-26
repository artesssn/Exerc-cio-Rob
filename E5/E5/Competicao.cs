using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5
{
    internal class Competicao
    {
        public string Nome { get; set; }
        public List<Competidor> Competidores { get; set; }

        public Competicao(string nome)
        {
            Nome = nome;
            Competidores = new List<Competidor>();
        }

        public void AdicionarCompetidor(Competidor c)
        {
            Competidores.Add(c);
        }

        public void ListarCompetidores()
        {
            foreach (var c in Competidores)
            {
                Console.WriteLine($"{c.Nome}, {c.Idade} anos, Modalidade: {c.Modalidade}");
            }
        }
    }

}
