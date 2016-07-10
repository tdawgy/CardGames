using PlayingCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
	public class GameEngine
	{
		private Dealer _Dealer;
		private IEnumerable<Player> _Players;

		public GameEngine(string playerName)
		{
			this._Players = new List<Player>() { 
				new Player() { Name = playerName } 
			};
		}

		public void StartGame()
		{
			var deck = new Deck();
			_Dealer = new Dealer(deck);

			_Dealer.Deal(_Players);
			WritePlayerHand(_Dealer, true);

			foreach (var player in _Players)
			{
				WritePlayerHand(player, false);
			}

			foreach (var player in _Players)
			{
				PlayersTurn(player);
			}
			
			_Dealer.TakeTurn(_Players);

			WritePlayerHand(_Dealer, true);
			
			Console.WriteLine("press a key to exit");
			Console.ReadKey();
		}

		private void PlayersTurn(Player player) 
		{
			while (Console.ReadKey(true).Key.ToString() == "D1" && player.Hand.Value < 21)
			{
				_Dealer.Hit(player);
				WritePlayerHand(player, false);
			}
		}

		private void WritePlayerHand(IPlayer player, bool onlyTurnedUp)
		{
			IEnumerable<string> cardNames; 

			if (onlyTurnedUp)
			{
				cardNames = player.Hand.Select(card => card.IsFaceUp ? "|" + card.Name + "| " : "??");
			}
			else
			{
				cardNames = player.Hand.Select(card => "|" + card.Name + "| ");
			}
					
			Console.WriteLine(player.Name + "'s Hand ({0}): {1}", player.Hand.Value, string.Join("", cardNames));
			if (player.Hand.Value > 21)
			{
				Console.WriteLine(player.Name + " Busted!!");
			}
		}
	}
}
