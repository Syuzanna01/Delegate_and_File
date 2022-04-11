class Program
{
    public delegate string Delegatee(ref string b);

    static void Main()
    {
        int count = 0;
        int PriceCoffee = 300;
        int PriceTea = 400;
        CafeDruid cafeDruid = new();
        cafeDruid.Price1(PriceCoffee);
        cafeDruid.Coffee();
        Console.Write("Coffee count - ");
        int t1 = int.Parse(Console.ReadLine());
        count += cafeDruid.Price2(PriceCoffee, t1);
     
        cafeDruid.Price1(PriceTea);
        cafeDruid.Tea();
        Console.Write("Tea count - ");
        int t2 = int.Parse(Console.ReadLine());
        count += cafeDruid.Price2(PriceTea, t2);

        int PricePizza = 2500;
        PizzaDruid pizzaDruid = new();
        pizzaDruid.Price1(PricePizza);
        pizzaDruid.Pizza();
        Console.Write("Pizza count - ");
        int t3 = int.Parse(Console.ReadLine());
        count += pizzaDruid.Price2(PricePizza, t3);

        int PriceSoup = 2000;
        int PricCake = 500;
        RestDruid restDruid = new();
        restDruid.Price1(PriceSoup);
        restDruid.Soup();
        Console.Write("Soup count - ");
        int t4 = int.Parse(Console.ReadLine());
        count += restDruid.Price2(PriceSoup, t4);
        restDruid.Price1(PricCake);
        restDruid.Cake();
        Console.Write("Cake count - ");
        int t5 = int.Parse(Console.ReadLine());
        count += restDruid.Price2(PricCake, t5);
        Console.WriteLine("Account - " + count);
        Console.ReadKey();


    }


}