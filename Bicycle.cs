using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    public class Bicycle
    {
        string _make;
        string _modle;
        int _tires;
        int _year;
        double _price;

        public Bicycle(string make, string modle, int tires, int year)
        {
            _make = make;
            _modle = modle;
            _tires = tires;
            _year = year;
            _price = 199.99;
        }

        public string Make { get => _make; set => _make = value; }
        public string Modle { get => _modle; set => _modle = value; }
        public int Tires { get => _tires; set => _tires = value; }
        public int Year { get => _year; set => _year = value; }
        public double Price { get => _price; }
    }
}
