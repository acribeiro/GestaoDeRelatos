using AutoMapper;
using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestaoDeRelatosDDD.MVC.AutoMapper
{
    public class ViewModalToDomainMappingProfile : Profile
    {
        public ViewModalToDomainMappingProfile()
        {
            CreateMap<Educador, EducadorViewModel>();
            CreateMap<Educando, EducandoViewModel>();
            CreateMap<Oficina, OficinaViewModel>();
            CreateMap<Profissao, ProfissaoViewModel>();
            CreateMap<Relato, RelatoViewModel>();
            CreateMap<Tecnico, TecnicoViewModel>();
            CreateMap<Turno, TurnoViewModel>();
            CreateMap<Unidade, UnidadeViewModel>();
        }

        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
    }
}