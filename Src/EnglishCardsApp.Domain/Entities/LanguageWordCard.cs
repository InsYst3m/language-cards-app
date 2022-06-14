namespace EnglishCardsApp.Domain.Entities
{
    public class LanguageWordCard
    {
        public long Id { get; set; }

        public LanguageWordCard(string title, string word, string transcription)
        {
            Title = title;
            Word = word;
            Transcription = transcription;
        }

        public string Title { get; set; }
        public string Word { get; set; }
        public string Transcription { get; set; }
    }
}