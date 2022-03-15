using Loja.Cliente;
using Loja.requisições;
using Loja.Requisições;
using Loja.ValuesObjects;
using Loja.Vendas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Loja.Cliente.Clientes;
using static Loja.requisições.Produto;
using static Loja.Vendas.Compras;

namespace Loja.svc
{
    public class SvcCliente
    {
        //        public string _Cpf { get; set; }
        public string Nome { get; set; }
        public static void registraCliente(string nome, string sobrenome, string cpf, string data)
        {

            cpf = cpf.Replace(",", "").Replace("-", "");
     
            var cliente = new Clientes(nome, sobrenome, cpf, data);
            new RequisicaoPost().postCliente(cliente);

 
        }
        public bool getJson(string cpf)
        {
              //_Cpf = cpf;
         
                var requisicao = new requisicaoGet();
                string vjson = requisicao.fazGetEspecifico("cliente", cpf);
                if (vjson == "[]")
                {
                    return false;
                }
                return true;

        }
        public static List<Produto> carregaDado()
        {
            var requisicao = new requisicaoGet();

            string vjson = requisicao.fazGet("produtos");
            ListaDeProdutos.produtos = ListaDeProdutos.DesSerializedClassUnit(vjson);
            return ListaDeProdutos.produtos;
        }
       
        public List<Compras> getNomeCliente(string cpf)
        {
         
         var requisicao = new requisicaoGet();

          var jsonNome = requisicao.fazGetEspecifico("cliente", cpf);
          var compras = new List<Compras>();
          compras =ListaCompras.DesSerializedClassUnit(jsonNome);
            List<Compras> listaDeCompras = new List<Compras>();
            foreach(var i in compras)
            {
                Nome = i.nomeCliente;
            }
            
            return listaDeCompras;


        }
        public  List<Compras> ListaDeCompras()
        {
            var requisicao = new requisicaoGet();

            //requisicao.fazGetEspecifico("clientes", nome);
            var json = requisicao.fazGetEspecifico("venda", Nome);
            return ListaCompras.DesSerializedClassUnit(json);


        }



    }
}
