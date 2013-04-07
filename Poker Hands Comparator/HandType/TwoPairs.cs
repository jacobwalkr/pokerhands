using System;

namespace PokerHands.HandType
{
    class TwoPairs : HandType
    {
        new public readonly int Rank = 3;

        public override Hand.ComparisonOutcome CompareToSimilar(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
