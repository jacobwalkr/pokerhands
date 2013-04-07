using System;

namespace PokerHands.HandType
{
    class ThreeOfAKind : HandType
    {
        new public readonly int Rank = 4;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
