using MovieStoreB.Models.DTO;

namespace MovieStoreB.DL.DB
{
    internal class StaticData
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                ID = 1, Title = "The Shawshank Redemption"
            },
            new Movie
            { ID = 2,Title = "The Godfather",
            },
        };   
    }
}
