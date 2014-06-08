using System;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {
            Console.Write("Please enter a play card sign to check if it is valid :");
            string card = Console.ReadLine().ToUpper();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "Q":
                case "J":
                case "K":
                case "A":
                    Console.WriteLine("yes");
                    break;

                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
