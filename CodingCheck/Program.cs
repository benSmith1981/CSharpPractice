using System;

namespace CodingCheck
{

    class Program
    {
        static int shipSpeed = 10;

        public void increaseSpeed()
        {

            shipSpeed = 10;

            string[] names = {"Bee","Thomas"};
            for (int index = 0;
                index < names.Length;
                index++)
            {
                Console.WriteLine(names[index]);
            }

        }

        public static void decreaseSpeed(int increase)
        {
            shipSpeed = shipSpeed + increase;

        }
        static void Main(string[] args)
        {
            decreaseSpeed(5);
            Console.WriteLine("Hello World!");
        }


    }
}
