using System;

namespace ApiExceptions
{
    public class InternalServerError : Exception
    {
        public InternalServerError()
            : base("An internal error occurred while processing the request.")
        { }
    }
}
