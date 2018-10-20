using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


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


        public void BerrechneWas()
        {

        }



        private Drink _selectedDrink;
            

        /// <summary>
        /// was gerade ausgewählt ist.
        /// </summary>
        public Drink SelectedDrink
        {
           
            get =>  _selectedDrink ;

            set
            {
                _selectedDrink = value;
                OnPropertyChanged("SelectedDrink");
            }
        }

        public double KaffePrice = 2;
        public double bata  { get; set; }


        public double  getPrice(Drink drink)
        {
            switch (drink)
            {
                case Drink.Kaffe:
                    return PriceToPay = 0.5;
                case Drink.Kaba:
                    return PriceToPay = 2;
                case Drink.NotBeer:
                    return PriceToPay = 3;
                case Drink.Wasser:
                    return PriceToPay = 1.33;
                case Drink.Milch:
                    return PriceToPay = 0.99;

                default:
                    return 0;
            }
        }




        private double _priceToPay;
        /// <summary>
        /// Was der Kunde zahlen muss
        /// </summary>
        public double PriceToPay {

            get => _priceToPay;
            set
            {
                _priceToPay = value;
                OnPropertyChanged("PriceToPay");
            }
        }


        /// <summary>
        /// Geld was der Kunde eingeworfen hat.
        /// </summary>
        public decimal CustomerBalance { get ; set; }



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
