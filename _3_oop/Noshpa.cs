using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Noshpa: Drug
    {
        public Noshpa()
            : base()
        {

        }
        public Noshpa(string _Name, int _Cost, int _State, bool Receipt)
            : base(_Name, _Cost, _State, Receipt)
        {

        }
    }
}
