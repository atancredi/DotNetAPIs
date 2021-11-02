using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWT
{
    //Configuration for the JWT class
    public class TokenConfig
    {

        //Default lifespan of a JWT
        public TimeSpan TokenLifespan = new TimeSpan(0, 4, 0, 0);

        //Default Encryption Algorithm
        public string DefaultAlgorithm = "HS256";

    }

    public class ProgramConfig
    {
        //SECRET KEY for HS256 Algorithm
        //note on that: is it recommended that the secret key is a 128bit key generated with a cryptographically secure pseudo random number generator (or CSPRNG)
        //a 128 bit key as a string is represented by a 32 characters long hex string or 16 random bytes run through a base64 encode function.
        public readonly string SecretKey = "This is a TEST Secret Key";
    }

}
