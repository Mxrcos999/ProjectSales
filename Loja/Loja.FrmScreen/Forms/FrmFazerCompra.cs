
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
    public partial class FrmFazerCompra : Form
    {
        public string Cpf { get; set; }
        public string nomeCliente { get; set; }
        public FrmFazerCompra()
        {
            InitializeComponent();
        }
        public void recebeCpf(string cpf)
        {
            Cpf = cpf;

        }
        public string dadoComposto { get; set; }
        private void FrmFazerCompra_Load(object sender, EventArgs e)
        {

            foreach (var dados in SvcCliente.carregaDado())
            {
                dadoComposto = $"id: {dados.id} , nome do produto: {dados.nomeProduto} , quantidade disponivel: {dados.quantidadeProduto} , Valor R$ {dados.ValorProduto}";
                CmbProdutos.Items.Add(dadoComposto);
            }

        }

        private void FrmFazerCompra_Click(object sender, EventArgs e)
        {

        }

      
        
        private void BtnComprar_Click(object sender, EventArgs e)
        {
            var svc = new SvcCliente();
            
            var indice = CmbProdutos.SelectedIndex;
            string capturaTextoDeIndice = CmbProdutos.Items[indice].ToString();
            string[] subs = capturaTextoDeIndice.Split(' ');
            string nomeDoProduto = subs[6];
            string quantidadeProduto = subs[10];
            decimal valor = Convert.ToDecimal(subs[14]);
            svc.getNomeCliente(Cpf);

            decimal valorTotal = Convert.ToInt32(TxtQuantidade.Text) * valor ;
            if (svc.realizaCompra(nomeDoProduto, quantidadeProduto, valorTotal))
            {
                MessageBox.Show("Compra feita com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                 MessageBox.Show("Erro ao efetuar compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


                //string vjson = Login.fazGetLoginCli(Cpf);
                //var listaCompras = new ListaCompras();
                //listaCompras.listaDeCompras = ListaCompras.DesSerializedClassUnit(vjson);
                //var requisicao = new RequisicaoPost();
                //var enviaNome = new FrmVisualizarCompras();
                //enviaNome.recebeCpf(Cpf);

                //foreach (var dado in listaCompras.listaDeCompras)
                //{
                //    requisicao.postCompra(dado.nomeCliente, nomeDoProduto, Convert.ToInt32(TxtQuantidade.Text), Convert.ToDecimal(valorTotal));

                //}
                //if(requisicao.status == true)
                //{
                //    MessageBox.Show("Compra feita com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}*/



            }
        }
}
