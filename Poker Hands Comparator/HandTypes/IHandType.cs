using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHands.HandTypes
{
    interface IHandType
    {
        public int Score { get; private set; }
        public List<int> OrderedCardValues { get; private set; }
        public string ToString();
    }
}
