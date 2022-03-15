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
        [Required(ErrorMessage = "O campo nome do produto é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo nome do produto deve conter no maximo 50 caracteres")]
        public string nomeProduto { get; set; }
        [Required(ErrorMessage = "O campo quantidade do produto é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo quantidade do produto deve conter no maximo 50 caracteres")]
        public string quantidadeProduto { get; set; }
        [Required(ErrorMessage = "O campo valor do produto é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo valor do produto deve conter no maximo 50 caracteres")]
        public string ValorProduto { get; set; }
        public Produto(string nome, string quantidade, string valor)
        {
            nomeProduto = nome;
            quantidadeProduto = quantidade;
            ValorProduto = valor;

            
        }
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
