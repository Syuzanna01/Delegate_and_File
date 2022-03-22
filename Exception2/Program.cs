//2
using System;
namespace ConsoleApp1
{
    class Program
    { 
        static void Main(string[] args)
        {
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType());
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
