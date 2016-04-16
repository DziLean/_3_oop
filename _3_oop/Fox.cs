using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Fox:WalkersCrawlers
    {
        public string WhatDoesTheFoxSay { get; set; }
        public int Speed { get; set; }
        public Fox(string _Name, int _Age,int _Speed,string _WhatDoesTheFoxSay, bool _IsHealthy, bool _IsWalker=true)
            : base(_Name, _Age, _IsHealthy, _IsWalker)
        {
            Speed = _Speed;
            WhatDoesTheFoxSay = _WhatDoesTheFoxSay;
        }         
    }
}
