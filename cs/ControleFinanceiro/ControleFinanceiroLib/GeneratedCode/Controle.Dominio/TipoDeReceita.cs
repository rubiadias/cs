namespace Controle.Dominio
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TipoDeReceita")]
    public class TipoDeReceita : Entity
	{
        public virtual string Descricao { get; set; }

        public TipoDeReceita() { }

        public TipoDeReceita(string Descricao)
        {
            this.Descricao = Descricao;
        }
	}
}

