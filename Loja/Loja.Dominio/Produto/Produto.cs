using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.requisições
{
    public class Produto
    {
        public int id { get; set; }
        public string nomeProduto { get; set; }

        public string quantidadeProduto { get; set; }

        public string ValorProduto { get; set; }

        public class ListaDeProdutos
        {
            public static List<Produto> produtos = new List<Produto>();

            public static List<Produto> DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<List<Produto>>(vJson);
            }
        }
       

    }
   
}
