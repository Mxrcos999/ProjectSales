using Loja.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.svc
{
    public class SvcCliente
    {
        public static void registraCliente(string nome, string sobrenome, string cpf)
        {
            var cliente = new Clientes(nome, sobrenome, cpf);
        }
    }
}
