using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mercadopago;
using System.Net;
using System.IO;
using System.Configuration;

namespace stmpago
{
    class Program
    {
        static readonly string _CLIENT_ID = ConfigurationSettings.AppSettings["CLIENT_ID"].ToString();
        static readonly string _CLIENT_SECRET = ConfigurationSettings.AppSettings["CLIENT_SECRET"].ToString();

        static void Main(string[] args)
        {
            Console.WriteLine("Status de pagamento - MercadoPago");
            Console.WriteLine("");

            MP mp = new MP(_CLIENT_ID, _CLIENT_SECRET);
            mp.sandboxMode(true);
            string _access_token = mp.getAccessToken();

            Console.WriteLine("Access Token: {0}", _access_token);

            string _url = "https://api.mercadolibre.com/sandbox/collections/<order_number>?access_token=" + _access_token;

            WebRequest req = WebRequest.Create(_url);

            WebResponse resp = req.GetResponse();
            Stream _stream = resp.GetResponseStream();
            string _json = string.Empty;
            using (StreamReader sr = new StreamReader(_stream))
            {
                _json = sr.ReadToEnd();
            }

            Console.WriteLine(_json);
            Console.ReadLine();
        }
    }
}

