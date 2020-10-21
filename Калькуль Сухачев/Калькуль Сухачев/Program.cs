using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькуль_Сухачев
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            char oper = Convert.ToChar(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (oper == '+')
            {
                Console.WriteLine(x + y);
            }    
            else if (oper == '-')
            {
                Console.WriteLine(x-y);
            }
            else if (oper == '*')
            {
                Console.WriteLine(x * y);
            }
            else if (oper == ':')
            {
                Console.WriteLine(x / y);
            }
            Console.ReadKey(true);324

        }
    }
}
