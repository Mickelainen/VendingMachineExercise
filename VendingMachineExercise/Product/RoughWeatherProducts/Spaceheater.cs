using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Product.RoughWeatherProducts
{
    internal class Spaceheater : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public Spaceheater()
        {
            Category = categories.RoughWeatherItems;
            Price = 250;
        }
        public override string getDescription()
        {
            return "An electric space heater is a heating device designed to focus heat in a single room or small zone. They work by expelling hot air through a fan, which naturally rises and forces colder air to the floor. This process helps to circulate the heat and warm the space effectively.";
        }

        public override string getName()
        {
            return "Spaceheater";
        }

        public override void useProduct()
        {
            Console.WriteLine("MMmmMM warm and cozy feeling!");
        }
    }
}
