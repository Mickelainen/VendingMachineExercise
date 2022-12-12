using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VendingMachineExercise.ProductItem;

namespace VendingMachineExercise.Product.RoughWeatherProducts
{
    internal class Snowblower : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public Snowblower()
        {
            Category = categories.RoughWeatherItems;
            Price = 75;
        }
        public override string getDescription()
        {
            return "A machine for removing snow (as from a driveway or sidewalk) in which a rotating spiral blade picks up and propels the snow aside.";
        }

        public override string getName()
        {
            return "Snowblower";
        }

        public override void useProduct()
        {
            Console.WriteLine("Voooosh! What a fantastic blowing capacity!");
        }
    }
}
