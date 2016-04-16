using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Swimmers : Animal
    {
        public bool IsFish{ get; set; }
        public int Speed { get; set; }
        public Swimmers(string _Name, int _Age, bool _IsHealthy, int _Speed, bool _IsFish)
            : base(_Name,_Age, _IsHealthy)
        {            
            Name = _Name;
            IsFish = _IsFish;
            Speed = _Speed;
        }
    }
}
