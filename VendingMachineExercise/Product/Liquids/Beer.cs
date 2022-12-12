using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachineExercise
{
    internal class Beer : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        
        public Beer()   // Konstruktor som innehåller en kategori och ett individuellt pris
        {
            Category = categories.Liquids;
            Price = 10;
        }

        public override string getDescription()
        {
            return "Beers can range from having mild flavor to an intense bold taste experience. A mild beer might taste light, delicate, crisp and refreshing. A bolder beer might have stronger flavors that result in a sharper taste which might be described as intense, powerful, robust and hearty.";
        }
        public override void useProduct()
        {
            Console.WriteLine("wow that tastes good");
        }

        public override string getName()
        {
            return "beer";
        }
    }

}
