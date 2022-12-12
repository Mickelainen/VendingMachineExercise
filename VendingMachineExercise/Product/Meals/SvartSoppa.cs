using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Meals
{
    internal class SvartSoppa : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public SvartSoppa()
        {
            Category = categories.Meals;
            Price = 1;
        }

        public override string getDescription()
        {
            return "Svartsoppa tillagas av bland annat buljong och gåsblod. Den reds och smaksätts därefter med sirap, starkvin, cognac, vinäger, kryddnejlika, ingefära och kryddpeppar. Till soppan serveras kokta äppelklyftor och katrinplommon, gåsleverkorv och kokt gåskrås.";
        }
        public override string getName()
        {
            return "Svartsoppa";
        }
        public override void useProduct()
        {
            Console.WriteLine("Hmm.. interesting taste..");
        }
    }
}
