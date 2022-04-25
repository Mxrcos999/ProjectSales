using System.ComponentModel.DataAnnotations;


namespace models
{
    public class Clientes
    {
        [Key]
        [Required]
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string sobrenomeCliente { get; set; }
        public string Cpf { get; set; }
        public string dataNascimento { get; set; }
        public virtual Produtos Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}
