using System;

namespace BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("This App Checks Bonus Score by Entered Value");
            Console.WriteLine();
            Console.Write("Please enter a value (1-9):");
            int value = int.Parse(Console.ReadLine());

            if (value >= 1 && value <= 9)
            {
                if (value >= 1 && value <= 3)
                {
                    Console.WriteLine(value * 10);

                }
                if (value >= 4 && value <= 6)
                {
                    Console.WriteLine(value * 100);
                }
                if (value >= 7 && value <= 9)
                {
                    Console.WriteLine(value * 1000);

                }
            }
            else
            {
                Console.WriteLine("invalid score");

            }

        }
    }
}