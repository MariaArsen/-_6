using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ха-ха-ха{123{хи-хи}d3} хо-хо-хо";
            Console.WriteLine(s);
            string s2 = "";
            int a = s.IndexOf('{');
            int b = s.LastIndexOf('}');
            if ((a>0)||(b<0))
            {
                s2= s.Remove(a, (b)-(a-1));
            }
            Console.WriteLine(s2);

            Console.ReadKey();
        }
    }
}
