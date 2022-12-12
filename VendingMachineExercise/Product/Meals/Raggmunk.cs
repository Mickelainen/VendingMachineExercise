using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise.Meals
{
    internal class Raggmunk : ProductItem // Ärver från abstrakta klassen Product och implementerar och overridar dess metoder
    {
        public Raggmunk()
        {
            Category = categories.Meals;
            Price = 15;
        }

        public override string getDescription()
        {
            return "Potatispannkakor är ytfriterade pannkakor av riven eller malen potatis, matzomjöl eller mjöl och en bindande ingrediens som ägg eller äppelmos, ofta smaksatta med riven vitlök eller lök och smaksättning.";
        }
        public override string getName()
        {
            return "Raggmunk med fläsk";
        }
        public override void useProduct()
        {
            Console.WriteLine("That is amazing!");
        }
    }
}
