using System;

namespace Delegate
{
    class Program
    {
        public delegate int Delegates(ref int a);
        static void Main()
        {
            int a = 1;
            Delegates delegates = Method1;
            delegates += Method2;
            delegates += Method3;
            delegates += Method4;
            Console.WriteLine(delegates(ref a));
        }
        static int Method1(ref int a)
        {
            return a*=2;
        }
        static int Method2(ref int a)
        {
            int p = 5;
            return a*=p;
        }
        static int Method3(ref int a)
        {
            int r = 6;
            return a*=r;
        }
        static int Method4(ref int a) 
        {
            return a*=a;
        }
    }
}