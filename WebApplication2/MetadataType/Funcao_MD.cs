using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [MetadataType(typeof(Funcao_MD))]
    public partial class Funcao { };
    public class Funcao_MD
    {
        [DisplayName("Funcão Id")]
        public int FuncaoId { get; set; }

        [Required(ErrorMessage = "Campo Obrigadorio")]
        [DisplayName("Descricao Funcão")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigadorio")]
        [StringLength(5, ErrorMessage = "No Maximo 5 Caracteres")]
        public string Siglas { get; set; }
    }
}