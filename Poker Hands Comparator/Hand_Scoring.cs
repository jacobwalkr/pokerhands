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
            else if (this.IsFourOfAKind())
            {
                return Hand.Rank.FourOfAKind;
            }
            else if (this.IsFullHouse())
            {
                return Hand.Rank.FullHouse;
            }
            else if (this.IsFlush())
            {
                return Hand.Rank.Flush;
            }
            else if (this.IsStraight())
            {
                return Hand.Rank.Straight;
            }
            else if (this.IsThreeOfAKind())
            {
                return Hand.Rank.ThreeOfAKind;
            }
            else
            {
                int numPairs = this.CountPairs();

                if (numPairs == 2)
                {
                    return Hand.Rank.TwoPairs;
                }
                else if (numPairs == 1)
                {
                    return Hand.Rank.Pair;
                }
                else
                {
                    return Hand.Rank.Junk;
                }
            }
        }

        private bool IsStraightFlush()
        {
            int previousValue = this[0].Value;
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                if (((this[cardIndex].Value - previousValue) != 1) || !this[cardIndex].Suit.Equals(previousSuit))
                {
                    // If the values aren't consecutive or the suits aren't the same
                    return false;
                }

                previousValue = this[cardIndex].Value;
                previousSuit = this[cardIndex].Suit;
            }

            return true;
        }

        private bool IsFourOfAKind()
        {
            int[] valueOccurrences = new int[14];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 4)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsFullHouse()
        {
            int[] valueOccurrences = new int[14];
            bool three = false;
            bool two = false;

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 2)
                {
                    two = true;
                }
                else if (occurrences == 3)
                {
                    three = true;
                }
            }

            if (three && two)
            {
                return true;
            }

            return false;
        }

        private bool IsFlush()
        {
            char previousSuit = this[0].Suit;

            for (int cardIndex = 1; cardIndex < 5; cardIndex++)
            {
                if (this[cardIndex].Suit != previousSuit)
                {
                    return false;
                }
                else
                {
                    previousSuit = this[cardIndex].Suit;
                }
            }

            return true;
        }

        private bool IsStraight()
        {
            int previousValue = this[0].Value;

            foreach (Card card in this)
            {
                if ((card.Value - previousValue) != 1)
                {
                    // If the values aren't consecutive
                    return false;
                }

                previousValue = card.Value;
            }

            return true;
        }

        private bool IsThreeOfAKind()
        {
            int[] valueOccurrences = new int[14];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 3)
                {
                    return true;
                }
            }

            return false;
        }

        private int CountPairs()
        {
            int[] valueOccurrences = new int[14];

            foreach (Card card in this)
            {
                valueOccurrences[card.Value]++;
            }

            int numPairs = 0;

            foreach (int occurrences in valueOccurrences)
            {
                if (occurrences == 2)
                {
                    numPairs++;
                }
            }

            return numPairs;
        }
    }
}
