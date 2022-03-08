using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Loja.requisições
{
    public class RequisicaoPost
    {
        public bool status { get; set; }

        public async Task postProduto(string nomeProduto, int quantidadeproduto, decimal valorproduto)
        {
            try
            {
                status = true;

                var httpClient = new HttpClient();
                var objeto = new { nomeProduto = nomeProduto, quantidadeProduto = quantidadeproduto, valorProduto = valorproduto };

                var content = ToRequest(objeto);
                var response = await httpClient.PostAsync("https://localhost:5001/Produtos", content);
            }
            catch (Exception)
            {

                status = false;
            }
       
        }


        public async Task postCliente(string nomeCliente, string sobrenome, string cpf, string dataNascimento)
        {
            try
            {
                status = true;

                var httpClient = new HttpClient();
                var objeto = new { nomeCliente = nomeCliente, sobrenomeCliente = sobrenome, Cpf = cpf, dataNascimento = dataNascimento };

                var content = ToRequest(objeto);
                var response = await httpClient.PostAsync("https://localhost:5001/Cliente", content);
            }
            catch (Exception)
            {

                status = false;
            }

        }

        public async Task postCompra(string nomeCliente, string nomeProduto, int quantidade, decimal valorTotal)
        {
            try
            {
                status = true;

                var httpClient = new HttpClient();
                var objeto = new { nomeProduto = nomeProduto, quantidadeComprada = quantidade, valorTotal = valorTotal, nomeCliente = nomeCliente };

                var content = ToRequest(objeto);
                var response = await httpClient.PostAsync("https://localhost:5001/Venda", content);
            }
            catch (Exception)
            {

                status = false;
            }

        }

        private static StringContent ToRequest(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            return data;
        }
    }
}
