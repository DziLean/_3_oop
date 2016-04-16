using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Frog:WalkersCrawlers
    {
        public string WhatDoesTheFrogSay { get; set; }
        public string Areal { get; set; }
        public Frog(string _Name, int _Age, string _Areal, string _WhatDoesTheFrogSay, bool _IsHealthy, bool _IsWalker = false)
            : base(_Name, _Age, _IsHealthy, _IsWalker)
        {
            Areal = _Areal;
            WhatDoesTheFrogSay = _WhatDoesTheFrogSay;
        }
    }
}
