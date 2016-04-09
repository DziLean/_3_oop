using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Flyers:Animal
    {

        public bool IsFlyer { get; set; }
        public int WingsQuantity { get; set; }
        public Flyers(int _Age, bool _IsHealthy)
            : base( _Age, _IsHealthy)
        {

        }
        public override string Move()
        {
            return "I'm flying yeah!";
        }
        public string SayIsFlyer()
        {
            if (IsFlyer)
            {
                return "Flyer!";
            }
            else return "NotaFlyer!";
        }
        public virtual string Fly()
        {
            return "I cannot I am not existing";
        }
    }
}
