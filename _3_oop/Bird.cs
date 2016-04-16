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
        public Bird(string _Name, int _Age, bool _IsHealthy, int  _WingsQuantity,bool _IsPredator, bool _IsBird = true ) : base(_Name, _Age, _IsHealthy, _WingsQuantity, _IsBird )
        {
            _IsPredator = IsPredator;
        }
        public override string Fly()
        {
            return "I am a bird I am flying!";
        }
        public override string SayWhoYouAre()
        {
            return "I am |" + this.Name + "I am |" + this.Age + "| years old! Am I healthy? |"+ this.IsHealthy+ "| !"+
            "I have |" + this.WingsQuantity + "| wings! Am I a bird? | " + this.IsBird + "| Am I predator? |"+this.IsPredator+"|"; 
        }
        
    }
}
