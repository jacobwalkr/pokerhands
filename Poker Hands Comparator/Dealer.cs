using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Hands_Comparator
{
    class Dealer
    {
        public string GetValidHandOrDieTrying()
        {
            while (true)
            {
                string hand = this.promptForHand();

                if (this.validateHand(hand))
                {
                    this.thankUser();
                    return this.sanitiseHand(hand);
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
            throw new NotImplementedException();
        }

        private string sanitiseHand(string hand)
        {
            throw new NotImplementedException();
        }
    }
}
