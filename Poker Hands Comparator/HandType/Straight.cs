using System;

namespace PokerHands.HandType
{
    class Straight : HandType
    {
        new public readonly int Rank = 5;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
