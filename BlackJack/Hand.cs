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
			RecalculateValue();
		}

		public int Value { get; set; }

		private void RecalculateValue() 
		{
			var newValue = 0;
			var acesLastHand = this.OrderBy(c => c.Rank.HighValue);
		
			foreach (var card in acesLastHand)
			{ 
				if((newValue + card.Rank.HighValue) >= 21)
				{
					newValue += card.Rank.LowValue;
				}
				else
				{
					newValue += card.Rank.LowValue;
				}
			}

			Value = newValue;
		}
	}
}
