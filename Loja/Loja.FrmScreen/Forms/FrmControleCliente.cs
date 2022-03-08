using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Loja.Forms
{
    public partial class FrmControleCliente : Form
    {
        public FrmControleCliente()
        {
            InitializeComponent();
        }

       

        private void BtnVendedor_Click(object sender, EventArgs e)
        {
            var form = new FrmLoginVendedor();
            this.Visible = false;
            form.Show();
            
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            var form = new CadastroCliente();
            this.Visible = false;
            form.Show();
        }
    }
}
