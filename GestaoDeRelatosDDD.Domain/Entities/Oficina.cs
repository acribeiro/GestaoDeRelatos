﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Entities
{
    public class Oficina
    {
        public int OficinaId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Ativo { get; set; }

        public int TurnoId { get; set; }

        public virtual  Turno Turno { get; set; }
    }
}
