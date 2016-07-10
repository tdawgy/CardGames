using PlayingCards.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
	public class Deck
	{
		private List<Card> _Cards;
		private Random _Random;

		public Deck()
		{
			this._Random = new Random(Guid.NewGuid().GetHashCode());

			this.Build();
			this.Shuffle();
		}

		private void Shuffle()
		{
			for (var i = 0; i < this._Cards.Count; i++)
			{
				var destination = this._Random.Next();

				var card = this._Cards[destination];
				this._Cards[destination] = this._Cards[i];
				this._Cards[i] = card;
			}
		}

		private void Build(int numberOfDecks = 1)
		{
			this._Cards = new List<Card>();

			var suits = new Suits();
			var ranks = new Ranks();
			for (var i = 0; i < numberOfDecks; i++)
			{
				suits.SelectMany(s => ranks, (s, r) => new Card(s, r, false));
			}
		}
	}
}
