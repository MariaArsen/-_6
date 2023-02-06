using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower().Replace(" ", "");
            string str2 = ""; 
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            if (str==str2)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
