using CoffeeMaker;

Console.WriteLine("WellCome To  CoffeeMaker");

double waterLevel=0;
double coffeeLevel=0;

var vendingObjOne = new Vending(100, 120);

vendingObjOne.MakeEspersso();
 waterLevel = vendingObjOne.WaterLevel;
 coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine("water level {0}:",waterLevel);
Console.WriteLine("Coffee levele {0}:",coffeeLevel);
Console.ReadLine();


vendingObjOne.MakeEspersso();
 waterLevel = vendingObjOne.WaterLevel;
 coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine(waterLevel);
Console.WriteLine(coffeeLevel);
Console.ReadLine();

vendingObjOne.MakeEspersso();
waterLevel = vendingObjOne.WaterLevel;
coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine(waterLevel);
Console.WriteLine(coffeeLevel);
Console.ReadLine();

vendingObjOne.MakeEspersso();
waterLevel = vendingObjOne.WaterLevel;
coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine(waterLevel);
Console.WriteLine(coffeeLevel);
Console.ReadLine();

vendingObjOne.MakeEspersso();
waterLevel = vendingObjOne.WaterLevel;
coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine(waterLevel);
Console.WriteLine(coffeeLevel);
Console.ReadLine();

vendingObjOne.MakeEspersso();
waterLevel = vendingObjOne.WaterLevel;
coffeeLevel = vendingObjOne.CoffeeLevel;
Console.WriteLine(waterLevel);
Console.WriteLine(coffeeLevel);
Console.ReadLine();



Console.ReadLine();

//var vendingObjBijar = new Vending(1000, 1000);


//var vendingObjRodbar = new Vending(1000, 9000);
