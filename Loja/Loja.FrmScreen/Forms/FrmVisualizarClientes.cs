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
    public partial class FrmVisualizarClientes : Form
    {
        public FrmVisualizarClientes()
        {
            InitializeComponent();
        }

        private void FrmVisualizarClientes_Load(object sender, EventArgs e)
        {
            var svc = new SvcVendedor();
            foreach (var dados in SvcVendedor.carregaDadosCliente())
            {
                string dadoComposto = $"Nome do cliente: {dados.nomeCliente}, Sobrenome do cliente: {dados.SobrenomeCliente}, Cpf: {dados.Cpf}, Data de nascimento: {dados.DataNascimento.ToString(":d/M/yyyy")}";
                ListClientes.Items.Add(dadoComposto);
            }
            
        }

        private void PnlVerCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
