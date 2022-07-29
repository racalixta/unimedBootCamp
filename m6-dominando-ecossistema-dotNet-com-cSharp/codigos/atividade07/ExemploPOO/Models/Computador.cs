using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Computador : System.Object
    {               //           ^^ isso é redundante
        public override string ToString()
        {
            return "\nsobescrevendo a classe ToStirng\n";
        }
    }
}