using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Tecnico
    {
        public int TecnicaId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public string RegistroProfissinal { get; set; }

        public bool Ativo { get; set; }

        public int UnidadeId { get; set; }

        public virtual Unidade Unidade { get; set; }

        public int ProfissaoId { get; set; }

        public virtual Profissao Profissao { get; set; }


    }
}
