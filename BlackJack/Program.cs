using PlayingCards;
using System;
using System.Collections.Generic;

namespace BlackJack
{
	class Program
	{
		static void Main(string[] args)
		{
			var deck = new Deck();
			var dealer = new Dealer(deck);
			Console.WriteLine("Welcome to BlackJack!");
			Console.WriteLine("Please enter your name:");

			var playerName = Console.ReadLine();
			Console.WriteLine("Welcome " + playerName);
			Console.WriteLine("Let's Play!!");
			Console.WriteLine("Commands: ");
			Console.WriteLine("type hit to hit");
			Console.WriteLine("type hold to hold");
			Console.WriteLine("asterisk (*) represent face down cards");

			var players = new List<IPlayer>();
			players.Add(new Player() { Name = playerName });

			dealer.Deal(players);

			Console.WriteLine(dealer.Name + "'s Hand: {0} | {1}", dealer.Hand[0].Name, dealer.Hand[1].Name);
			foreach(var player in players)
			{
				Console.WriteLine(player.Name + "'s Hand: {0} | {1}", player.Hand[0].Name, player.Hand[1].Name);
			}

			Console.ReadLine();
		}
	}
}
