using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Startar applikationen genom att kalla på den statiska klassen ConsoleHelper som innehåller en switch sats för att styra Menyvalen.
            ConsoleHelper.MenuHelper();
              
        }
    }
}
