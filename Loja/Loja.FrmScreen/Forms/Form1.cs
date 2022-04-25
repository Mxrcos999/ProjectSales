using Loja.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmVendedorDashBord : Form
    {
        public FrmVendedorDashBord()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.pnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmCadastrarProduto { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void BtnVisualizarVenda_Click(object sender, EventArgs e)
        {
            this.pnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmVisaulizarProdutos { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void BtnCadastrarVenda_Click(object sender, EventArgs e)
        {
            this.pnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmRealizaVenda { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmVerVendas { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void BtnVerClientes_Click(object sender, EventArgs e)
        {
            this.pnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmVisualizarClientes { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void LblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            var form = new FrmControleCliente();
            this.Visible = false;
            form.Show();
        }

        private void pnlLoad_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
