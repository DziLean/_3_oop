using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Swimmers:Animal
    {
        public bool IsFish{get;set;}
        public Swimmers(int _Age, bool _IsHealthy)
            : base( _Age, _IsHealthy)
        {

        }
        public override string Move()
        {
            return "I'm swimming yeah!";
        }
        public string SayIsFish()
        {
            if (IsFish)
            {
                return "Fish!";
            }
            else return "NotaFish!";
        }

    }
}
