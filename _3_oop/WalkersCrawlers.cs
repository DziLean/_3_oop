using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class WalkersCrawlers:Animal
    {
        public bool IsWalker { get; set; }
        public WalkersCrawlers(string _Name,int _Age, bool _IsHealthy,bool _IsWalker)
            : base(_Name, _Age, _IsHealthy)
        {
            IsWalker = _IsWalker;
        }
    }
}
