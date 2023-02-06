using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower().Replace(" ","");
            string[] strArray = str.Split();
            bool f = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1])
                    f = false;
            }
            {
                if (f == true)
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
}
    
