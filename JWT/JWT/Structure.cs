using System;

namespace JWT
{
    public class Header
    {
        private TokenConfig CFG = new TokenConfig();
        public string alg
        {
            get
            {
                return CFG.DefaultAlgorithm;
            }
            set
            {
                CFG.DefaultAlgorithm = value;
            }
        }
        public string typ { get; set; } = "JWT";
    }

    public class Payload<T>
    {
        private TokenConfig CFG = new TokenConfig();
        public T Data { get; set; }
        private DateTime _exp {
            get {
                return DateTime.Now.Add(CFG.TokenLifespan);
            }
            set { }
        }
        public string exp {
            get
            {
                return _exp.ToString();
            }

            set
            {
                //_exp = DateTime.Parse(value);
            }
        
        }
    }

    public class Token<T>
    {
        public Header header { get; set; }
        public Payload<T> payload { get; set; }
        //public string secret { get; set; } = String.Empty;
    }

}
