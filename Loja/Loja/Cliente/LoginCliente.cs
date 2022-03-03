using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            string vjson = fazGetLoginCli(cpfEscrito);
            if(vjson == "[]")
            {
                return false;

            }
            return true;

        }

        public string fazGetLogin()
        {

            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://localhost:5001/cliente/");

            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();


            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();
        }

        public static string fazGetLoginCli(string cpf)
        {

            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://localhost:5001/cliente/{cpf}");

            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();


            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();
        }


        public string fazGetLoginNome(string nomeDigitado)
        {

            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://localhost:5001/cliente/{nomeDigitado}");

            HttpWebResponse resposta = (HttpWebResponse)requisicao.GetResponse();


            int cont;
            byte[] buffer = new byte[1000];
            StringBuilder sb = new StringBuilder();
            string temp;
            Stream stream = resposta.GetResponseStream();
            do
            {
                cont = stream.Read(buffer, 0, buffer.Length);
                temp = Encoding.Default.GetString(buffer, 0, cont).Trim();
                sb.Append(temp);

            } while (cont > 0);
            return sb.ToString();
        }
    }
}
