using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do today? 1. Action 2. Chilling 3. Danger 4. Good Food");
            string answer = Console.ReadLine().ToLower();
            if (answer == "1" || answer == "action")
            {
                Console.WriteLine("Stock Car Racing");
            } else if(answer == "2")
            {
                Console.WriteLine("Hiking");
            }
            else if (answer == "3")
            {
                Console.WriteLine("Skydiving");
            }
            else if (answer == "4")
            {
                Console.WriteLine("Taco Bell");
            }


            Console.WriteLine("How many peeps?");
            int answer2 = Convert.ToInt32(Console.ReadLine());
            if (answer2 == 0)
            {
                Console.WriteLine("Sneakers");
            }
            if (answer2 >= 1 && answer2 <= 4)
            {
                Console.WriteLine("A Sedan");
            }
            if (answer2 >= 5 && answer2 <= 10)
            {
                Console.WriteLine("A Volkswagon Bus");
            }
            if (answer2 > 11)
            {
                Console.WriteLine("A Airplane");
            }
            else
            {
                Console.WriteLine("Can bring negative peeps.");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }

    }
}
