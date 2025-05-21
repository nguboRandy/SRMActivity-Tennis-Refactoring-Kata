using System;

namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new TennisGame("Player One", "Player Two");

            Console.WriteLine("English Scores:");
            game.WonPoint("Player One");
            Console.WriteLine(game.GetScore());

            game.WonPoint("Player Two");
            Console.WriteLine(game.GetScore());

            game.WonPoint("Player One");
            Console.WriteLine(game.GetScore());

            game.SetLanguage(new FrenchTranslator());
            Console.WriteLine("\nFrench Scores:");
            Console.WriteLine(game.GetScore());

            game.SetLanguage(new SpanishTranslator());
            Console.WriteLine("\nSpanish Scores:");
            Console.WriteLine(game.GetScore());

            Console.ReadKey();
        }
    }
}