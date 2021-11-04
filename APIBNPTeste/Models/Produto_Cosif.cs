using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIBNPTeste.Models
{
    [Table("PRODUTO_COSIF")]
    public class Produto_Cosif
    {
        [Key]
        [MaxLength(4)]
        [ForeignKey("PRODUTO")]
        [Display(Name = "Código do Produto")]
        [Required(ErrorMessage = "Código do Produto é um campo obrigatório!")]
        public string COD_PRODUTO { get; set; }
        public virtual Produto codproduto { get; set; }

        [MaxLength(11)]
        [Display(Name = "Código Cosif")]
        public string COD_COSIF { get; set; }

        [MaxLength(6)]
        [Display(Name = "Classificação")]
        [Required(ErrorMessage = "Código de Classificação é um campo obrigatório!")]
        public string COD_CLASSIFICACAO { get; set; }

        [MaxLength(1)]
        [Display(Name = "Status")]
        [Required(ErrorMessage = "Status é um campo obrigatório!")]
        public string STA_STATUS { get; set; }

        public virtual Movimento_Manual movimentomanual { get; set; }
    }
}
