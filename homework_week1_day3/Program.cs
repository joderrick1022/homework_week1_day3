using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week1_day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("guess a number");
            int user1 = int.Parse(Console.ReadLine());

            Console.WriteLine("guess a number");
            int user2 = int.Parse(Console.ReadLine());

            bool equal = (user1 == user2);

            bool notEqual = (user1 != user2);

            if (equal)
            {
                Console.WriteLine("The numbers " + user1 + " and " + user2 + " are the same number!");
            }
            else if(notEqual)
            {
                Console.WriteLine("The numbers " + user1 + " and" + user2 + " are not equal to each other!");
            }


        }
    }
}
