using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands
{
    partial class Hand
    {
        private Hand.Rank Score()
        {
            // Cascade through score methods until a match is found
            if (this.IsStraightFlush())
            {
                return Hand.Rank.StraightFlush;
            }
        }

        private bool IsStraightFlush()
        {
            int previousValue = this[0].Value;
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                int currentValue = this[cardIndex].Value;
                char currentSuit = this[cardIndex].Suit;

                if (((currentValue - previousValue) != 1) || (previousSuit != currentSuit))
                {
                    // If the values aren't consecutive or the suits aren't the same
                    return false;
                }

                previousValue = currentValue;
                previousSuit = currentSuit;
            }

            return true;
        }
    }
}
