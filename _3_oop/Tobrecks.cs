using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Tobrecks:Drug
    {
        public Tobrecks()
            : base()
        {

        }
        public Tobrecks(string _Name, int _Cost, string _State, bool Receipt)
            : base(_Name, _Cost, _State, Receipt)
        {

        }
    }
}
