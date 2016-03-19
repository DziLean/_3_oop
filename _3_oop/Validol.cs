using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Validol:Drug
    {
        public Validol()
            : base()
        {

        }
        public Validol(string _Name, int _Cost, string _State, bool Receipt)
            : base(_Name, _Cost, _State, Receipt)
        {

        }
    }
}
