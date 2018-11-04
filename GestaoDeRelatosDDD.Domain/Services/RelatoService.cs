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
    public class RelatoService : ServiceBase<Relato>, IRelatoService
    {
        private readonly IRelatoRepository _relatoRepository;

        public RelatoService(IRelatoRepository relatoRepository)
            :base(relatoRepository)
        {
            _relatoRepository = relatoRepository;
        }
    }
}
