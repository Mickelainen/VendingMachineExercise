using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineExercise
{
    public interface IProduct   // Interface för Product, fick en bugg med namespaces som gjorde att jag blev tvungen att renama Products till ProductItem för det skulle fungera.
    {
        string getDescription();
        double getCost();
        string getName();
        void useProduct();
    }
}
