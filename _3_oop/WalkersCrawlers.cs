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
        public override string Move()
        {
            return "I'm walking yeah!";
        }
        public string SayIsWalker()
        {
            if (IsWalker)
            {
                return "Walker!";
            }
            else return "NotaWalker!";
        }
        public virtual string Walk()
        {
            return "I cannot I do not know how to!";
        }
    }
}
