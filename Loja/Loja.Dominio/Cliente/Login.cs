using Loja.Requisições;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Loja.requisições
{
    public class Login
    {
        public string nomeCliente { get; set; }
        public string cpf { get; set; }
        public string status { get; set; }
        public static List<Login> DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<List<Login>>(vJson);
        }
        public bool loginCliente(string cpfEscrito)
        {
            var requisicao = new requisicaoGet();
            string vjson = requisicao.fazGetEspecifico("cliente", cpfEscrito);
            if (vjson == "[]")
            {
                return false;

            }
            return true;

        }

        public bool ValidateClasse()
        {
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
            return true;
        }




    }
}
