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
    public partial class FrmClienteDashbord : Form
    {
        public string Cpf { get; set; }
        public FrmClienteDashbord()
        {
            InitializeComponent();
        }
        public void recebeCpf(string cpf)
        {
            Cpf = cpf;
        }

        private void FrmClienteDashbord_Load(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
            this.PnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmFazerCompra { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.recebeCpf(Cpf);
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PnlLoad.Controls.Clear();
            var frmProduto_vrb = new FrmVisualizarCompras { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmProduto_vrb.recebeCpf(Cpf);
            frmProduto_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlLoad.Controls.Add(frmProduto_vrb);
            frmProduto_vrb.Show();
        }

        private void BtnDeslogar_Click(object sender, EventArgs e)
        {
            var form = new FrmControleCliente();
            this.Visible = false;
            form.Show();
        }
    }
}
