using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHealthy { get; set; }
        public Animal()
        {

        }
        public Animal(string _Name,int _Age, bool _IsHealthy)
        {
            Name = _Name;
            Age = _Age;
            IsHealthy = _IsHealthy;
        }
        public virtual string SayWhoYouAre()
        {
            return "I am " + this.Age + " years old! Am I healthy? "+ this.IsHealthy+ " !"; 
        }
        public virtual string Move()
        {
            return "Oops I am not a creature!";
        }
    }
}
