
namespace PlayingCards.Cards
{
	public class Suit
	{
		public Suit(string name, Color color)
		{
			this.Name = name;
			this.Color = color;
		}

		public string Name { get; set; }

		public Color Color { get; set; }
	}
}
