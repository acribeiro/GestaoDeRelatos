
using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class OficinaAppService : AppServiceBase<Oficina>, IOficinaAppService
    {
        private readonly OficinaService _oficinaService;

        public OficinaAppService(OficinaService oficinaService)
        :base(oficinaService)
        {
            _oficinaService = oficinaService;
        }
    }
}
