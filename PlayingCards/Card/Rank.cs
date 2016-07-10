
namespace PlayingCards.Card
{
	public class Rank
	{
		public Rank(string name, int lowValue, int highValue = 0)
		{
			this.Name = name;
			this.HighValue = highValue;
			this.LowValue = lowValue;
		}

		public string Name { get; set; }

		public int HighValue { get; set; }

		public int LowValue { get; set; }
	}
}
