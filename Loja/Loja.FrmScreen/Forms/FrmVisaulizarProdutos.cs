
using Loja.svc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Forms
{
    public partial class FrmVisaulizarProdutos : Form
    {
        public FrmVisaulizarProdutos()
        {
            InitializeComponent();
        }

        private void FrmVisaulizarVendas_Load(object sender, EventArgs e)
        {
            var svc = new SvcVendedor();
            foreach (var dados in SvcVendedor.carregaDadoProduto())
            {
                string dadoComposto = $" nome do produto: {dados.nomeProduto} ,quantidade de produtos: {dados.quantidadeProduto}, Valor produto: {dados.ValorProduto} ";
                ListProdutos.Items.Add(dadoComposto);
            }
    
        }
        

        private void produtosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();


        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void list_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
