using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_week1_day3
{
    class Program
    {
        private static readonly char M;

        static void Main(string[] args)
        {
            //pick two nums tell if they were equal or not!

            /*          Console.WriteLine("pick a number");
                      int user1 = int.Parse(Console.ReadLine());

                      Console.WriteLine("pick a number");
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
          */


            // pick a number tell if it is odd or not
            /*  Console.WriteLine("pick a number");
              int pick = int.Parse(Console.ReadLine());
              bool odd = (pick % 2 != 0);
              bool isEven = (pick % 2 == 0);

              if (odd)
              {
                  Console.WriteLine(pick + " is a odd number ");
              }
              else
              {


                  
  */

            // positive or neg nums

            /*   Console.WriteLine("pick a number");
               int pick = int.Parse(Console.ReadLine());

               bool pos = (pick >= 0);
               bool neg = (pick <= -1);

               if (neg)
               {

                   Console.WriteLine("The number " + pick + " is a negative number!");

               }

               else 
               {

                   Console.WriteLine("The number " + pick + " is a positive number!");

          */

            //fixed array still nee to go through and debug!!!
            Console.WriteLine("pick a letter");
        char  choice = Convert.ToChar(Console.ReadLine());
            
            
            char[] vow = new char[]{ 'a' , 'e', 'i','o', 'u' };
            char[] cons = new char[] { 'b', 'C', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

            




            if (vow)
            {

                Console.WriteLine("That letter a is a vowel");

            }

            else
            {

                Console.WriteLine("The letter c is a consonant");

            }



            //get average of the 4 nums this is problem (6)
            /*    Console.WriteLine("pleas enter a 4 number!");
                double firstNum = double.Parse(Console.ReadLine());
                double secondNum = double.Parse(Console.ReadLine());
                double thirdNum = double.Parse(Console.ReadLine());
                double fourthNum = double.Parse(Console.ReadLine());
                double average = (firstNum + secondNum + thirdNum + fourthNum) / 4;

                Console.WriteLine("the average is " + average);



        */




        }

    }
}
