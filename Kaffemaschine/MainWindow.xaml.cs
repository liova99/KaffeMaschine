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

namespace Kaffemaschine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            wMain.DataContext = machine;
        }

        CoffeeMachine machine = new CoffeeMachine();

        private void btnCoffe_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Kaffe;
        }

        private void btnKaba_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Kaba;
        }

        private void btnNotBeer_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.NotBeer;
        }

        private void btnWasser_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Wasser;
        }

        private void btnMilch_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Milch;
        }
    }
}
