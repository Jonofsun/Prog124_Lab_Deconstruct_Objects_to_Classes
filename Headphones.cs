using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    public class Headphones
    {
        string _brand;
        string _styleOfHeadphones;
        string _modle;
        string _transmitionType;
        int _frequency;
        double _price;

        public Headphones(string brand, string styleOfHeadphones, string modle, string transmitionType, int frequency)
        {
            _brand = brand;
            _styleOfHeadphones = styleOfHeadphones;
            _modle = modle;
            _transmitionType = transmitionType;
            _frequency = frequency;
            _price = 350.99;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string StyleOfHeadphones { get => _styleOfHeadphones; set => _styleOfHeadphones = value; }
        public string Modle { get => _modle; set => _modle = value; }
        public string TransmitionType { get => _transmitionType; set => _transmitionType = value; }
        public int Frequency { get => _frequency; set => _frequency = value; }
        public double Price { get => _price;}
        public void BigSale(double price)
        {
            _price = price / 2;
        }
    }
}
