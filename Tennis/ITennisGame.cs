namespace Tennis
{
    public interface ITennisGame
    {
        void WonPoint(string playerName);
        string GetScore();
        void SetLanguage(ILanguageTranslator translator);
    }
}

