using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Models
{
    public class BNPClientContext : DbContext
    {
        public BNPClientContext()
        {
        }

        public BNPClientContext(DbContextOptions<BNPClientContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Produto_Cosif> ProdutoCosifs { get; set; }
        public DbSet<Movimento_Manual> MovimentoManuais { get; set; }
    }
}
