using System;

namespace PokerHands.HandType
{
    class FullHouse : HandType
    {
        new public readonly int Rank = 7;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
