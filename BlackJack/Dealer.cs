using PlayingCards;
using System.Collections.Generic;

namespace BlackJack
{
	public class Dealer: IPlayer
	{
		private Deck _Deck;

		public Dealer(Deck deck) 
		{
			this._Deck = deck;
			this.Hand = new Hand();
		}

		public Hand Hand { get; set; }

		public void StartGame()
		{
			this._Deck.Shuffle();
		}

		public void Deal(IEnumerable<IPlayer> players) 
		{
			DealPlayer(this);

			foreach (var player in players) 
			{
				DealPlayer(player);
			}
		}

		public void Hit(IPlayer player)
		{
			player.Hand.Add(this._Deck.DrawCard(true));
		}

		private void DealPlayer(IPlayer player)
		{
			var faceDownCard = this._Deck.DrawCard(false);
			var faceUpCard = this._Deck.DrawCard(true);

			player.Hand.Add(faceUpCard);
			player.Hand.Add(faceDownCard);
		}
	}
}
