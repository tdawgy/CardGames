using PlayingCards;
using System;
using System.Collections.Generic;

namespace BlackJack
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to BlackJack!");
			Console.WriteLine("Please enter your name:");
			var playerName = Console.ReadLine();

			Console.WriteLine("Welcome " + playerName);
			Console.WriteLine("Let's Play!!");
			Console.WriteLine("question marks (??) represent face down cards");
			var gameEngine = new GameEngine(playerName);
			
			Console.WriteLine("1 to hit");
			Console.WriteLine("2 to hold");
			gameEngine.StartGame();
		}
	}
}