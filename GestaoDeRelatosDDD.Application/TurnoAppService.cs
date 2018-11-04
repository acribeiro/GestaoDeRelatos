using GestaoDeRelatosDDD.Application.Interface;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Domain.Interfaces.Services;

namespace GestaoDeRelatosDDD.Application
{
    public class TurnoAppService :AppServiceBase<Turno>, ITurnoAppService
    {
        private readonly ITurnoService _turnoService;

        public TurnoAppService(ITurnoService turnoService)
        :base(turnoService)
        {
            _turnoService = turnoService;
        }
    }
}
