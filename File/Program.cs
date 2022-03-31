using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"c:\input\text.txt";
            string file1 = @"c:\input\text1.txt";
            string l = "Hello Word";
            File.WriteAllText(file, l);

            File.Copy(file, file1);
            File.Delete(file);

            string filetry = @"c:\input\texttry.txt";
            int x = 0;
            try
            {
                int y = 100 / x;
            }
            catch (Exception)
            {
                string L = "Exclusion error:";
                File.WriteAllText(filetry, L);
            }
            Console.ReadKey();
        }
    }
}