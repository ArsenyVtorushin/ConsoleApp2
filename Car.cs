using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public struct Car
    {
        public string _vin;
        public string _brand;
        public string _name;
        public int _year;
        public string _color;
        public Car(string vin,  string brand, string name, int year, string color)
        {
            _vin = vin;
            _brand = brand;
            _name = name;
            _year = year;
            _color = color;
        }
        public string Info
        {
            get { return $"vin: {_vin}\nbrand: {_brand}\nname: {_name}\nyear: {_year}\ncolor: {_color}"; }
        }
        public bool VinCompare( string vin )
        {
            return _vin == vin;
        }
    }
}
