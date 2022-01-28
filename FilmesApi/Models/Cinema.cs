using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "o campo logradouro é obrigatorio")]
        public string logradouro { get; set; }
        [Required(ErrorMessage = "o campo bairro é obrigatorio")]

        public string bairro { get; set; }
        [Required(ErrorMessage = "o campo numero é obrigatorio")]

        public int numero { get; set; }
    }
}
