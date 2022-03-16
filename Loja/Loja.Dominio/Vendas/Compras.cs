using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Vendas
{
    public class Compras
    {
        public int id { get; set; }

        public string nomeCliente { get; set; }
        public string nomeProduto { get; set; }
        public int quantidadeComprada { get; set; }
        public decimal ValorTotal { get; set; }

        public class ListaCompras
        {
            public static List<Compras> listaDeCompras { get; set; }

            public static List<Compras> DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<List<Compras>>(vJson);
            }
        }
        
    }
}
