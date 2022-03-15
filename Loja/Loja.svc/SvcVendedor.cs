using Loja.Cliente;
using Loja.requisições;
using Loja.Requisições;
using Loja.Vendas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Loja.Cliente.Clientes;
using static Loja.requisições.Produto;
using static Loja.Vendas.Compras;

namespace Loja.svc
{
    public class SvcVendedor
    {
        public static bool LoginVendedor(string nomeEscrito, string senhaEscrita)
        {
            if (nomeEscrito == "root" & senhaEscrita == "root")
            {
                return true;
            }
            return false;
        }
        public static void InsereProduto(string nome, string valor, string quantidade)
        {
            var produto = new Produto(nome, quantidade, valor);

            var requisicao = new RequisicaoPost();
            requisicao.postProduto(produto.nomeProduto, Convert.ToInt32(produto.quantidadeProduto), Convert.ToDecimal(produto.ValorProduto)) ;
        }

        public static List<Produto> carregaDadoProduto()
        {
            var requisicao = new requisicaoGet();

            string vjson = requisicao.fazGet("produtos");
            ListaDeProdutos.produtos = ListaDeProdutos.DesSerializedClassUnit(vjson);
            return ListaDeProdutos.produtos;
        }

        public static List<Compras> carregaDadoVendas()
        {
            var requisicao = new requisicaoGet();

            string vjson = requisicao.fazGet("Venda");
            ListaCompras.listaDeCompras = ListaCompras.DesSerializedClassUnit(vjson);
            return ListaCompras.listaDeCompras;
        }

        public static List<Clientes> carregaDadosCliente()
        {
            var requisicao = new requisicaoGet();

            string vjson = requisicao.fazGet("cliente");
            ListaDeClientes.listaDeClientes = ListaDeClientes.DesSerializedClassUnit(vjson);
            return ListaDeClientes.listaDeClientes;
        }
    }
}
