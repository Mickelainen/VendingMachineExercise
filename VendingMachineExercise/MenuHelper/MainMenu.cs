using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    public class MainMenu // Skapar olika MenuOptions objekt och lägger till en ny string array med de olika menyalternativen
    {
        public MenuOptions MainOptions = new MenuOptions 
        {
            Options = new string[]
            {
                "1. Liquids",
                "2. Meals",
                "3. Rough Weather Products",
                "4. Exit Vendingmachine"
            }
        };

        public MenuOptions LiquidOptions = new MenuOptions
        {
            Options = new string[]
            {
                "1. Beer",
                "2. Coffee",
                "3. Hennigans",
                "\nPress Enter to return to Main Menu"
            }
        };

        public MenuOptions MealOptions = new MenuOptions
        {
            Options = new string[]
            {
                "1. Nasi Goreng",
                "2. Raggmunk med fläsk",
                "3. Svartsoppa",
                "\nPress Enter to return to Main Menu"
            }
        };

        public MenuOptions RoughWeatherProductOptions = new MenuOptions
        {
            Options = new string[]
            {
                "1. Snow Blower",
                "2. Space Heater",
                "3. Chainsaw",
                "\nPress Enter to return to Main Menu"
            }
        };


    }
}
