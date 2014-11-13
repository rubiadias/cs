using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_01
{
    class Program
    {
        static void Main(string[] args)
        {

            char continuarCadastrando = 'S';

            List<Aluno> listaDeAlunos = new List<Aluno>();

            while (continuarCadastrando == 'S')
            {            
                Console.WriteLine("Informe o nome ou pressione ENTER para sair:");
                string nome = Console.ReadLine();

                if (nome != null && nome != "")
                {
                    Console.WriteLine("Informe a matrícula:");
                    string matricula = Console.ReadLine();

                    Aluno aluno = new Aluno();
                    aluno.Nome = nome;
                    aluno.Matricula = matricula;

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Informe a nota da {0}a. prova:", (i + 1));
                        string n = Console.ReadLine();
                        double notaDigitada = double.Parse(n);

                        Prova prova = new Prova();                        
                        prova.Nota = notaDigitada;
                        aluno.Provas.Add(prova);
                    }

                    listaDeAlunos.Add(aluno);
                }
                else
                {
                    continuarCadastrando = 'N';
                }
            }

            foreach (var aluno in listaDeAlunos)
            {
                Console.WriteLine("Aluno: {0} - Média: {1}", aluno.Nome, aluno.getMedia());                
            }

            Console.ReadLine(); //pausa
        }
    }
}
