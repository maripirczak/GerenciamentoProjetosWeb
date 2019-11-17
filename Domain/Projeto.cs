using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Projetos")]
    public class Projeto
    {
        public Projeto() { DataCriacaoProjeto = DateTime.Now; }

        //ANNOTATIONS ASP.NET Core
        [Key]
        public int ProjetoId { get; set; }

        [Display(Name = "NomeProjeto:")]
        [Required(ErrorMessage = "Campo Obrigatório")] //notação de campo obrigatório
        public string NomeProjeto { get; set; }

        public string DescricaoProjeto { get; set; }

        public string NomeEmpresa { get; set; }

        public DateTime DataCriacaoProjeto { get; set; }

        public string StatusProjeto { get; set; }

        public List<Job> Jobs { get; set; }

    }
}
