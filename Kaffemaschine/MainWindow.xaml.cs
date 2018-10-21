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
            machine.GetPrice(CoffeeMachine.Drink.Kaffe);

        }

        private void btnKaba_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Kaba;
            machine.GetPrice(CoffeeMachine.Drink.Kaba);

        }

        private void btnNotBeer_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.NotBeer;
            machine.GetPrice(CoffeeMachine.Drink.NotBeer);
        }

        private void btnWasser_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Wasser;
            machine.GetPrice(CoffeeMachine.Drink.Wasser);
        }

        private void btnMilch_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = CoffeeMachine.Drink.Milch;
            machine.GetPrice(CoffeeMachine.Drink.Milch);
        }

        private void twoEuro_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(2);
            machine.CustomerBalance =  machine.GetCustomerBalance();
        }

        private void oneEuro_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(1);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void fiftyCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.5);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void twentyCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.2);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }


        private void tenCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.1);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void fiveCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.05);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void twoCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.02);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void oneCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.01);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void returnMoney_Click(object sender, RoutedEventArgs e)
        {
            machine.ReturnMoney();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
