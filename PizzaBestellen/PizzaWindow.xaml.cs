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

namespace PizzaBestellen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PizzaWindow : Window
    {
        public PizzaWindow()
        {
            InitializeComponent();
        }

        private void bestellen_Click(object sender, RoutedEventArgs e)
        {
            string hoeveelheid = "";
            string grootte = "";
            string toppings = "";

            foreach (FrameworkElement kind in RadioCheckPanel.Children)
            {
                if (kind is RadioButton r)
                {
                    if (r.IsChecked==true)
                    {
                        grootte = r.Name.ToString();
                    }
                }
                if (kind is CheckBox c)
                {
                    if (c.IsChecked==true && c.Name.ToString()!="tomaat" && c.Name.ToString()!="kaas")
                    {
                        toppings += c.Name.ToString() + " ";

                    }
                }
            }

            //U heeft 3 medium pizza('s) besteld met: tomaat, kaas en ananas overstrooid met kaas.
            opsomming.Content = "U heeft " + grootte + toppings;
        }
    }
}
