using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWF_com_camadas.Model
{
    public class Aluno
    {
        public Aluno()
        {
            Provas = new List<Prova>();
        }

        public int Id { get; set; }
        //public int AlunoId { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public virtual List<Prova> Provas { get; set; }

        public double GetMedia()
        {
            double valorTotal = 0;
            foreach (var prova in Provas)
            {
                valorTotal += prova.Nota;                
            }
            return valorTotal / Provas.Count;
        }

    }
}
