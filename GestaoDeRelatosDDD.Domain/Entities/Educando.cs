using System;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Educando
    {
        public int EducandoId { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string NomeDaMae { get; set; }

        public string NomeDoPai { get; set; }

        public string TelefoneResponsavel { get; set; }

        public string Endereco { get; set; }

        public bool Ativo { get; set; }

        public int UnidadeId { get; set; }

        public virtual Unidade Unidade { get; set; }

        public int TurnoId { get; set; }

        public virtual Turno Turno { get; set; }
    }
}
