using PlayingCards.Cards;
using System.Collections.Generic;

namespace PlayingCards
{
	public class Ranks : List<Rank>
	{
		public Ranks()
		{
			LoadRanks();
		}

		private void LoadRanks()
		{
			this.Add(new Rank("One", 1));
			this.Add(new Rank("Two", 2));
			this.Add(new Rank("Three", 3));
			this.Add(new Rank("Four", 4));
			this.Add(new Rank("Five", 5));
			this.Add(new Rank("Six", 6));
			this.Add(new Rank("Seven", 7));
			this.Add(new Rank("Eight", 8));
			this.Add(new Rank("Nine", 9));
			this.Add(new Rank("Ten", 10));
			this.Add(new Rank("Jack", 10));
			this.Add(new Rank("Queen", 10));
			this.Add(new Rank("King", 10));
			this.Add(new Rank("Ace", 1, 11));
		}
	}
}
