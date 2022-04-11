class Program
{
    static void Main()
    {
        int count = 0;
        int PriceCoffee = 300;
        int PriceTea = 400;
        CafeDruid cafeDruid = new();
        Console.Write("Coffee - ");
        int t1 = int.Parse(Console.ReadLine());
        count += cafeDruid.Price1(PriceCoffee, t1);
        cafeDruid.Coffee();
        Console.Write("Tea - ");
        int t2 = int.Parse(Console.ReadLine());
        count += cafeDruid.Price1(PriceTea, t2);
        cafeDruid.Tea();

        int PricePizza = 2500;
        PizzaDruid pizzaDruid = new();
        Console.Write("Pizza - ");
        int t3 = int.Parse(Console.ReadLine());
        count += pizzaDruid.Price1(PricePizza, t3);
        pizzaDruid.Pizza();

        int PriceSoup = 2000;
        int PricCake = 500;
        RestDruid restDruid = new();
        Console.Write("Soup - ");
        int t4 = int.Parse(Console.ReadLine());
        count += restDruid.Price1(PriceSoup, t4);
        restDruid.Soup();
        Console.Write("Cake - ");
        int t5 = int.Parse(Console.ReadLine());
        count += restDruid.Price1(PricCake, t5);
        restDruid.Cake();
        Console.WriteLine("Account - " + count);
        Console.ReadKey();


    }


}