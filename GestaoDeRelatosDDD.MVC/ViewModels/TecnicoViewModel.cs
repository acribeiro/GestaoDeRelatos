using GestaoDeRelatosDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestaoDeRelatosDDD.MVC.ViewModels
{
    public class TecnicoViewModel
    {
        [Key]
        public int TecnicoId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o nome.")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o Sobrenome.")]
        [MaxLength(150)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o telefone.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o registro profissional.")]
        [DisplayName("Registro Profissional")]
        public string RegistroProfissinal { get; set; }

        [DisplayName("Profissão")]
        [ForeignKey("ProfissaoId")]
        public virtual Profissao Profissao { get; set; }

        public int ProfissaoId { get; set; }

        [ForeignKey("UnidadeId")]
        public virtual Unidade Unidade { get; set; }

        [DisplayName("Unidade")]
        public int UnidadeId { get; set; }

        
    }
}