using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Bird: Flyers
    {
        public bool IsPredator {get;set;}
        public Bird(string _Name, int _Age, bool _CanFly, int _WingsQuantity, bool _IsPredator, bool _IsBird = true)
            : base(_Name, _Age, _CanFly, _WingsQuantity, _IsBird)
        {
            _IsPredator = IsPredator;
        }       
    }
}
