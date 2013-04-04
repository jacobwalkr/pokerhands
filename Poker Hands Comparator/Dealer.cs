using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Poker_Hands_Comparator
{
    class Dealer
    {
        public Hand GetValidHandOrDieTrying()
        {
            while (true)
            {
                string hand = this.promptForHand();

                if (this.validateHand(hand))
                {
                    this.thankUser();
                    string sanitisedHand = this.sanitiseHand(hand);
                    List<Card> cardArray = this.convertHandToCardList(sanitisedHand);
                    return new Hand(cardArray);
                }

                this.chastiseUser();
            }
        }

        private string promptForHand()
        {
            Console.WriteLine("Enter hand");
            Console.Write("> ");
            return Console.ReadLine();
        }

        private void thankUser()
        {
            Console.WriteLine("A valid hand - thanks!");
            Console.WriteLine();
        }

        private void chastiseUser()
        {
            Console.WriteLine("That's not a valid hand and you know it. C'mon now.");
            Console.WriteLine();
        }

        private bool validateHand(string hand)
        {
            string validHandPattern = @"^([1-9TJQKA] *[CDHS] *){5}$";
            RegexOptions options = RegexOptions.IgnoreCase;

            Match match = Regex.Match(hand, validHandPattern, options);

            return match.Success;
        }

        private string sanitiseHand(string hand)
        {
            string handWithoutSpaces = hand.Replace(" ", string.Empty);
            return handWithoutSpaces.ToUpper();
        }

        private List<Card> convertHandToCardList(string hand)
        {
            List<Card> cardList = new List<Card>(5);

            for (int key = 0; key < 5; key++)
            {
                int cursor = key * 2;
                string cardString = hand.Substring(cursor, 2);

                char value = cardString.ToCharArray()[0];
                char suit = cardString.ToCharArray()[1];
                Card card = new Card(value, suit);
            }

            return cardList;
        }
    }
}
