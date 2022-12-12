using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineExercise.Liquids;
using VendingMachineExercise.Meals;
using VendingMachineExercise.Product.RoughWeatherProducts;

namespace VendingMachineExercise
{
    public static class Factory // static class för att skapa upp och returnera objekt från de olika klasserna
    {
        public static IProduct CreateBeer()
        {
            return new Beer();
        }

        public static IProduct CreateCoffee()
        {
            return new Coffee();
        }
        public static IProduct CreateHennigans() 
        {
            return new Hennigans();
        }
        public static IProduct CreateNasiGoreng()
        {
            return new NasiGoreng();
        }
        public static IProduct CreateRaggmunk()
        {
            return new Raggmunk();
        }
        public static IProduct CreateSvartSoppa()
        {
            return new SvartSoppa();
        }
        public static IProduct CreateChainsaw()
        {
            return new Chainsaw();
        }
        public static IProduct CreateSnowblower()
        {
            return new Snowblower();
        }
        public static IProduct CreateSpaceheater()
        {
            return new Spaceheater();
        }
    }
}
