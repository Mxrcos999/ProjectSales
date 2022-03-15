using Loja.ValuesObjects;
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
        public int id { get; set; }
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo nome deve conter no maximo 50 caracteres")]
        public string nomeCliente { get; set; }
        [Required(ErrorMessage = "O campo sobrenome é obrigatório.")]
        [StringLength(50, ErrorMessage = "o campo nome deve conter no maximo 50 caracteres")]
        public string SobrenomeCliente { get; set; }
        [Required(ErrorMessage = "O campo Cpf é obrigatório.")]

        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; set; }
        public Clientes(string nomeCliente, string sobrenomeCliente, string cpf, string dataNascimento)
        {
            this.nomeCliente = nomeCliente.Trim();
            SobrenomeCliente = sobrenomeCliente.Trim();
            DataNascimento = Convert.ToDateTime(dataNascimento);
        
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

            if (!_Cpf.Valida(cpf))
            {
                throw new ArgumentException("Insira um cpf valido");
            }

        }
        public class ListaDeClientes
        {
            public static List<Clientes> listaDeClientes { get; set; }

            public static List<Clientes> DesSerializedClassUnit(string vJson)
            {
                return JsonConvert.DeserializeObject<List<Clientes>>(vJson);
            }
        }
    }
}
