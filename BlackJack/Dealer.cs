using PlayingCards;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
	public class Dealer : IPlayer
	{
		private Deck _Deck;

		public Dealer(Deck deck)
		{
			this.Name = "Dealer";
			this._Deck = deck;
			this.Hand = new Hand();
		}

		public Hand Hand { get; set; }
		public string Name { get; set; }

		public void Deal(IEnumerable<IPlayer> players)
		{
			_Deck.Shuffle();
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

		public void TakeTurn(IEnumerable<IPlayer> players)
		{
			var maxUnbustedValue = players
				.Where(p => p.Hand.Value <= 21)
				.Max(p => p.Hand.Value);

			while(Hand.Value < 17)
			{
				Hit(this);
			}

			while (Hand.HasHighAce && Hand.Value < 18)
			{
				Hit(this);
			}
		
			while (maxUnbustedValue > Hand.Value)
			{
				Hit(this);
			}
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
