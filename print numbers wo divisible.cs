using System;

namespace BreakAndContinuePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = -10;

            while(true)
            {
                if (counter %3 == 0)
                {
                    counter++;
                    continue;
                }

                if (counter == 10)
                {
                    break;
                }
                Console.WriteLine(counter++);
            }
        }
    }
}
