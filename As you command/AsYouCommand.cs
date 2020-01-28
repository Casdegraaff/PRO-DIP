using System;

namespace opdracht1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("How much different numbers do you want to generate?");
            int listLength;
            listLength = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("What's the max number you want it to go up to?");
            int untilNumber;
            untilNumber = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            list(listLength, untilNumber);

            void list(int amount, int until)
            {
                for (int i = 0; i < amount; i++)
                {
                    Random randm = new Random();
                    int RandomNumber = randm.Next(until);
                    Console.WriteLine(RandomNumber);
                }
            }
        }
    }
}