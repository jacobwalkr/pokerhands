namespace PokerHands
{
    class Card
    {
        public int Value { get; private set; }
        public char Suit { get; private set; }

        public Card(int _value, char _suit)
        {
            this.Value = _value;
            this.Suit = _suit;
        }
    }
}
