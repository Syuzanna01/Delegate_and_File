using ConsoleApp1;
using Restoran;
using static CafeDruid;
using static Program;

class PizzaDruid : DruidClab, Interface1
{
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
    public int Price { get; set; }

    public void Pizza()
    {
        Console.Write("Pizza - ");
        string b = "";
        Delegatee delegatee = Method1;
        delegatee += Method6;
        delegatee += Method7;
        delegatee += Method8;
        Console.WriteLine(delegatee(ref b) + "  Price - " + Price);
    }
}