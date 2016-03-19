using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public abstract class Drug
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string State { get; set; }
        public bool RecieptFree { get; set; }
        public Drug()
        {

        }
        public Drug(string _Name,int _Cost,string _State,bool Receipt)
        {
            Name = _Name;
            Cost = _Cost;
            State = _State;
            RecieptFree = Receipt;
        }
        public virtual string SayWhoYouAre()
        {
            return "I am " + this.Name; 
        }
    }
}
