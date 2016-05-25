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
        public Animal()
        {

        }
        public Animal(string _Name,int _Age)
        {
            Name = _Name;
            Age = _Age;
        }
    }
}
