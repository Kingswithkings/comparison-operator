using System;

namespace comparison_operator_in_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int myage = 25;
            int votingage = 18;

            if (myage >= votingage)
            {
                Console.WriteLine("old enough to vote");
            }
            else
            {
                Console.WriteLine("not old enough to vote");
            }
        }
    }
}
