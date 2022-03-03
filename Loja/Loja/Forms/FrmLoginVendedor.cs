using Loja.Utils.Vendedor;
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
    public partial class FrmLoginVendedor : Form
    {
        public FrmLoginVendedor()
        {
            InitializeComponent();
        }

        private void BtnLoginVendedor_Click(object sender, EventArgs e)
        {
            var vendedor = new Vendedor();
            if(vendedor.LoginVendedor(TxtNome.Text, TxtSenha.Text))
            {
                MessageBox.Show("Login feito com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new FrmVendedorDashBord();
                this.Visible = false;
                form.Show();

            }
            else
            {
                MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LblVoltar_Click(object sender, EventArgs e)
        {
            var form = new FrmControleCliente();
            this.Visible = false;
            form.Show();
        }
    }
}
