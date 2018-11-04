using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Relato
    {
        public int RelatoId { get; set; }

        public string RelatoDescricao { get; set; }

        public string RelatoDescricaoCurto
        {
            get
            {
                if (RelatoDescricao.Length > 100)
                {
                    return RelatoDescricao.Substring(0, 100) + "...";
                }
                return RelatoDescricao;
            }
        }

        public string Encaminhamento { get; set; }

        public string EncaminhamentoCurto
        {
            get
            {
                if (!string.IsNullOrEmpty(Encaminhamento) && Encaminhamento.Length > 100)
                {
                    return Encaminhamento.Substring(0, 100) + "...";
                }
                return Encaminhamento;
            }
        }

        public DateTime DataDoRelato { get; set; }

        public int TecnicoId { get; set; }

        public virtual Tecnico Tecnico { get; set; }

        public int EducadorId { get; set; }

        public virtual Educador Educador { get; set; }

        public int EducandoId { get; set; }

        public virtual Educando Educando { get; set; }

    }
}
