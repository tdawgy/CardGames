using PlayingCards;
using System.Collections.Generic;

namespace BlackJack
{
	public class Dealer
	{
		private Deck _Deck;

		private Hand _Hand;

		public Dealer(Deck deck) 
		{
			this._Deck = deck;
			this._Hand = new Hand();
		}

		public void StartGame()
		{
			this._Deck.Shuffle();
		}

		public void Deal(IEnumerable<Player> players) 
		{
		}
	}
}
