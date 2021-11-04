using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Models
{
    public class Produto_Cosif
    {
        public string COD_PRODUTO { get; set; }
        public virtual Produto codproduto { get; set; }
        public string COD_COSIF { get; set; }
        public string COD_CLASSIFICACAO { get; set; }
        public string STA_STATUS { get; set; }
        public virtual Movimento_Manual movimentomanual { get; set; }
    }
}
