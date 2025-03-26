using modul6_103022300035;

class Program
{
    static void Main()
    {
        try
        {
            string username = "Bagas Pratama";
            SayaTubeUser user = new SayaTubeUser(username);
            String[] filmList =
            {
            "Interstellar",
            "Inception",
            "The Dark Knight",
            "Parasite",
            "Avengers: Endgame",
            "Whisplash",
            "The Matrix",
            "Spirited Away",
            "The godfather",
            "Shawshank redemption"
        };

            foreach (string film in filmList)
            {
                user.addVideo(new SayaTubeVideo($"Review film {film} oleh {username}"));
            }
            ;

            user.printAllVideoPlaycount();
        } catch (Exception e)
        {
            Console.WriteLine($"Terjadi error: {e.Message}");
        }
        
    }
}