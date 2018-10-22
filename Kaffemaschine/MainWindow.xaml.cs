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

            // wMain ist der X:Name unser xaml,
            // DataContext bindet xaml mit machine
            wMain.DataContext = machine;
        }

        CoffeeMachine machine = new CoffeeMachine();

        
        

        private void btnCoffe_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = nameof(CoffeeMachine.Drink.Kaffe);
            machine.GetPrice(CoffeeMachine.Drink.Kaffe);

        }

        private void btnKaba_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = nameof(CoffeeMachine.Drink.Kaba);
            machine.GetPrice(CoffeeMachine.Drink.Kaba);

        }

        private void btnNotBeer_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = "Not a Beer"; // enums durfen kein Space
            machine.GetPrice(CoffeeMachine.Drink.NotBeer);
        }

        private void btnWasser_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = nameof(CoffeeMachine.Drink.Wasser);
            machine.GetPrice(CoffeeMachine.Drink.Wasser);
        }

        private void btnMilch_Click(object sender, RoutedEventArgs e)
        {
            machine.SelectedDrink = nameof(CoffeeMachine.Drink.Milch);
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
            machine.MoneyInserted(0.5m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void twentyCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.2m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }


        private void tenCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.1m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void fiveCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.05m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void twoCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.02m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void oneCent_Click(object sender, RoutedEventArgs e)
        {
            machine.MoneyInserted(0.01m);
            machine.CustomerBalance = machine.GetCustomerBalance();
        }

        private void returnMoney_Click(object sender, RoutedEventArgs e)
        {
            machine.ReturnMoney();
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            if (machine.CustomerBalance >= machine.PriceToPay)
            {
                machine.ShowTheCup(true);
                MessageBox.Show("Wait for it");
                machine.GiveChange();
                System.Threading.Thread.Sleep(2000);
                machine.ShowTheCup(false);
                machine.SelectedDrink = "Select A Drink";
                MessageBox.Show(machine.CointsToBeReturned);

            }
            else
            {
                MessageBox.Show(String.Format("You need {0}€ more Dude! ", machine.PriceToPay - machine.CustomerBalance));

            }
        }
    }
}
