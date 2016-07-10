
namespace BlackJack
{
	public interface IPlayer
	{
		string Name { get; set; }
		Hand Hand { get; set; }

		int Points { get; set; }
	}
}
