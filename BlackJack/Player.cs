
namespace BlackJack
{
	public class Player: IPlayer
	{
		public Player()
		{
			this.Hand = new Hand();
		}

		public Hand Hand { get; set; }
		public string Name { get; set; }

		public int Points { get; set; }
	}
}
