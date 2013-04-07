using System;

namespace PokerHands.HandType
{
    class StraightFlush : HandType
    {
        new public readonly int Rank = 9;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
