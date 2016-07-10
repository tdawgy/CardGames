
namespace PlayingCards.Cards
{
	public class Card
	{
		private Suit _Suit;
		private Rank _Rank;

		public Card(Suit suit, Rank rank, bool isFaceUp)
		{
			this._Suit = suit;
			this._Rank = rank;
			this.IsFaceUp = isFaceUp;
		}

		public Suit Suit
		{
			get { return _Suit; }
		}

		public Rank Rank
		{
			get { return _Rank; }
		}

		public bool IsFaceUp { get; set; }
	}
}
