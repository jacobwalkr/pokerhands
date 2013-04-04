using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();

            Hand firstHand = dealer.GetValidHandOrDieTrying();
            Hand secondHand = dealer.GetValidHandOrDieTrying();

            Hand.ComparisonOutcome outcome = firstHand.CompareTo(secondHand);

            if (outcome == Hand.ComparisonOutcome.Win)
            {
                Console.WriteLine("The first hand wins.");
            }
            else if (outcome == Hand.ComparisonOutcome.Lose)
            {
                Console.WriteLine("The second hand wins.");
            }
            else // Outcome = Hand.ComparisonOutcome.Draw
            {
                Console.WriteLine("The hands are tied.");
            }
            
            Console.ReadKey();
        }
    }
}
