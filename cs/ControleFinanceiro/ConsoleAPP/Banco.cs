using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Controle.Dominio;

namespace ConsoleAPP
{
    public class Banco : DbContext
    {
        public DbSet<Conta> Contas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<TipoDeDespesa> TiposDeDespesas { get; set; }
        public DbSet<TipoDeReceita> TiposDeReceitas { get; set; }
    }
}
