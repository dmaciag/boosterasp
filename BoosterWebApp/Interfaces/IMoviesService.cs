using BoosterWebApp.Models;
using BoosterWebApp.Models.Args;

namespace BoosterWebApp.Interfaces
{
    public interface IMoviesService
    {
        IList<Movie> SearchMovies(MovieSearchArgs args);
    }
}
