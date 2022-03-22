//1
using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\input\text.txt";
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (Exception)
            {
                string l = "Exclusion error:";
                File.WriteAllText(file, l);
            }
            Console.ReadKey();
        }
    }
}