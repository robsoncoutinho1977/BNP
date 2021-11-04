using AplicacaoWebBNPTeste.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            Services.Services _services = new Services.Services(_configuration); // Instancia classe de serviços que dá acesso aos métodos da API | Obrigatório a injeção de dependência IConfiguration

            #region Descrição
            List<Produto> listprodutos = new List<Produto>();
            var retornoprodutos = _services.RetornaProduto();
            listprodutos = retornoprodutos.Result;
            if (listprodutos != null)
            {
                ViewBag.DescricaoProduto = listprodutos;
                ViewBag.Produtos = listprodutos;
            }
            else
            {
                ViewBag.DescricaoProduto = null;
                ViewBag.Produtos = null;
            }
            #endregion Descrição

            #region Cosif
            List<Produto_Cosif> listcosif = new List<Produto_Cosif>();
            var retornocosif = _services.RetornaCosif();
            listcosif = retornocosif.Result;
            if (listcosif != null)
            {
                ViewBag.Cosif = listcosif;
            }
            else
            {
                ViewBag.Cosif = null;
            }
            #endregion Cosif

            return View();
        }

    }
}
