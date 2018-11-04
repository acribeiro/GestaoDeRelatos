
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class RelatoAppService : AppServiceBase<Relato>, IRelatoAppService
    {
        private readonly IRelatoService _relatoService;

        public RelatoAppService(IRelatoService relatoService)
        :base(relatoService)
        {
            _relatoService = relatoService;
        }
    }
}
