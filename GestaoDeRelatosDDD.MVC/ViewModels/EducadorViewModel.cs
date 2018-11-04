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
    public class EducadorViewModel
    {
        [Key]
        public int EducadorId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o nome.")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o Sobrenome.")]
        [MaxLength(150)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher a data de nascimento.")]
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataNascimento { get; set; }

        public virtual Unidade Unidade { get; set; }

        [DisplayName("Unidade")]
        public int UnidadeId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o telefone.")]
        public string Telefone { get; set; }

        [ForeignKey("OficinaId")]
        public virtual Oficina Oficina { get; set; }

        [DisplayName("Oficina")]
        public int OficinaId { get; set; }

        [ForeignKey("TurnoId")]
        public virtual Turno Turno { get; set; }

        [DisplayName("Turno")]
        public int TurnoId { get; set; }
    }
}