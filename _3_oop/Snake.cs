using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Snake:WalkersCrawlers
    {
        public string WhatDoesTheSnakeSay { get; set; }
        public string Areal { get; set; }
        public Snake(string _Name, int _Age, string _Areal, string _WhatDoesTheSnakeSay, bool _IsHealthy, bool _IsWalker = false)
            : base(_Name, _Age, _IsHealthy, _IsWalker)
        {
            Areal = _Areal;
            WhatDoesTheSnakeSay = _WhatDoesTheSnakeSay;
        }
    }
}
