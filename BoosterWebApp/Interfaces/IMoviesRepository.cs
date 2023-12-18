using BoosterWebApp.Models;
using BoosterWebApp.Models.Args;

namespace BoosterWebApp.Interfaces
{
    public interface IMoviesRepository
    {
        IList<Movie> GetMoviesFromDb(MovieDbArgs args);

        void SaveMovieSearch(MovieSearchArgs args);
    }
}
