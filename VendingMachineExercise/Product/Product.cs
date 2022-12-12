using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachineExercise
{
    public abstract class ProductItem : IProduct     // Abstract klass för Products med ett interface Iproduct och tre abstracta metoder som produktklasserna overridar samt en virtual metod som returnerar det individuella pris som sätts i varje produkts egna konstruktor.
    {

        public int Price { get; set; }      // Variabel för att kunna sätta individuella pris i varje produkt
        public categories Category { get; set; }    // Enum för att kunna sätta vilken kategori varje produkt tillhör

        public enum categories
        {
            Liquids,
            Meals,
            RoughWeatherItems

        }
        public ProductItem()
        {
            
        }

        public virtual double getCost()
        {
            return Price;
        }


        public abstract string getDescription();


        public abstract string getName();

        public abstract void useProduct();
        
    }
}

