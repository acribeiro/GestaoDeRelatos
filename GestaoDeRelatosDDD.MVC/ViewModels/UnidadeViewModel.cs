using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestaoDeRelatosDDD.MVC.ViewModels
{
    public class UnidadeViewModel
    {
        [Key]
        public int UnidadeId { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o nome.")]
        [MaxLength(150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o endereço.")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
    }
}