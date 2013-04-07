using System;

namespace PokerHands.HandType
{
    class Junk : HandType
    {
        new public readonly int Rank = 1;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
