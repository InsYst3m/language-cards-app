namespace LanguageCardsApp.Domain.Entities
{
    public class LanguageRuleCard
    {
        public LanguageRuleCard(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public long Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}