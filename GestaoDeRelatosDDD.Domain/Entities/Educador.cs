using System;
using System.Collections.Generic;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Educador
    {
        public int EducadorId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Telefone { get; set; }

        public bool Ativo { get; set; }

        public int UnidadeId { get; set; }

        public virtual Unidade Unidade { get; set; }

        public int OficinaId { get; set; }

        public virtual Oficina Oficina { get; set; }


    }
}
