using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Forms
{
    public partial class FrmCadastrarProduto : Form
    {
        public FrmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastra_Click(object sender, EventArgs e)
        {
           /* try
            {
                var enviaRequisicao = new RequisicaoPost();
                enviaRequisicao.postProduto(TxtNomeProduto.Text, Convert.ToInt32(TxtQuantidadeProduto.Text), Convert.ToDecimal(TxtValorDoProduto.Text));
                if (enviaRequisicao.status == true)
                {
                    MessageBox.Show("Produto criado com sucesso", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erro ao criar produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            

        }
   
    }
}
