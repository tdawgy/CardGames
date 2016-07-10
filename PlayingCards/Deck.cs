using PlayingCards.Cards;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCards
{
	public class Deck
	{
		private Stack<Card> _Cards;
		private Random _Random;

		public Deck()
		{
			this._Random = new Random(Guid.NewGuid().GetHashCode());

			this.Build();
		}

		public void Shuffle()
		{
			var cardList = this._Cards.ToList();

			for (var i = 0; i < this._Cards.Count(); i++)
			{
				var destination = this._Random.Next();
				var card = cardList[destination];

				cardList[destination] = cardList[i];
				cardList[i] = card;
			}

			this._Cards = new Stack<Card>(cardList);
		}

		public Card DrawCard(bool isFaceUp)
		{
			var drawnCard = this._Cards.Pop();
			drawnCard.IsFaceUp = isFaceUp;

			return drawnCard;
		}

		private void Build(int numberOfDecks = 1)
		{
			var numberOfCards = numberOfDecks * 52;
			this._Cards = new Stack<Card>();

			var suits = new Suits();
			var ranks = new Ranks();
			for (var i = 0; i < numberOfDecks; i++)
			{
				suits.SelectMany(s => ranks, (s, r) => new Card(s, r, false));
			}
		}
	}
}
