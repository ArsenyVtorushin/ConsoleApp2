using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cat
    {
        private string _name;
        private double _weight;
        private bool _sex;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value != null) _name = value;
                else _name = "Cat"; 
            }
        }
        /*public string Color { get; set; }
        public Cat() { }
        public Cat(string name) 
            : this(name, 0, true) { }
        public Cat(string name, double weight)
            : this(name, weight, true) { }*/
       /* public Cat(string name, double weight, bool sex)
            : this(name, weight, sex) { }*/
    }
}
