
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class ProfissaoAppService : AppServiceBase<Profissao>, IProfissaoAppService
    {
        private readonly IProfissaoService _profissaoService;

        public ProfissaoAppService(IProfissaoService profissaoService)
        :base(profissaoService)
        {
            _profissaoService = profissaoService;
        }
    }
}
