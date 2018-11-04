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
    public class OficinaViewModel
    {
        [Key]
        public int OficinaId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o nome.")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher a descrição.")]
        [MaxLength(500)]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [ForeignKey("TurnoId")]
        public virtual Turno Turno { get; set; }

        [DisplayName("Turno")]
        public int TurnoId { get; set; }
    }
}