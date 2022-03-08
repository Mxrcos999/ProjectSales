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
      /*      var requisicao = new Login();
            string vjson = requisicao.fazGetLogin();
            var lista = new ListaDeClientes();
            lista.listaDeClientes = ListaDeClientes.DesSerializedClassUnit(vjson);

            foreach (var dados in lista.listaDeClientes)
            {
                string dadoComposto = $"Id do cliente: {dados.id}, Nome do cliente: {dados.nomeCliente}, Sobrenome do cliente: {dados.SobrenomeCliente}, Cpf: {dados.Cpf}";
                ListClientes.Items.Add(dadoComposto);

            }*/
        }

        private void PnlVerCliente_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
