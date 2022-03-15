using Loja.svc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Forms
{
    public partial class FrmVerVendas : Form
    {
        public FrmVerVendas()
        {
            InitializeComponent();
        }

        private void FrmVerVendas_Load(object sender, EventArgs e)
        {

            var svc = new SvcVendedor();
            foreach (var dado in SvcVendedor.carregaDadoVendas())
            {
                string dadoComposto = $"nome: {dado.nomeCliente}, produto comprado: {dado.nomeProduto}, quantidade comprada: {dado.quantidadeComprada}, valor pago: R$ {dado.ValorTotal}";
                ListVendas.Items.Add(dadoComposto);
            }
            /*       var requisicao = new requisicaoGet();
                   var vjson = requisicaoGet.fazGet("Venda");
                   var lista = new ListaCompras();
                   lista.listaDeCompras = ListaCompras.DesSerializedClassUnit(vjson);

                   foreach (var dado in lista.listaDeCompras)
                   {
                       string dadoComposto = $"nome: {dado.nomeCliente}, produto comprado: {dado.nomeProduto}, quantidade comprada: {dado.quantidadeComprada}, valor pago: R$ {dado.ValorTotal}";
                       ListVendas.Items.Add(dadoComposto);
                   }*/
        }
    }
}
