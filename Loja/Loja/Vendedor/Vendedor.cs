using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Utils.Vendedor
{
    public class Vendedor
    {
        private string nomeUsuaro = "root";
        private string senha = "root";
        public bool LoginVendedor(string nomeEscrito, string senhaEscrita)
        {
            if(nomeEscrito == nomeUsuaro & senha == senhaEscrita)
            {
                return true;
            }
            return false;
        }
    }
}
