using System;
using System.Linq;

namespace Arrays_and_Such
{
    class Program
    {
        static void Main(string[] args)
        {
            //The List
            string[] Pokemon = { "Pikachu", "Ninjask", "Palkia", "Jolteon", "Rhydon"};

            //Change the name of the thing you want
            Pokemon[1] = "Shedinja";

            //Sorts in Alphbetical Order with ForEach
            Array.Sort(Pokemon);
            foreach (string i in Pokemon)
            {
                Console.WriteLine(i);
            }

            //Same can be done with Numbers
            int[] myNum = { 10, 13, 17, 50, 67, 89 };
            Console.WriteLine(myNum.Max()); //Largest
            Console.WriteLine(myNum.Min()); //Smallest
            Console.WriteLine(myNum.Sum()); //Sum of the All

        }
    }
}
