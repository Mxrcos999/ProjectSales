using Loja.requisições;
using Loja.svc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            try
            {
                SvcVendedor.InsereProduto(TxtNomeProduto.Text, TxtValorDoProduto.Text, TxtQuantidadeProduto.Text);
                if (RequisicaoPost.status)
                {
                    MessageBox.Show("Novo produto adicionado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    MessageBox.Show("Erro ao cadastradar novo produto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch(ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void FrmCadastrarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
