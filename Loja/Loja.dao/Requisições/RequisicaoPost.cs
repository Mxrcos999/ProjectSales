using Loja.Cliente;
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
        public static bool status { get; set; }


       
        public async Task postProduto(string nome, int quantidade, decimal valor)
        {
            try
            {
               
                
                var httpClient = new HttpClient();
                var objeto = new { nomeProduto = nome, quantidadeProduto = quantidade, valorProduto = valor };

                var content = ToRequest(objeto);
                var response = await httpClient.PostAsync("https://localhost:5001/Produtos", content);
            }
            catch (Exception)
            {

                status = false;
            }
       
        }


        public  async Task postCliente(Clientes cliente)
        {
           
          
            try
            {
                status = true;
                var httpClient = new HttpClient();
                var objeto = new { nomeCliente = cliente.nomeCliente, sobrenomeCliente = cliente.SobrenomeCliente, Cpf = cliente.Cpf, dataNascimento = cliente.DataNascimento };

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
