namespace Controle.Dominio
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Receitas")]
    public class Receita : Entity
	{
		public virtual DateTime Data { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Decimal Valor { get; set; }
        public virtual TipoDeReceita Tipo { get; set; }
        public virtual Conta Conta { get; set; } 
	}
}

