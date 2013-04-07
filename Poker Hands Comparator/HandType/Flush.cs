using System;

namespace PokerHands.HandType
{
    class Flush : HandType
    {
        new public readonly int Rank = 6;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
