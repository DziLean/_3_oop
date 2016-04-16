using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Dolphin:Swimmers
    {
        public Dolphin(string _Name, int _Age, bool _IsHealthy, int _Speed, bool _IsFish = true)
            : base(_Name, _Age, _IsHealthy, _Speed, _IsFish)
        {
            
        }       
    }
}
