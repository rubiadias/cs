using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace necessário para trabalhar com EF
using System.Data.Entity;

namespace AppWF_com_camadas.Model
{
    public class ContextoDeDados : DbContext
    {
        public ContextoDeDados() : base("StringDeConexao") { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Prova> Provas { get; set; }
    }
}
