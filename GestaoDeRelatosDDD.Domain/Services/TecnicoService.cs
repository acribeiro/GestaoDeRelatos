using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Repositories;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Domain.Services
{
    public class TecnicoService : ServiceBase<Tecnico>, ITecnicoService
    {
        private readonly ITecnicoRepository _tecnicoRepository;

        public TecnicoService(ITecnicoRepository tecnicoRepository)
            :base(tecnicoRepository)
        {
            _tecnicoRepository = tecnicoRepository;
        }
    }
}
