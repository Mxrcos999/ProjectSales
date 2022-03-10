using Loja.Cliente;
using Loja.requisições;
using Loja.Requisições;
using Loja.ValuesObjects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.svc
{
    public class SvcCliente
    {
        public static void registraCliente(string nome, string sobrenome, string cpf, string data)
        {

            cpf = cpf.Replace(",", "").Replace("-", "");
     
            var cliente = new Clientes(nome, sobrenome, cpf, data);
            new RequisicaoPost().postCliente(cliente);

 
        }
        public static bool getJson(string cpf)
        {
         
                var requisicao = new requisicaoGet();
                string vjson = requisicao.fazGetEspecifico("cliente", cpf);
                if (vjson == "[]")
                {
                    return false;
                }
                return true;
            

        }

    

    }
}
