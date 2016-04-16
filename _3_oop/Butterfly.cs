using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Butterfly:Flyers
    {        
        public int DayToLive {get;set;}
        public Butterfly(string _Name,int _Age, bool _IsHealthy,int  _WingsQuantity,int _DayToLive,bool _IsBird = false) : base(_Name, _Age, _IsHealthy, _WingsQuantity, _IsBird)
        {
            DayToLive = _DayToLive;
        }       
    }
}
