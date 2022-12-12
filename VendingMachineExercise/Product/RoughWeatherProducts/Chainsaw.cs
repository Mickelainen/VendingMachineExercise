using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Product.RoughWeatherProducts
{
    internal class Chainsaw : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public Chainsaw() 
        {
            Category = categories.RoughWeatherItems;
            Price = 100;
        }   
        public override string getDescription()
        {
            return "The chain contains cutting teeth that are capable of slicing through wood. A chainsaw can be used to fell and process trees.";
        }

        public override string getName()
        {
            return "Chainsaw";
        }

        public override void useProduct()
        {
            Console.WriteLine("Vrroooom Vroooooom!");
        }
    }
}
