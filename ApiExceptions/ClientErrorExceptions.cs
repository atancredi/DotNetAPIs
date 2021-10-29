using System;

namespace ApiExceptions
{
    public class BadRequest : Exception
    {
        public BadRequest()
            : base("The server cannot or will not process the request due to an apparent client error.")
        {

        }
    }

    public class Unauthorized : Exception
    {
        public Unauthorized()
            : base("Authentication failed")
        {

        }
    }
}
