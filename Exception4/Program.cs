//4
using System;
class Exe : Exception
{
    public static void e(string a)
    {
        string k = "cnect";
        if (k != a)
        {
            throw new NotImplementedException();
        } 
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            string a = "cnect";
            Exe.e(a);
        }
        catch (Exception)
        {
            Console.Write("Error occurred.");
        }

        Console.WriteLine(true);
        Console.ReadKey();
    }
}