using PlayingCards;
using PlayingCards.Cards;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
	public class Hand : List<Card>
	{
		public void Add(Card card)
		{
			base.Add(card);
		
			HasHighAce = false;
			RecalculateValue();
		}

		public int Value { get; set; }
		public bool HasHighAce { get; set; }

		private void RecalculateValue() 
		{
			var newValue = 0;
			var acesLast = this.OrderBy(c => c.Rank.HighValue);
		
			foreach (var card in acesLast)
			{ 
				if((newValue + card.Rank.HighValue) >= 21)
				{
					newValue += card.Rank.LowValue;
				}
				else
				{
					newValue += card.Rank.HighValue;
					HasHighAce = card.Rank.HighValue == 11 ? true : false;
				}
			}

			Value = newValue;
		}
	}
}
