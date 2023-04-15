using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    public class Wristwatch
    {
        string _brand;
        string _styleOfWatch;
        string _typeOfMaterial;
        double _price;

        public Wristwatch(string brand, string styleOfWatch, string typeOfMaterial)
        {
            _brand = brand;
            _styleOfWatch = styleOfWatch;
            _typeOfMaterial = typeOfMaterial;
            _price = 1200.65;
        }

        public string Brand { get => _brand; set => _brand = value; }
        public string StyleOfWatch { get => _styleOfWatch; set => _styleOfWatch = value; }
        public string TypeOfMaterial { get => _typeOfMaterial; set => _typeOfMaterial = value; }
        public double Price { get => _price;}
        public void ChangeOfSale(double price)
        {
            _price = price;

        }
        
    } // Class
    
}
