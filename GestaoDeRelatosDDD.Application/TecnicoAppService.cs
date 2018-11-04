
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class TecnicoAppService : AppServiceBase<Tecnico>, ITecnicoAppService
    {
        private readonly TecnicoService _tecnicoService;

        public TecnicoAppService(TecnicoService tecnicoService)
        :base(tecnicoService)
        {
            _tecnicoService = tecnicoService;
        }
    }
}
