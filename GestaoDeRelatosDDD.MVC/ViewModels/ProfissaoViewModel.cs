using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoDeRelatosDDD.MVC.ViewModels
{
    public class ProfissaoViewModel
    {
        [Key]
        public int ProfissaoId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher a profissão.")]
        [MaxLength(150)]
        public string Nome { get; set; }
    }
}