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
    public class OficinaService : ServiceBase<Oficina>, IOficinaService
    {
        private readonly IOficinaRepository _oficinaRepository;

        public OficinaService(IOficinaRepository oficinaRepository)
            :base(oficinaRepository)
        {
            _oficinaRepository = oficinaRepository;
        }
    }
}
