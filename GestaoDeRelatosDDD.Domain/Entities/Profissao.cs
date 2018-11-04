using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Profissao
    {
        public int ProfissaoId { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }
    }
}
