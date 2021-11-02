using Newtonsoft.Json;
using ApiExceptions;

namespace JWT
{
    public class Issuer
    {

        /* 
         *  Main function: issue the Token
         */

        public static string IssueToken(Payload<int> payload)
        {
            //Get config of the program
            ProgramConfig CFG = new ProgramConfig();

            //header: create, stringify, encode with base64
            string Header = EncodeTokenBody(new Header());

            //payload: create, stringify, encode with base64
            string Payload = EncodeTokenBody(payload);

            //creation of the secret key within the token
            string Secret = HMAC.GetHash(Header + "." + Payload, CFG.SecretKey);

            //append the elements that constitutes the token
            return Header + "." + Payload + "." + Secret;
        }


        /*
         * Auxiliary functions
         */

        private static string EncodeTokenBody<T>(T Object)
        {
            return Base64.StringToBase64(JsonConvert.SerializeObject(Object));
        }
    }
}
