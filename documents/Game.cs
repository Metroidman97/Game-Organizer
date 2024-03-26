namespace Game_Organizer.Models
{
    public class Game
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Genre { get; set; }
        public String Rating { get; set; }
        public String Platform { get; set; }
        public float MetacriticScore { get; set; }
        public String Developer { get; set; }
        public String Publisher { get; set; }
        public String ReleaseDate { get; set; }
        public String Franchise { get; set; }

        public Game(int id, string title, string genre, string rating, string platform, float metacriticScore, string developer, string publisher, string releaseDate, string franchise)
        {
            Id = id;
            Title = title;
            Genre = genre;
            Rating = rating;
            Platform = platform;
            MetacriticScore = metacriticScore;
            Developer = developer;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Franchise = franchise;
        }


        public static List<Game> GetGames() => new List<Game>
        {
            new Game( 142, "Super Mario Galaxy", "Platfomer", "E", "Wii", 97, "Nintendo", "Nintendo", "11/12/07", "Super Mario Bros"),
            new Game( 426, "Metroid Prime", "Metroidvania", "T", "GameCube", 97, "Retro Studios", "Nintendo", "11/17/02", "Metroid"),
            new Game(728, "Deep Rock Galactic", "First Person Shooter", "M", "PC", 85, "Ghost Ship Games", "Coffee Stain Publishing", "05/13/2020", "Deep Rock Galactic")
        };
    }
}
