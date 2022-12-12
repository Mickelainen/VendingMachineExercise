using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Meals
{
    internal class NasiGoreng : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public NasiGoreng() 
        {
            Category = categories.Meals;
            Price = 8;
        }

        public override string getDescription()
        {
            return "Recognized as Indonesia's all time favorite dish, Nasi Goreng or Fried rice is a meal that can be taken any time; for breakfast, lunch or even dinner. It is said that the original recipe was brought by Chinese migrants to these islands and through the centuries it was adapted to local taste.";
        }
        public override string getName()
        {
            return "Nasi Goreng";
        }
        public override void useProduct()
        {
            Console.WriteLine("Yummy!");
        }
    }
}
