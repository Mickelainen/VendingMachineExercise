using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    internal class Coffee : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {

        public Coffee() 
        {
            Category = categories.Liquids;
            Price = 5;
        }

        public override string getDescription()
        {
            return "Coffee is a liquid based on coffein";
        }
        public override string getName()
        {
            return "Coffee";
        }
        public override void useProduct()
        {
            Console.WriteLine("Thats a strong coffe!"); 
        }
    }
}
