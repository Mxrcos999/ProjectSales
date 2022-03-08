using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Requisições
{
    public class requisicaoGet
    {
        public string fazGet(string rota)
        {

            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://localhost:5001/{rota}/");

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

        public string fazGetEspecifico(string rota, string rotaComplementar)
        {

            System.Net.HttpWebRequest requisicao = (HttpWebRequest)WebRequest.Create($"https://localhost:5001/{rota}/{rotaComplementar}");

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
