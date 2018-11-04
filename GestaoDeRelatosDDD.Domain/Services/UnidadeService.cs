﻿using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Repositories;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Services
{
    public class UnidadeService :ServiceBase<Unidade>, IUnidadeService
    {
        private readonly IUnidadeRepository _unidadeRepository;

        public UnidadeService(IUnidadeRepository unidadeRepository)
            :base(unidadeRepository)
        {
            _unidadeRepository = unidadeRepository;
        }
    }
}
