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
        public override string Fly()
        {
            return "I am a butterfly I am fittering!";
        }
        public override string SayWhoYouAre()
        {
            return "I am |" + this.Name +"| I am |" + this.Age + "| years old! Am I healthy? |"+ this.IsHealthy+ "| !"+
            "I have |" + this.WingsQuantity + "| wings! Am I a bird? | " + this.IsBird + "| Days to live on this planet: |"+this.DayToLive+"|"; 
        }
        
    }
}
