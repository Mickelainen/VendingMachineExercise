using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Liquids
{
    internal class Hennigans : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public Hennigans()
        {
            Category = categories.Liquids;
            Price = 50;
        }

        public override string getDescription()
        {
            return "Thats Hennigans, the no-smell no-tell, Scotch! ";
        }
        public override string getName()
        {
            return "Hennigans";
        }
        public override void useProduct()
        {
            Console.WriteLine("Ohhhhhh that Hennigans goes down smooth!");
        }
    }
}
