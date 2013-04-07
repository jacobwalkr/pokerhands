
namespace PokerHands.HandType
{
    abstract class HandType
    {
        public readonly int Rank = 0;
        abstract public Hand.ComparisonOutcome CompareToSimilar(Hand hand);
    }
}
