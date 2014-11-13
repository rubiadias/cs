using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle.Dominio;

namespace ConsoleAPP
{
    class Program
    {
        private static Banco db = new Banco();
       
        static void Main(string[] args)
        {
            //IncluirConta();
            //IncluirTipoDeDespesa();
            //IncluirTipoDeReceita();

            //ListaContas();
            //ListarTiposDeDespesas();
            //ListarTiposDeReceitas();

            /*
            TipoDeDespesa tipoDespesa = db.TiposDeDespesas.Single(t => t.Descricao == "Alimentação");

            Despesa despesa1 = new Despesa();
            despesa1.Descricao = "Frutas e Verduras";
            despesa1.Valor = new Decimal(99.00);
            despesa1.Data = DateTime.Now;
            despesa1.Tipo = tipoDespesa;

            Despesa despesa2 = new Despesa();
            despesa2.Descricao = "Compra mensal";
            despesa2.Valor = new Decimal(250.00);
            despesa2.Data = DateTime.Now;
            despesa2.Tipo = tipoDespesa;

            db.Despesas.Add(despesa1);
            db.Despesas.Add(despesa2);

            TipoDeReceita tipoReceita = db.TiposDeReceitas.Single(t => t.Descricao == "Aluguel");

            Receita receita = new Receita();
            receita.Data = DateTime.Now;
            receita.Descricao = "Pagamento de salário";
            receita.Valor = new Decimal(1500.00);
            receita.Tipo = tipoReceita;

            db.Receitas.Add(receita);

            Conta conta = db.Contas.Single(c => c.Identificacao == "CTA001");
            conta.Debitar(despesa1);
            conta.Debitar(despesa2);
            conta.Creditar(receita);

            db.SaveChanges();
             */

            Console.WriteLine("Pressione ENTER...");
            Console.ReadLine(); //pausa
        }

        private static void ListaContas()
        {
            IEnumerable<Conta> lista = db.Contas;
            foreach (var conta in lista)
            {
                Console.WriteLine("Conta: {0}, Saldo: {1}", 
                    conta.Identificacao,
                    conta.Saldo);
            }
        }

        private static void ListarTiposDeReceitas()
        {
            IEnumerable<TipoDeReceita> lista = db.TiposDeReceitas;
            foreach (var tipo in lista)
            {
                Console.WriteLine("Tipo de receitas: {0}", tipo.Descricao);
            }
        }

        private static void ListarTiposDeDespesas()
        {
            IEnumerable<TipoDeDespesa> lista = db.TiposDeDespesas;
            foreach (var tipo in lista)
            {
                Console.WriteLine("Tipo de despesa: {0}", tipo.Descricao);
            }
        }

        private static void IncluirConta()
        {
            Conta conta = new Conta();
            conta.Identificacao = "CTA001";
            conta.DataDeAbertura = DateTime.Now;
            Decimal valor = new Decimal(1000.00);
            conta.Saldo = valor;
            db.Contas.Add(conta);
            db.SaveChanges();
        }

        private static void IncluirTipoDeReceita()
        {
            List<TipoDeReceita> lista = new List<TipoDeReceita>();
            lista.Add(new TipoDeReceita("Salário"));
            lista.Add(new TipoDeReceita("Aluguel"));
            lista.Add(new TipoDeReceita("Honorários"));
            db.TiposDeReceitas.AddRange(lista);
            db.SaveChanges();
        }

        private static void IncluirTipoDeDespesa()
        {
            List<TipoDeDespesa> lista = new List<TipoDeDespesa>();
            lista.Add(new TipoDeDespesa("Alimentação"));
            lista.Add(new TipoDeDespesa("Transporte"));
            lista.Add(new TipoDeDespesa("Educação"));
            db.TiposDeDespesas.AddRange(lista);
            db.SaveChanges();
        }
    }
}
