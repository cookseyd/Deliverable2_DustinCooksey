using System;

/*
 * Author: Dustin Cooksey
 * Date: 01/20/2023
 * Description: This C# Console application takes a users input
 * about what grade they expect to receive in ISM 4300 and returns
 * a letter grade value.
*/ 

namespace Deliverable2_DustinCooksey
{
    class Deliverable2_DC
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300?");
                int grade = int.Parse(Console.ReadLine());


                if (grade > 89)
                {
                    Console.WriteLine("You will recieve an A");
                }
                else if (grade > 79)
                {
                    Console.WriteLine("You will receive a B");
                }
                else if (grade > 69)
                {
                    Console.WriteLine("You will receive a C");
                }
                else if (grade > 59)
                {
                    Console.WriteLine("You will receive a D");
                }
                else
                {
                    Console.WriteLine("You will recieve a F");
                }
            }

            catch
            {
                Console.WriteLine("Please only use whole integer numbers");
            }
        }
    }
}
