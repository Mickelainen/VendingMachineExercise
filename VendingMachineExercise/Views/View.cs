using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    public class View // Klass som innehåller metoder för att displaya olika menyer och felmeddelanden
    {
        public View()
        {

        }

        public void DisplayMainMenu()
        {
            PageBuilder pageBuilder = new PageBuilder(); // Skapar ett PageBuilder objekt
            var top = pageBuilder.BuildTop();   // Kallar på pagebuilder metoderna
            var bottom = pageBuilder.BuildBottom();
            MainMenu mainMenu = new MainMenu(); // Skapar ett objekt av MainMenu
            var content = mainMenu.MainOptions.Options; // Använder det till hämta ut den array med Options man vill ha och lägga i content
            pageBuilder.Build(top, content, bottom); // Kallar på Build() metoden från PageBuilder och sätter ihop de tre delarna
            
        }

        public void DisplayLiquidMenu()
        {
            PageBuilder pageBuilder = new PageBuilder(); // Skapar ett PageBuilder objekt
            var top = pageBuilder.BuildTop();   // Kallar på pagebuilder metoderna
            var bottom = pageBuilder.BuildBottom();
            MainMenu mainMenu = new MainMenu(); // Skapar ett objekt av MainMenu
            var content = mainMenu.LiquidOptions.Options; // Använder det till hämta ut den array med Options man vill ha och lägga i content
            pageBuilder.Build(top, content, bottom); // Kallar på Build() metoden från PageBuilder och sätter ihop de tre delarna
        }

        public void DisplayMealMenu()
        {
            PageBuilder pageBuilder = new PageBuilder(); // Skapar ett PageBuilder objekt
            var top = pageBuilder.BuildTop(); // Kallar på pagebuilder metoderna
            var bottom = pageBuilder.BuildBottom();
            MainMenu mainMenu = new MainMenu(); // Skapar ett objekt av MainMenu
            var content = mainMenu.MealOptions.Options; // Använder det till hämta ut den array med Options man vill ha och lägga i content
            pageBuilder.Build(top, content, bottom); // Kallar på Build() metoden från PageBuilder och sätter ihop de tre delarna
        }

        public void DisplayRoughWeatherProductMenu() // -- Samma som ovan --
        {
            PageBuilder pageBuilder = new PageBuilder();
            var top = pageBuilder.BuildTop();
            var bottom = pageBuilder.BuildBottom();
            MainMenu mainMenu = new MainMenu();
            var content = mainMenu.RoughWeatherProductOptions.Options;
            pageBuilder.Build(top, content, bottom);
        }

        public void TestUserInput(string input)  // Metod för att testa Userinput och se om det hamnar innanför ramarna av menyvalen
        {
            string errorMessage = "Please enter a valid option";
            try
            {
                bool testForNumber = int.TryParse(input, out int n);
                if (testForNumber)
                {
                    if (n > 3 || n <= 0)
                    {
                        Console.WriteLine(errorMessage);
                        Console.ReadLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine(errorMessage);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            } 
            
        }

        public void GoodByeMessage() 
        {
            Console.WriteLine("Thank you for shopping with us! Goodbye..");
            Console.ReadLine();
        } // Metod för att printa ett GoodByeMessage
    }
}
