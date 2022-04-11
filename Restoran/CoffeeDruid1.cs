using ConsoleApp1;
using Restoran;
using static Program;

class CafeDruid : DruidClab, Interface1
{
    public int Price { get ; set; }

    public void Price1(int P)
    {
        Price = P;
    }
    public int Price2(int P, int t)
    {
        int count = 0;
        Price = P;
        count += t * P;
        return count;
    }


    public void Coffee()
    {
        Console.Write("Coffee - ");
        string b = "";
        Delegatee delegatee = Method1;
        delegatee += Method2;
        delegatee += Method3;
        Console.WriteLine(delegatee(ref b) + "  Price - " + Price);
    }

    public void Tea()
    {
        Console.Write("Tes - ");
        string b = "";
        Delegatee delegatee = Method1;
        delegatee += Method5;
        delegatee += Method3;
        Console.WriteLine(delegatee(ref b) + "  Price - " + Price);
    }
}