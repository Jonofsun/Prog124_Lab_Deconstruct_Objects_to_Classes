using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    public class WaterBottle
    {
        string _brand;
        string _type;
        double _capacity;
        double _price;

        public WaterBottle(string brand, string type, double capacity)
        {
            _brand = brand;
            _type = type;
            _capacity = capacity;
            _price = 35.99;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public double Capacity { get => _capacity; set => _capacity = value; }
        public double Price { get => _price;}
    }
}
