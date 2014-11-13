namespace Controle.Dominio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Contas")]
    public class Conta : Entity
    {
        public Conta()
        {
            if (this.Creditos == null)
            {
                this.Creditos = new List<Receita>();
            }

            if (this.Debitos == null)
            {
                this.Debitos = new List<Despesa>();
            }
        }
        public virtual String Identificacao { get; set; }
        public virtual DateTime DataDeAbertura { get; set; }
        public virtual Decimal Saldo { get; set; }
        public virtual IEnumerable<Receita> Creditos { get; set; }
        public virtual IEnumerable<Despesa> Debitos { get; set; }

        public virtual void Creditar(Receita receita)
        {
            Creditos.ToList().Add(receita);
            receita.Conta = this;
            this.Saldo += receita.Valor;
        }

        public virtual void Debitar(Despesa despesa)
        {
            Debitos.ToList().Add(despesa);
            despesa.Conta = this;
            this.Saldo -= despesa.Valor;
        }
    }
}

