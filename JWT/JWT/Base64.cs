using System;
using System.Text;
using ApiExceptions;

namespace JWT
{
    public class Base64
    {

        /*
         * Base64 Handling
         */

        public static string StringToBase64(string Input)
        {
            try
            {
                byte[] InputBytes = Encoding.UTF8.GetBytes(Input);
                return Convert.ToBase64String(InputBytes);
            }
            catch (Exception)
            {
                throw new InternalServerError();
            }

        }

        public static string Base64ToString(string EncodedInput)
        {
            try
            {
                byte[] EncodedInputBytes = Convert.FromBase64String(EncodedInput);
                return Encoding.UTF8.GetString(EncodedInputBytes);
            }
            catch (Exception)
            {
                throw new InternalServerError();
            }

        }
    }
}
