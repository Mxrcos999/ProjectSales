using Loja.svc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja.Forms
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                SvcCliente.registraCliente(TxtNome.Text, TxtSobrenome.Text, TxtCpf.Text);

            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            /*var EnviaRequisicao = new RequisicaoPost();
            EnviaRequisicao.postCliente(TxtNome.Text, TxtSobrenome.Text, TxtCpf.Text, TxtDateTime.Text);

            if (EnviaRequisicao.status == true)
            {
                MessageBox.Show("Cliente cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblButtonLogin_Click(object sender, EventArgs e)
        {
            var form = new FrmLoginCliente();
            this.Visible = false;
            form.Show();
        }

        private void LblVoltar_Click(object sender, EventArgs e)
        {
            var form = new FrmControleCliente();
            this.Visible = false;
            form.Show();
        }
    }
}
