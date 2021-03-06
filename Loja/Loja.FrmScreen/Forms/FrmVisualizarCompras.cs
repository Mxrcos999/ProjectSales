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
    public partial class FrmVisualizarCompras : Form
    {
        public FrmVisualizarCompras()
        {
            InitializeComponent();
        }
        public string Cpf { get; set; }
        public string nome { get; set; }
        public void recebeCpf(string cpf)
        {
            Cpf = cpf;
        }
        private void FrmVisualizarCompras_Load(object sender, EventArgs e)
        {
            SvcCliente svc = new SvcCliente();
            svc.getNomeCliente(Cpf);
            foreach (var dado in svc.ListaDeCompras())
            {
                string dadoComposto = $"nome: {dado.nomeCliente}, produto comprado: {dado.nomeProduto}, quantidade comprada: {dado.quantidadeComprada}, valor pago: R$ {dado.ValorTotal}";
                ListCompras.Items.Add(dadoComposto);
            }

            /*    var jsonNome = Login.fazGetLoginCli(Cpf);
                 List<Clientes> Getnome = new List<Clientes>();
                 Getnome = ListaDeClientes.DesSerializedClassUnit(jsonNome);

                 foreach(var nomeCliente in Getnome)
                 {
                     nome = nomeCliente.nomeCliente;
                 }
                 var vjson = requisicaoGet.fazGetNome(nome);
                 var listaa = new ListaCompras();

                 listaa.listaDeCompras = ListaCompras.DesSerializedClassUnit(vjson);

                 foreach(var dado in listaa.listaDeCompras)
                 {
                     string dadoComposto = $"nome: {dado.nomeCliente}, produto comprado: {dado.nomeProduto}, quantidade comprada: {dado.quantidadeComprada}, valor pago: R$ {dado.ValorTotal}";
                     ListCompras.Items.Add(dadoComposto);
                 }*/
        }
    }
}
