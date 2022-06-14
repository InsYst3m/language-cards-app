namespace LanguageCardsApp.Domain.Entities
{
    public class User
    {
        public User(string email)
        {
            Email = email;
        }

        public long Id { get; set; }
        public string Email { get; set; }
        public string? Username { get; set; }

        public IList<LanguageCardSet> CardSets { get; set; } = new List<LanguageCardSet>();
    }
}
