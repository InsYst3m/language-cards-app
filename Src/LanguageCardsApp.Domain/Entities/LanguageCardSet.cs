namespace LanguageCardsApp.Domain.Entities
{
    public class LanguageCardSet
    {
        public LanguageCardSet(string title, Languages language)
        {
            Title = title;
            Language = language;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public Languages Language { get; set; }

        public IList<LanguageWordCard> LanguageCards { get; set; } = new List<LanguageWordCard>();
        public IList<LanguageRuleCard> LanguageRuleCard { get; set; } = new List<LanguageRuleCard>();
    }

    public enum Languages : short
    {
        English = 0
    }
}