using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Salmon:Swimmers
    {
        public Salmon(string _Name, int _Age, bool _IsHealthy, int _Speed, bool _IsFish = true)
            : base(_Name, _Age, _IsHealthy, _Speed, _IsFish)
        {
            
        }
        public override string Swim()
        {
            return "I am a fish I am swimming!";
        }
        public override string SayWhoYouAre()
        {
            return "I am |" + this.Name + "I am |" + this.Age + "| years old! Am I healthy? |" + this.IsHealthy + "| !" +
            "My speed is |" + this.Speed + "|! Am I a fish? | " + this.IsFish; 
        }
        
    }
}
