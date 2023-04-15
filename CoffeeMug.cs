using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    internal class CoffeeMug
    {
        string _style;
        string _brand;
        BitmapImage _art;
        double _price;

        public CoffeeMug(string style, string brand, string filepath)
        {
            _style = style;
            _brand = brand;
            _art = GenerateImage(filepath);
            _price = 19.96;
        }

        public string Style { get => _style; set => _style = value; }
        public string Brand { get => _brand; set => _brand = value; }
        public BitmapImage Art { get => _art; set => _art = value; }
        public double Price { get => _price; }

        private BitmapImage GenerateImage(string filePath)
        {
            try
            {
                Uri uri = new Uri(filePath);
                BitmapImage image = new BitmapImage();
                return image;
            }
            catch { return null; }
            
        }
    }
}
