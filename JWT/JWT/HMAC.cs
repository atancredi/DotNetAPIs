using System;
using System.Security.Cryptography;
using System.Text;
using ApiExceptions;

namespace JWT
{
    public class HMAC
    {
        public static String GetHash(String text, String key)
        {
            try
            {
                // an UTF8Encoding could be more suitable in certain situations
                ASCIIEncoding encoding = new ASCIIEncoding();

                Byte[] textBytes = encoding.GetBytes(text);
                Byte[] keyBytes = encoding.GetBytes(key);

                Byte[] hashBytes;

                using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                    hashBytes = hash.ComputeHash(textBytes);

                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
            catch (Exception)
            {
                throw new InternalServerError();
            }

        }
    }
}
