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
    public class ProfissaoService : ServiceBase<Profissao>, IProfissaoService
    {
        private readonly IProfissaoRepository _profissaoRepository;

        public ProfissaoService(IProfissaoRepository profissaoRepository)
            :base(profissaoRepository)
        {
            _profissaoRepository = profissaoRepository;
        }
    }
}
