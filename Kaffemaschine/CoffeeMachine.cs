using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        private Drink selectedDrink;
            

        /// <summary>
        /// was gerade ausgewählt ist.
        /// </summary>
        public Drink SelectedDrink
        {
           
            get => selectedDrink;

            set
            {
                selectedDrink = value;
                OnPropertyChanged("SelectedDrink");
            }
        }

    private decimal priceToPay;
        /// <summary>
        /// Was der Kunde zahlen muss
        /// </summary>
         

        

        public decimal PriceToPay {
            
            get => priceToPay;
            set
            {
                if(SelectedDrink == Drink.Kaba)
                {
                    priceToPay = 15;
                }
                
                //priceToPay = value;
                OnPropertyChanged("SelectedDrink");
            }
        }


        /// <summary>
        /// Geld was der Kunde eingeworfen hat.
        /// </summary>
        public decimal CustomerBalance { get; set; }



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
