using ConsoleApp1;
using Restoran;

class CafeDruid : DruidClab, Interface1
{


    public CafeDruid()
    {
    }
    public int Price1(int P,int t)
    {
        int count= 0;
        Price = P;
        count += t*P;
        return count;
    }

    public int Price { get ; set; }

    public delegate string Delegatee(ref string b);
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