
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class UnidadeAppService : AppServiceBase<Unidade>, IUnidadeAppService
    {
        private readonly IUnidadeService _unidadeService;

        public UnidadeAppService(IUnidadeService unidadeService)
        :base(unidadeService)
        {
            _unidadeService = unidadeService;
        }
    }
}
