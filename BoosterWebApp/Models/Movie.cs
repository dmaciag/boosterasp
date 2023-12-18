using BoosterWebApp.Enums;

namespace BoosterWebApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public int VoteCount { get; set; }
        public decimal Rating { get; set; }
        public string Description { get; set; }
        public IList<string> Genres { get; set; }
    }
}
