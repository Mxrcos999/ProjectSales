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
    public partial class FrmLoginCliente : Form
    {
        public FrmLoginCliente()
        {
            InitializeComponent();
        }
        private void BtnLoginCliente_Click(object sender, EventArgs e)
        {
            var svc = new SvcCliente();
            if (svc.getJson(TxtCpf.Text))
            {
                MessageBox.Show("Login feito com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form = new FrmClienteDashbord();
                form.recebeCpf(TxtCpf.Text);
                this.Visible = false;
                form.Show();
            }else
                MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            /*        var login = new Login();
                    //  login.fazGetLogin();
                    if (login.loginCliente(TxtCpf.Text))
                    {
                        MessageBox.Show("Login feito com sucesso", "Sucesso", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        var form = new FrmClienteDashbord();
                        form.recebeCpf(TxtCpf.Text);
                        this.Visible = false;
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/
        }

        private void LblVoltar_Click(object sender, EventArgs e)
        {
            var form = new FrmControleCliente();
            this.Visible = false;
            form.Show();
        }
    }
}
