using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Models
{
    public class Produto
    {
        public string COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }
        public virtual Produto_Cosif produtocosif { get; set; }
    }
}
