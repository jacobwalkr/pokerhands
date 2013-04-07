using System;

namespace PokerHands.HandType
{
    class Pair : HandType
    {
        new public readonly int Rank = 2;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
