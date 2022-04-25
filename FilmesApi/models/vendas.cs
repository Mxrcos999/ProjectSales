using System.ComponentModel.DataAnnotations;


namespace models
{
    public class Vendas
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string nomeProduto { get; set; }
        public int quantidadeComprada { get; set; }
        public decimal ValorTotal { get; set; }
        
    }
}
