using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIBNPTeste.Models
{
    [Table("PRODUTO")]
    public class Produto
    {
        [Key]
        [MaxLength(4)]
        [Display(Name = "Código do Produto")]
        [Required(ErrorMessage = "Código do Produto é um campo obrigatório!")]
        public string COD_PRODUTO { get; set; }

        [MaxLength(30)]
        [Display(Name = "Descrição do Produto")]
        public string DES_PRODUTO { get; set; }

        [MaxLength(1)]
        [Display(Name = "Status")]
        public string STA_STATUS { get; set; }

        public virtual Produto_Cosif produtocosif { get; set; }

    }
}
