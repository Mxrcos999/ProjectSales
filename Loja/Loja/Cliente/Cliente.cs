using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Cliente
{
    public class Clientes
    {
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string SobrenomeCliente { get; set; }
        public string Cpf { get; set; }

        public class ListaDeClientes
        {
            public List<Clientes> listaDeClientes { get; set; }

            public static List<Clientes> DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<List<Clientes>>(vJson);
            }
        }
    }
}
