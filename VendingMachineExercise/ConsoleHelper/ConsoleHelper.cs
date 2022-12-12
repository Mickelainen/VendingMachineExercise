using System;


namespace VendingMachineExercise
{
    public static class ConsoleHelper // Valt att göra den här klassen static för den behöver inte instansieras
    {
       
       public static void MenuHelper() // samma sak med denna metoden som styr appen genom en stor switch sats, tar in userinputs och visar olika menyer beroende på valen.
        {
            string input;
            bool selectComplete; // Bool för att styra när do while loopen ska brytas
            do
            {

            selectComplete = false;
            View view = new View(); // Skapar ett View objekt som sedan återanvänds i switch satsen
            Console.Clear();
            view.DisplayMainMenu();  // Metod som hämtas från View som visar Main Menu alternativen
            input = Console.ReadLine();

            switch (input)  // Valde att använda en switch sats för att styra menyvalen
            {
                
                case "1":
                        Console.Clear();
                        view.DisplayLiquidMenu();   // Metod för att visa LiquidMenyn
                        input = Console.ReadLine();
                        view.TestUserInput(input);  // Metod för att testa om inputen stämmer överens med de menyval som finns.
                        if (input == "1")
                        {
                            Console.Clear();
                            IProduct beer = Factory.CreateBeer();  // Använder klassen Factory för att ta bort Tight Coupling. Skapandet av objektet sker i särskild klass.
                            Console.WriteLine("Description : " + beer.getDescription()); // 
                            Console.WriteLine();
                            Console.WriteLine($"The cost of a good old {beer.getName()} is {beer.getCost()} $"); // Använder objektets overriden metoder för att hämta dess data.
                            Console.WriteLine();
                           
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuyBeer = Console.ReadLine();
                            view.TestUserInput(answerBuyBeer);
                            if (answerBuyBeer == "1")
                            {  
                                Console.WriteLine();
                                beer.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuyBeer == "2") { Console.Clear(); }
                            
                            else { Console.Clear(); }
                        }
                        if (input == "2")
                            {
                                Console.Clear();
                                IProduct coffee = Factory.CreateCoffee();  // Repetiton av kommentarerna ovan
                                Console.WriteLine("Description : " + coffee.getDescription());
                                Console.WriteLine();
                                Console.WriteLine($"The cost of a nice cup of {coffee.getName()} is {coffee.getCost()} $");
                                Console.WriteLine();

                                Console.WriteLine("1. Purchase");
                                Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                                string answerBuyCoffee = Console.ReadLine();
                                view.TestUserInput(answerBuyCoffee);
                            if (answerBuyCoffee == "1")
                                {
                                    Console.WriteLine();
                                    coffee.useProduct();
                                    Console.WriteLine("\nPress any key to return to the menu");
                                    Console.ReadKey();
                                    Console.Clear();
                                }
                                if (answerBuyCoffee == "2") { Console.Clear(); }

                                else { Console.Clear(); }
                            }
                        if (input == "3")
                        {
                            Console.Clear();
                            IProduct hennigans = Factory.CreateHennigans(); // Repetiton av kommentarerna ovan

                            Console.WriteLine("Description : " + hennigans.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The gentlemans drink of {hennigans.getName()} is {hennigans.getCost()} $");
                            Console.WriteLine();

                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuyHennigans = Console.ReadLine();
                            view.TestUserInput(answerBuyHennigans);
                            if (answerBuyHennigans == "1")
                            {
                                Console.WriteLine();
                                hennigans.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuyHennigans == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }                        
                         break;
                   case "2":
                        Console.Clear();
                        view.DisplayMealMenu(); // Metod för att visa Meal menyn.
                        input = Console.ReadLine();
                        view.TestUserInput(input);

                        if (input == "1")
                        {
                            Console.Clear();
                            IProduct nasiGoreng = Factory.CreateNasiGoreng();  // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + nasiGoreng.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The cost of a asian classic {nasiGoreng.getName()} is {nasiGoreng.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuyNasiGoreng = Console.ReadLine();
                            view.TestUserInput(answerBuyNasiGoreng);
                            if (answerBuyNasiGoreng == "1")
                            {
                                Console.WriteLine();
                                nasiGoreng.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuyNasiGoreng == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }
                        if (input == "2")
                        {
                            Console.Clear();
                            IProduct raggmunk = Factory.CreateRaggmunk();  // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + raggmunk.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The cost of a swedish household meal of {raggmunk.getName()} is {raggmunk.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuyRaggmunk = Console.ReadLine();
                            view.TestUserInput(answerBuyRaggmunk);
                            if (answerBuyRaggmunk == "1")
                            {
                                Console.WriteLine();
                                raggmunk.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuyRaggmunk == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }
                        if (input == "3")
                        {
                            Console.Clear();
                            IProduct svartSoppa = Factory.CreateSvartSoppa(); // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + svartSoppa.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The medieval soup {svartSoppa.getName()} is {svartSoppa.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuySvartSoppa = Console.ReadLine();
                            view.TestUserInput(answerBuySvartSoppa);
                            if (answerBuySvartSoppa == "1")
                            {
                                Console.WriteLine();
                                svartSoppa.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuySvartSoppa == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }
                        break;

                    case "3":
                        Console.Clear();
                        view.DisplayRoughWeatherProductMenu(); // Metod för att visa RoughWeatherProductMenyn
                        input = Console.ReadLine();
                        view.TestUserInput(input);

                        if (input == "1")
                        {
                            Console.Clear();
                            IProduct snowblower = Factory.CreateSnowblower();  // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + snowblower.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The cost of really strong {snowblower.getName()} is {snowblower.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuySnowblower = Console.ReadLine();
                            view.TestUserInput(answerBuySnowblower);
                            if (answerBuySnowblower == "1")
                            {
                                Console.WriteLine();
                                snowblower.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuySnowblower == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }
                        if (input == "2")
                        {
                            Console.Clear();
                            IProduct spaceheater = Factory.CreateSpaceheater();  // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + spaceheater.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"The cost of a warm and sweet {spaceheater.getName()} is {spaceheater.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuySpaceheater = Console.ReadLine();
                            view.TestUserInput(answerBuySpaceheater);
                            if (answerBuySpaceheater == "1")
                            {
                                Console.WriteLine();
                                spaceheater.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuySpaceheater == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        }
                        if (input == "3")
                        {
                            Console.Clear();
                            IProduct chainsaw = Factory.CreateChainsaw(); // Repetiton av kommentarerna ovan
                            Console.WriteLine("Description : " + chainsaw.getDescription());
                            Console.WriteLine();
                            Console.WriteLine($"A sturdy {chainsaw.getName()} for a bad day is {chainsaw.getCost()} $");
                            Console.WriteLine();
                            Console.WriteLine("1. Purchase");
                            Console.WriteLine("2. Cancel Purchase (Return to previous menu)");
                            string answerBuyChainsaw = Console.ReadLine();
                            view.TestUserInput(answerBuyChainsaw);
                            if (answerBuyChainsaw == "1")
                            {
                                Console.WriteLine();
                                chainsaw.useProduct();
                                Console.WriteLine("\nPress any key to return to the menu");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            if (answerBuyChainsaw == "2") { Console.Clear(); }

                            else { Console.Clear(); }
                        } 
                        break;
                    case "4":
                        selectComplete = true;
                        view.GoodByeMessage(); 
                        break;
                    default:               
                    Console.WriteLine("Please enter a valid menu option");
                    Console.ReadLine();
                    break;
            }
            } while (selectComplete != true);
        }
    
    }
}
