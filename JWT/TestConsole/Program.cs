using System;
using JWT;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create the Payload
            Payload<int> PayLoad = new Payload<int>
            {
                Data = 3
            };

            string token = Issuer.IssueToken(PayLoad);
            
            Console.WriteLine(JsonConvert.DeserializeObject(Testate.Main(token)));

            Console.ReadLine();

        }

    }


    public static class Testate
    {
        public static string Main(string token)
        {
            var wb = new WebClient();
            var data = new NameValueCollection();
            string url = "https://www.ow48.rassegnestampa.it/testateapi/api/filedata";
            data["Path"] = @"E:\ftproot\testatesl\Bancaditalia";
            data["Token"] = token;

            var response = wb.UploadValues(url, "POST", data);
            return wb.Encoding.GetString(response);
        }
    }

}
