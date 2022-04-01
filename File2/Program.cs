using System;

namespace File2
{
    class Program
    {
        static void Main()
        {
            FileStream opend = new FileStream(@"c:\input\textob.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            StreamWriter whrite = new StreamWriter(opend);

            whrite.WriteLine("Hi!");

            whrite.Close();
        }
    }
}