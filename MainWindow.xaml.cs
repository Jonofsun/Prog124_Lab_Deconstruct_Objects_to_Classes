using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Prog124_Lab_Deconstruct_Objects_to_Classes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<WaterBottle> waterBottles = new List<WaterBottle>();
        static List<Wristwatch> wristwatches = new List<Wristwatch>();
        static List<Headphones> headphones = new List<Headphones>();
        static List<Bicycle> bicycles = new List<Bicycle>();
        static List<CoffeeMug> coffeeMugs = new List<CoffeeMug>();

        public MainWindow()
        {
            InitializeComponent();
            //Coffee mug
            //Bicycle
            //Headphones
            //Wristwatch
            //Water bottle
            WaterBottle wB = new WaterBottle("Aquaphor", "steel", 2.2);
            Wristwatch wW = new Wristwatch("Rolex", "Analog", "Gold");
            Headphones hP = new Headphones("Beyerdynamic", "Open Back", "DT 1990 Pro", "Cable", 42000);
            Bicycle b = new Bicycle("Honda", "E-Sport 7", 2, 2007);
            CoffeeMug cM = new CoffeeMug("Large Mug", "Racing Miku 2023", "");
            Preload();
        }
        public void DisplayStore()
        {
            try
            {
                foreach (WaterBottle waterBottle in waterBottles)
                {
                    LbDisplay.Items.Add(waterBottle);
                }
                foreach (Wristwatch wristwatch in wristwatches)
                {
                    LbDisplay.Items.Add(wristwatch);
                }
                foreach (Headphones headphones in headphones)
                {
                    LbDisplay.Items.Add(headphones);
                }
                foreach (Bicycle bicycle in bicycles)
                {
                    LbDisplay.Items.Add(bicycle);
                }
                foreach (CoffeeMug coffeeMugs in coffeeMugs)
                {
                    LbDisplay.Items.Add(coffeeMugs);
                }
            }
            catch
            {
                MessageBox.Show("Something went wrong there");
                for (int i = 0; i < waterBottles.Count; i++)
                {
                    LbDisplay.Items.Add(waterBottles[i].ToString());
                }
                for (int i = 0; i < wristwatches.Count; i++)
                {
                    LbDisplay.Items.Add(wristwatches[i].ToString());
                }
                for (int i = 0; i < headphones.Count; i++)
                {
                    LbDisplay.Items.Add(headphones[i].ToString());
                }
                for (int i = 0; i < bicycles.Count; i++)
                {
                    LbDisplay.Items.Add(bicycles[i].ToString());
                }
                for (int i = 0; i < coffeeMugs.Count; i++)
                {
                    LbDisplay.Items.Add(coffeeMugs[i].ToString());
                }
            }
        }
        private void Preload()
        {
            

            DisplayStore();
            LbDisplay.SelectedIndex = 0;
        }
        private void btnSelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                txtImgLocation.Text = ofd.FileName;
            }

        }
    }
}
