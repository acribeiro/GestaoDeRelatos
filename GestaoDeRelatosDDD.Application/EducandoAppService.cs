

using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class EducandoAppService : AppServiceBase<Educando>, IEducandoAppService
    {
        private readonly IEducandoService _educandoService;

        public EducandoAppService(IEducandoService educandoService)
        :base(educandoService)
        {
            _educandoService = educandoService;
        }
    }
}
