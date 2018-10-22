using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace Kaffemaschine
{
    public class CoffeeMachine : INotifyPropertyChanged
    {

        public enum Drink
        {
            None,
            Kaffe,
            Kaba,
            NotBeer,
            Wasser,
            Milch
        };


        public CoffeeMachine() //constructor (erstellt die Klasse)
        {

        }


        /// <summary>
        /// Returns Costumer Balance + inserted Money
        /// </summary>
        public decimal  GetCustomerBalance()
        {
            decimal balance = _customerBalance + _moneyInserted;
            if (balance <= 4)
            {
                return balance;
            }
            else
            {
                MessageBox.Show("You won't need more than 4€");
                return _customerBalance;
            }
        }


        /// <summary>
        /// returns all the money inserted
        /// </summary>
        public decimal ReturnMoney()
        {
            return CustomerBalance = 0;
        }

        public decimal ChangeToBeReturned()
        {
            return MoneyToBeReturned = _customerBalance - _priceToPay;
        }



        /// <summary>
        /// How much change will be returned and which coints 
        /// like 
        /// </summary>
        /// <returns></returns>
        public string GiveChange()
        {
            decimal moneyToBeReturned = _customerBalance - _priceToPay;

            decimal twoEuro = 0;
            decimal oneEuro = 0;
            decimal fiftycent = 0;
            decimal twentyCent = 0;
            decimal tenCent = 0;
            decimal fiveCent = 0;
            decimal twoCent = 0;
            decimal oneCent = 0;

            while (moneyToBeReturned > 0)
            {


                if (moneyToBeReturned >= 2)
                {
                    moneyToBeReturned -= 2;
                    twoEuro += 1;
                   // GiveChange();
                }
                else if(moneyToBeReturned >= 1)
                {
                    moneyToBeReturned -= 1;
                    oneEuro += 1;
                  //  GiveChange();
                }
                else if (moneyToBeReturned >= 0.5m)
                {
                    moneyToBeReturned -= 0.5m;
                    fiftycent += 1;
                 //   GiveChange();
                }
                else if (moneyToBeReturned >= 0.2m)
                {
                    moneyToBeReturned -= 0.2m;
                    twentyCent += 1;
                 //   GiveChange();
                }
                else if (moneyToBeReturned >= 0.1m)
                {
                    moneyToBeReturned -= 0.1m;
                    tenCent += 1;
                 //   GiveChange();
                }
                else if (moneyToBeReturned >= 0.05m)
                {
                    moneyToBeReturned -= 0.05m;
                    fiveCent += 1;
                //    GiveChange();
                }
                else if (moneyToBeReturned >= 0.02m)
                {
                    moneyToBeReturned -= 0.02m;
                    twoCent += 1;
                 //   GiveChange();
                }
                else if (moneyToBeReturned >= 0.01m)
                {
                    moneyToBeReturned -= 0.01m;
                    oneCent += 1;
                //    GiveChange();
                }

            } 


            string yourCoints = String.Format(@"You have,
                {0} x 2€,
                {1} x 1€,
                {2} x 0.5,
                {3} x 0.2,
                {4} x 0.1,
                {5} x 0.05,
                {6} x 0.02,
                {7} x 0.01",
               twoEuro,
               oneEuro,
               fiftycent,
               twentyCent,
               tenCent,
               fiveCent,
               twoCent,
               oneCent

           );

            CustomerBalance = 0;
            PriceToPay = 0;
            return CointsToBeReturned = yourCoints;
        }

        /// <summary>
        /// Show or not to show the cup
        ///Wenn you buy a Coffe, a cup will be show
        /// </summary>
        public void  ShowTheCup(bool showOrNot)
        {
            ShowCup = showOrNot;
        }

        private bool _showCup = false;

        public bool ShowCup
        {
            get => _showCup;

            set
            {
                _showCup= value;
                OnPropertyChanged("ShowCup");
            }
        }

        private decimal _moneyToBeReturned;

        public decimal MoneyToBeReturned
        {
            get => _moneyToBeReturned;
            set
            {
                _moneyToBeReturned = _customerBalance - _priceToPay;
                OnPropertyChanged("MoneyToBeReturned");
            }
        }

        private string _CointsToBeReturned;

        public string CointsToBeReturned
        {
            get => _CointsToBeReturned;
            set
            {
                _CointsToBeReturned = value;
                OnPropertyChanged("CointsToBeReturned");
            }
        }


        private decimal _moneyInserted;

        public decimal MoneyInserted(decimal coint)
        {
            _moneyInserted = coint;
            return _moneyInserted;
        }


        private string _selectedDrink = "Select A Drink";
        /// <summary>
        /// was gerade ausgewählt ist.
        /// </summary>
        public string SelectedDrink
        {
           
            get =>  _selectedDrink ;

            set
            {
                _selectedDrink = value;
                OnPropertyChanged("SelectedDrink");
            }
        }


        /// <summary>
        /// Returns The Price of a selectet drink
        /// </summary>
        public decimal  GetPrice(Drink drink)
        {
            switch (drink)
            {
                case Drink.Kaffe:
                    return  PriceToPay = 0.5m;
                case Drink.Kaba:
                    return PriceToPay = 2m;
                case Drink.NotBeer:
                    return PriceToPay = 3m;
                case Drink.Wasser:
                    return PriceToPay = 1.33m;
                case Drink.Milch:
                    return PriceToPay = 0.99m;

                default:
                    return 0;
            }
        }


        private decimal _priceToPay;
        /// <summary>
        /// Was der Kunde zahlen muss
        /// </summary>
        public decimal PriceToPay {
            get => _priceToPay;
            set
            {
                _priceToPay = value;
                ChangeToBeReturned();
                OnPropertyChanged("PriceToPay");
            }
        }

        private decimal _customerBalance;
        /// <summary>
        /// Geld was der Kunde eingeworfen hat.
        /// </summary>
        public decimal CustomerBalance
        {
            get => _customerBalance;

            set
            {
                _customerBalance = value;
                ChangeToBeReturned();
                OnPropertyChanged("CustomerBalance");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

    }


}
