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
    public class EducandoViewModel
    {
        [Key]
        public int EducandoId { get; set; }

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

        [Required(ErrorMessage = "É obrigatório preencher o nome da mãe.")]
        [MaxLength(150)]
        [DisplayName("Nome da Mãe")]
        public string NomeDaMae { get; set; }

        [MaxLength(150)]
        [DisplayName("Nome do Pai")]
        public string NomeDoPai { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o telefone do responsável.")]
        [DisplayName("Telefone do Responsável")]
        public string TelefoneResponsavel { get; set; }

        [Required(ErrorMessage = "É obrigatório preencher o endereço.")]
        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [ForeignKey("UnidadeId")]
        public virtual Unidade Unidade { get; set; }

        [DisplayName("Unidade")]
        public int UnidadeId { get; set; }

        [ForeignKey("TurnoId")]
        public virtual Turno Turno { get; set; }

        [DisplayName("Turno")]
        public int TurnoId { get; set; }
    }
}