using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Exercício_01
{
    class Aluno
    {
        public string Nome;
        public string Matricula;
        public List<Prova> Provas = new List<Prova>();

        public double getMedia()
        {
            double totalDasNotas = 0;
            foreach (var prova in Provas)
            {
                //totalDasNotas = totalDasNotas + prova.Nota;     
                totalDasNotas += prova.getNota();
            }
            return totalDasNotas / Provas.Count;
        }


    }
}
