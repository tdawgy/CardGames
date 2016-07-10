using PlayingCards.Cards;
using System.Collections.Generic;

namespace PlayingCards
{
	public class Suits : List<Suit>
	{
		public Suits()
		{
			this.LoadSuits();
		}

		private void LoadSuits()
		{
			this.Add(new Suit("Club", Color.Black));
			this.Add(new Suit("Spade", Color.Black));
			this.Add(new Suit("Diamond", Color.Red));
			this.Add(new Suit("Heart", Color.Red));
		}
	}
}
