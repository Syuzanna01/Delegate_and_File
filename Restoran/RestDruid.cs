using ConsoleApp1;
using Restoran;
using static CafeDruid;

class RestDruid : DruidClab, Interface1
{


    public int Price { get; set; }

    public int Price1(int P,int t)
    {
        int count = 0;
        Price = P;
        count += t*P;
        return count;

    }
    public void Soup()
    {
        Console.Write("Soup - ");
        string b = "";
        Delegatee delegatee = Method1;
        delegatee += Method8;
        delegatee += Method9;
        delegatee += Method10;
        delegatee += Method11;
        Console.WriteLine(delegatee(ref b) + "  Price - " + Price);
    }

    public void Cake()
    {
        Console.Write("Cake - ");
        string b = "";
        Delegatee delegatee = Method1;
        delegatee += Method3;
        delegatee += Method4;
        delegatee += Method8;
        Console.WriteLine(delegatee(ref b) + "  Price - " + Price);
    }
}