using System;

namespace PokerHands.HandType
{
    class FourOfAKind : HandType
    {
        new public readonly int Rank = 8;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
