using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Models
{
    public class Movimento_Manual
    {
        public int MovimentoManual { get; set; }

        public decimal DAT_MES { get; set; }

        public decimal DAT_ANO { get; set; }

        public decimal NUM_LANCAMENTO { get; set; }

        public string COD_PRODUTO { get; set; }
        public virtual Produto_Cosif codprodutocosif { get; set; }

        public string COD_COSIF { get; set; }

        public string DES_DESCRICAO { get; set; }

        public DateTime DAT_MOVIMENTO { get; set; }

        public string COD_USUARIO { get; set; }

        public decimal VAL_VALOR { get; set; }
    }
}
