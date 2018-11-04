

using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class EducadorAppService : AppServiceBase<Educador>, IEducadorAppService
    {
        private readonly IEducadorService _educadorService;

        public EducadorAppService(IEducadorService educadorService)
        : base(educadorService)
        {
            _educadorService = educadorService;
        }
    }
}
