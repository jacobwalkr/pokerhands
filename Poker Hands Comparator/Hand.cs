using System;
using System.Collections.Generic;

namespace Poker_Hands_Comparator
{
    class Hand : List<Card>
    {
        private List<Card> cards;

        public Hand(List<Card> cardList)
        {
            if (cardList.Count != 5)
            {
                throw new ArgumentException("A hand must consist of 5 cards.");
            }

            this.cards = cardList;
        }

        public enum ComparisonOutcome
        {
            Win,
            Draw,
            Lose
        };

        public ComparisonOutcome CompareTo(Hand otherHand)
        {
            throw new NotImplementedException();
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
                byte value = new byte();

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
                    value = byte.Parse(valueChar.ToString());
                }

                char suit = cardAsCharArray[1];

                cardList.Add(new Card(value, suit));
            }

            return new Hand(cardList);
        }
    }
}
