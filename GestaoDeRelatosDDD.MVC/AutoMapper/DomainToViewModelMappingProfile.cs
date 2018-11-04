using AutoMapper;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeRelatosDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<EducadorViewModel, Educador>();
            CreateMap<EducandoViewModel, Educando>();
            CreateMap<OficinaViewModel, Oficina>();
            CreateMap<ProfissaoViewModel, Profissao>();
            CreateMap<RelatoViewModel, Relato>();
            CreateMap<TecnicoViewModel, Tecnico>();
            CreateMap<TurnoViewModel, Turno>();
            CreateMap<UnidadeViewModel, Unidade>();
        }

        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
    }
}