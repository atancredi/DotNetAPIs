using Newtonsoft.Json;
using ApiExceptions;
using System;

namespace JWT
{
    public class Validator
    {

        /*
         * Decode and Validate a JSON Web Token
         */

        public static void ValidateToken(string Token) {

            ProgramConfig CFG = new ProgramConfig();

            string[] TokenParts = Token.Split('.');

            if (!(HMAC.GetHash(TokenParts[0] + "." + TokenParts[1], CFG.SecretKey) == TokenParts[2]))
                throw new Unauthorized();

        }

        public static Token<T> DecodeTokenData<T>(string Token)
        {
            try
            {

                string[] TokenParts = Token.Split('.');
                Header header = DecodeTokenBody<Header>(TokenParts[0]);
                Payload<T> payload = DecodeTokenBody<Payload<T>>(TokenParts[1]);
                return new Token<T>
                {
                    header = header,
                    payload = payload
                };
            }
            catch (Exception)
            {
                throw new InternalServerError();
            }
        }

        /*
         * Auxiliary functions
         */

        private static T DecodeTokenBody<T>(string EncodedTokenBody)
        {
            return JsonConvert.DeserializeObject<T>(Base64.Base64ToString(EncodedTokenBody));
        }

    }
}
