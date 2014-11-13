namespace Controle.Dominio
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoDeDespesa")]
    public class TipoDeDespesa : Entity
	{
        public virtual string Descricao { get; set; }

        public TipoDeDespesa() { }

        public TipoDeDespesa(string Descricao)
        {
            this.Descricao = Descricao;
        }
	}
}

