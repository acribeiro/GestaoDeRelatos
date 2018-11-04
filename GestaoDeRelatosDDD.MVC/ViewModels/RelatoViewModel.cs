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
    public class RelatoViewModel
    {
        [Key]
        public int RelatoId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o relato.")]
        [MaxLength(5000)]
        [DataType(DataType.MultilineText)]
        [DisplayName("Relato")]
        public string RelatoDescricao { get; set; }

        public string RelatoDescricaoCurto
        {
            get
            {
                if (RelatoDescricao.Length > 100)
                {
                    return RelatoDescricao.Substring(0, 100) + "...";
                }
                return RelatoDescricao;
            }
        }

        [MaxLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Encaminhamento { get; set; }

        public string EncaminhamentoCurto
        {
            get
            {
                if (!string.IsNullOrEmpty(Encaminhamento) && Encaminhamento.Length > 100)
                {
                    return Encaminhamento.Substring(0, 100) + "...";
                }
                return Encaminhamento;
            }
        }

        [Required(ErrorMessage = "É obrigatório preencher a data de nascimento.")]
        [DataType(DataType.Date)]
        [DisplayName("Data do Relato")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime DataDoRelato { get; set; }

        [ForeignKey("TecnicoId")]
        [DisplayName("Técnico")]
        public virtual Tecnico Tecnico { get; set; }

        public int TecnicoId { get; set; }

        [ForeignKey("EducandoId")]
        public virtual Educando Educando { get; set; }

        public int EducandoId { get; set; }
    }
}