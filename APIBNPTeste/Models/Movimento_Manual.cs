using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIBNPTeste.Models
{
    [Table("MOVIMENTO_MANUAL")]
    public class Movimento_Manual
    {
        [Key]
        public int MovimentoManual { get; set; }

        [Display(Name = "Mês")]
        public decimal DAT_MES { get; set; }

        [Display(Name = "Ano")]
        public decimal DAT_ANO { get; set; }

        [Display(Name = "Número de Lançamento")]
        public decimal NUM_LANCAMENTO { get; set; }

        [MaxLength(4)]
        [Display(Name = "Código do Produto")]
        public string COD_PRODUTO { get; set; }

        [MaxLength(11)]
        [Display(Name = "Código Cosif")]
        public string COD_COSIF { get; set; }

        [MaxLength(50)]
        [Display(Name = "Descrição")]
        public string DES_DESCRICAO { get; set; }

        [Display(Name = "Data")]
        public DateTime DAT_MOVIMENTO { get; set; }

        [MaxLength(1)]
        [Display(Name = "Cód. Usuário")]
        public string COD_USUARIO { get; set; }

        [Display(Name = "Valor")]
        public decimal VAL_VALOR { get; set; }
    }
}
