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
    public class EducandoService : ServiceBase<Educando>, IEducandoService
    {
        private readonly IEducandoRepository _educandoRepository;

        public EducandoService(IEducandoRepository educandoRepository)
            : base(educandoRepository)
        {
            _educandoRepository = educandoRepository;
        }
    }
}
