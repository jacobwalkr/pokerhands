using System;

namespace PokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();

            do
            {
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
            }
            while (dealer.RetryWithNewHand());
        }
    }
}
