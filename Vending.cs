
namespace CoffeeMaker
{
    public class Vending
    {

        private Vending(double coffeeInserted, double waterInserted) 
        {
            CoffeeCapacity = coffeeInserted;
            WaterCapcity = waterInserted;
        }

        public int coffeeNumber;
        public static int NumberOfDevice;

        public   static Vending CreatObject(double coffeeInserted, double waterInserted)
        {
            try
            {
                NumberOfDevice++;
                if (NumberOfDevice <= 3)
                {
                    return new Vending(coffeeInserted, waterInserted);
                }

                else
                {
                    throw new Exception("Max Obj is 3");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return null;
            }
 
        }

        /// <summary>
        /// Fill Vending  Capacity
        /// </summary>
        /// 
        private double _coffcapacity;

        public double CoffeeCapacity
        {
            get { return _coffcapacity; }
            set { if (value < 0) _coffcapacity = 0; else _coffcapacity = value; }
        }

        private double _watercapacity;

        public double WaterCapcity
        {
            get { return _watercapacity; }
            set { if (value < 0) _watercapacity = 0; else _watercapacity = value; }
        }

        //Display  Level Of Coffee And Water
        public double WaterLevel => WaterCapcity;
        public double CoffeeLevel => CoffeeCapacity;



        public void MakeEspersso()
        {

            try
            {

                var result = CheckResource();
                if (result == true)
                {
                    BoilWater();
                    CoffeeGrind();
                    BrewCoffee();

                    CoffeeCapacity = CoffeeCapacity - 20;
                    WaterCapcity = WaterCapcity - 50;
                    coffeeNumber++;
                }

               /// CheckForZeroValue();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void CheckForZeroValue()
        {
            if (WaterCapcity <= 0)
            {
                WaterCapcity = 0;
            }


            if (CoffeeLevel <= 0)
            {
                CoffeeCapacity = 0;
            }
        }

        private bool CheckResource()
        {

            bool result = false;
            if (WaterLevel <= 0)
            {

                throw new Exception("WaterLevel  Finshed!");

            }
            if (CoffeeLevel <= 0)
            {

                throw new Exception("Coffee  Finshed!");

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
