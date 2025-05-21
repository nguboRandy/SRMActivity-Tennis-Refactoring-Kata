using System;

namespace Tennis
{
    public class TennisGame : ITennisGame
    {
        private int firstPlayerScore;
        private int secondPlayerScore;
        private readonly string firstPlayerName;
        private readonly string secondPlayerName;
        private ILanguageTranslator translator;

        public TennisGame(string firstPlayerName, string secondPlayerName)
        {
            this.firstPlayerName = firstPlayerName;
            this.secondPlayerName = secondPlayerName;
            this.translator = new EnglishTranslator();
        }

        public void SetLanguage(ILanguageTranslator translator)
        {
            this.translator = translator ?? throw new ArgumentNullException(nameof(translator));
        }

        public void WonPoint(string playerName)
        {
            if (playerName == firstPlayerName)
                firstPlayerScore++;
            else if (playerName == secondPlayerName)
                secondPlayerScore++;
            else
                throw new ArgumentException("Invalid player name.");
        }

        public string GetScore()
        {
            if (IsTie())
                return FormatTieScore();
            if (IsEndGame())
                return FormatEndGameScore();
            return FormatRegularScore();
        }

        private bool IsTie() => firstPlayerScore == secondPlayerScore;

        private bool IsEndGame() => firstPlayerScore >= 4 || secondPlayerScore >= 4;

        private string FormatTieScore()
        {
            if (firstPlayerScore >= 3)
                return translator.TranslateDeuce();
            return $"{translator.TranslateScore(firstPlayerScore)}-{translator.TranslateAll()}";
        }

        private string FormatEndGameScore()
        {
            int scoreDifference = firstPlayerScore - secondPlayerScore;
            string leadingPlayer = scoreDifference > 0 ? firstPlayerName : secondPlayerName;

            return scoreDifference switch
            {
                1 or -1 => translator.TranslateAdvantage(leadingPlayer),
                >= 2 => translator.TranslateWin(firstPlayerName),
                <= -2 => translator.TranslateWin(secondPlayerName),
                _ => throw new InvalidOperationException("Invalid end-game score state.")
            };
        }

        private string FormatRegularScore()
        {
            return $"{translator.TranslateScore(firstPlayerScore)}-{translator.TranslateScore(secondPlayerScore)}";
        }
    }
}