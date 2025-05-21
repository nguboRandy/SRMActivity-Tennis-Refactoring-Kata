using System;

namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TennisGame1("player1", 
                "player2");

            game.WonPoint("Player1");
            Console.WriteLine(game.GetScore());

            game.WonPoint("Player2");
            Console.WriteLine(game.GetScore());

            Console.ReadKey();
        }
    }
}