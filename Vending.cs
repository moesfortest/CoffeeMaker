

namespace CoffeeMaker
{
    public class Vending
    {
        /// <summary>
        /// Fill Vending  Capacity
        /// </summary>
        public double CoffeeVolume { get; set; }

        public double WaterVolume { get; set; }


        //Display  Level Of Coffee And Water
        public double WaterLevel { get;private set; }


        public double CoffeeLevel { get; private set; }
        public Vending(double coffeeInserted,double  waterInserted)
        {
            CoffeeVolume= coffeeInserted;
            WaterVolume = waterInserted;


            CoffeeLevel = coffeeInserted;
            WaterLevel= waterInserted;
        }
        public  void  MakeEspersso()
        {
            try
            {
                var result = CheckResource(20, 50);
                if (result == true)
                {
                    BoilWater();
                    CoffeeGrind();
                    BrewCoffee();

                    CoffeeVolume = CoffeeVolume - 20;
                    WaterVolume = WaterVolume - 50;


                    CoffeeLevel = CoffeeVolume;

                    WaterLevel = WaterVolume;
                }

                if (WaterLevel <= 0)
                {
                    WaterLevel = 0;
                }
                else
                {
                    WaterLevel = WaterVolume;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

          

    
        }

        private bool CheckResource(double coffee, double water)
        {

            bool result = false;
            if (WaterLevel <=0 || CoffeeLevel < 18 )
            {
                Console.WriteLine("Resource   Finshed! Check  Water Or  Coffee");
                throw new Exception ("Coffee  Finshed!") ;
               
            }
            else
            {
                result = true;
            }



            return result;
             
        }

        private void BrewCoffee()
        {
            Console.WriteLine("BrewCoffee");
        }

        private void CoffeeGrind()
        {
            Console.WriteLine("CoffeeGrind");
        }

        private void BoilWater()
        {
            Console.WriteLine("BoilWater");
        }

        //private void   Payment()
        //{

        //}
    }
}
