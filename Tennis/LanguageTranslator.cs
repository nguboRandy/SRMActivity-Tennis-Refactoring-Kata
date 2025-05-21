namespace Tennis
{
    public interface ILanguageTranslator
    {
        string TranslateScore(int score);
        string TranslateAll();
        string TranslateDeuce();
        string TranslateAdvantage(string playerName);
        string TranslateWin(string playerName);
    }

    public class EnglishTranslator : ILanguageTranslator
    {
        private static readonly string[] Scores = { "Love", "Fifteen", "Thirty", "Forty" };

        public string TranslateScore(int score) => Scores[score];
        public string TranslateAll() => "All";
        public string TranslateDeuce() => "Deuce";
        public string TranslateAdvantage(string playerName) => $"Advantage {playerName}";
        public string TranslateWin(string playerName) => $"Win for {playerName}";
    }

    public class FrenchTranslator : ILanguageTranslator
    {
        private static readonly string[] Scores = { "Zéro", "Quinze", "Trente", "Quarante" };

        public string TranslateScore(int score) => Scores[score];
        public string TranslateAll() => "Égalité";
        public string TranslateDeuce() => "Égalité";
        public string TranslateAdvantage(string playerName) => $"Avantage {playerName}";
        public string TranslateWin(string playerName) => $"Victoire pour {playerName}";
    }

    public class SpanishTranslator : ILanguageTranslator
    {
        private static readonly string[] Scores = { "Cero", "Quince", "Treinta", "Cuarenta" };

        public string TranslateScore(int score) => Scores[score];
        public string TranslateAll() => "Igual";
        public string TranslateDeuce() => "Deuce";
        public string TranslateAdvantage(string playerName) => $"Ventaja {playerName}";
        public string TranslateWin(string playerName) => $"Gana {playerName}";
    }
}