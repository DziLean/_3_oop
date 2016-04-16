using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Fox:WalkersCrawlers
    {
        public string WhatDoesTheFoxSay { get; set; }
        public int Speed { get; set; }
        public Fox(string _Name, int _Age,int _Speed,string _WhatDoesTheFoxSay, bool _IsHealthy, bool _IsWalker=true)
            : base(_Name, _Age, _IsHealthy, _IsWalker)
        {
            Speed = _Speed;
            WhatDoesTheFoxSay = _WhatDoesTheFoxSay;
        }

        public override string Walk()
        {
            return "I am a foxy I am running!";
        }
        public override string SayWhoYouAre()
        {
            return "I am |" + this.Name + "| I am |" + this.Age + "| years old! Am I healthy? |" + this.IsHealthy + "| !" +
            "I run at|" + this.Speed + "| km/h! Am I a walker? | " + this.IsWalker + "| ! What does the fox say? +" + WhatDoesTheFoxSay + " |";
        }       
    }
}
