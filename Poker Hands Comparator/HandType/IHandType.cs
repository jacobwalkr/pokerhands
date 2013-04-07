using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.HandType
{
    interface IHandType
    {
        int Rank { get; }
        public Hand.ComparisonOutcome CompareToSimilar(Hand hand);
    }
}
