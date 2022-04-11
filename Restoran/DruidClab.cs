using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class DruidClab
    {
        protected string Method1(ref string b)
        {
            string t = "water, ";
            return b += t;
        }
        protected string Method2(ref string b)
        {
            string t = "coffee, ";
            return b += t;
        }
        protected string Method3(ref string b)
        {
            string t = "sugar";
            return b += t;
        }
        protected string Method4(ref string b)
        {
            string t = "flour, ";
            return b += t;
        }
        protected string Method5(ref string b)
        {
            string t = "tea, ";
            return b += t;
        }
        protected string Method6(ref string b)
        {
            string t = "mushrooms, ";
            return b += t;
        }
        protected string Method7(ref string b)
        {
            string t = "cheese, ";
            return b += t;
        }
        protected string Method8(ref string b)
        {
            string t = "salt, ";
            return b += t;
        }
        protected string Method9(ref string b)
        {
            string t = "tomato, ";
            return b += t;
        }
        protected string Method10(ref string b)
        {
            string t = "greens, ";
            return b += t;
        }
        protected string Method11(ref string b)
        {
            string t = "onion, ";
            return b += t;
        }
    }
}