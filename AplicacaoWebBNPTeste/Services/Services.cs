using AplicacaoWebBNPTeste.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AplicacaoWebBNPTeste.Services
{
    public class Services
    {
        private readonly IConfiguration configuration;

        public Services(IConfiguration iConfig)
        {
            configuration = iConfig;
        }

        public async Task<List<Produto>> RetornaProduto()
        {
            string urlbase = configuration["Parametros:api_endpoint_urlbase"];
            string url = urlbase + configuration["Parametros:api_endpoint_get_produto"];

            List<Produto> produtos = new List<Produto>();
            try
            {
                HttpMessageHandler handler = new HttpClientHandler()
                {
                };

                var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri(url),
                    Timeout = new TimeSpan(0, 2, 0)
                };

                httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (jsonResponse != null)
                {
                    var jsonProdutos = JsonConvert.DeserializeObject<List<Produto>>(jsonResponse);
                    produtos = jsonProdutos;
                }
                
                return produtos;
            }
            catch (Exception ex)
            {
                produtos = null;
                return produtos;
            }
        }

        public async Task<List<Produto_Cosif>> RetornaCosif()
        {
            string urlbase = configuration["Parametros:api_endpoint_urlbase"];
            string url = urlbase + configuration["Parametros:api_endpoint_get_cosif"];

            List<Produto_Cosif> produtos = new List<Produto_Cosif>();
            try
            {
                HttpMessageHandler handler = new HttpClientHandler()
                {
                };

                var httpClient = new HttpClient(handler)
                {
                    BaseAddress = new Uri(url),
                    Timeout = new TimeSpan(0, 2, 0)
                };

                httpClient.DefaultRequestHeaders.Add("ContentType", "application/json");
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                var jsonResponse = await response.Content.ReadAsStringAsync();

                if (jsonResponse != null)
                {
                    var jsonProdutos = JsonConvert.DeserializeObject<List<Produto_Cosif>>(jsonResponse);
                    produtos = jsonProdutos;
                }

                return produtos;
            }
            catch (Exception ex)
            {
                produtos = null;
                return produtos;
            }
        }

    }
}
