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
    public class EducadorService : ServiceBase<Educador>, IEducadorService
    {
        private readonly IEducadorRepository _educadorRepository;

        public EducadorService(IEducadorRepository educadorRepository)
            :base(educadorRepository)
        {
            _educadorRepository = educadorRepository;
        }
    }
}
