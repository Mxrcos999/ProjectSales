using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Cliente
{
    public class Clientes
    {
        //  public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo nome deve conter no maximo 50 caracteres")]
        public string nomeCliente { get; set; }
        [Required(ErrorMessage = "O campo sobrenome é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo nome deve conter no maximo 50 caracteres")]
        public string SobrenomeCliente { get; set; }
        public Cpf Cpf { get; set; }

        public Clientes(string nome, string sobrenome, string cpf)
        {
            nomeCliente = nome;
            SobrenomeCliente = sobrenome;
            Cpf = cpf;
          
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            


        }
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
