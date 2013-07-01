using System;
using System.Collections.Generic;
using PokerHands.HandType;

namespace PokerHands
{
    partial class Hand : List<Card>
    {
        public HandType.HandType Type { get; private set; }

        public Hand(List<Card> cardList)
        {
            if (cardList.Count != 5)
            {
                throw new ArgumentException("A hand must consist of 5 cards.");
            }

            this.AddRange(cardList);
            this.Sort(this.compareCards);
            this.Type = this.Score();
        }

        private int compareCards(Card first, Card second)
        {
            return second.Value - first.Value;
        }

        public Hand.ComparisonOutcome CompareTo(Hand otherHand)
        {
            if (this.Type.Rank < otherHand.Type.Rank)
            {
                return Hand.ComparisonOutcome.Lose;
            }
            else if (this.Type.Rank > otherHand.Type.Rank)
            {
                return Hand.ComparisonOutcome.Win;
            }
            else // The hands are both of the same type
            {
                Console.Write("Both hands are the same type");
                return Hand.ComparisonOutcome.Draw;
                //return thisHandScore.CompareToSimilar(otherHandScore);
            }
        }

        public static Hand ConstructFromSanitisedInput(string validatedHandString)
        {
            List<Card> cardList = new List<Card>();

            for (int key = 0; key < 5; key++)
            {
                int cursor = key * 2;
                string cardString = validatedHandString.Substring(cursor, 2);

                char[] cardAsCharArray = cardString.ToCharArray();

                char valueChar = cardAsCharArray[0];
                int value = 0;

                if (char.IsLetter(valueChar))
                {
                    switch (valueChar)
                    {
                        case 'T':
                            value = 10;
                            break;
                        case 'J':
                            value = 11;
                            break;
                        case 'Q':
                            value = 12;
                            break;
                        case 'K':
                            value = 13;
                            break;
                        case 'A':
                            value = 14;
                            break;
                    }
                }
                else
                {
                    value = int.Parse(valueChar.ToString());
                }

                char suit = cardAsCharArray[1];

                cardList.Add(new Card(value, suit));
            }

            return new Hand(cardList);
        }
    }
}
