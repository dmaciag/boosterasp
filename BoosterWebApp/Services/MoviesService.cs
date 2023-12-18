using BoosterWebApp.Interfaces;
using BoosterWebApp.Models;
using BoosterWebApp.Models.Args;

namespace BoosterWebApp.Services
{
    public class MoviesService : IMoviesService
    {
        private IMoviesRepository _moviesRepository;

        public MoviesService(IMoviesRepository moviesRepository) {
            _moviesRepository = moviesRepository;
        }

        public IList<Movie> SearchMovies(MovieSearchArgs args)
        {
            var filter = new MovieDbArgs();
            var movies = _moviesRepository.GetMoviesFromDb(filter);

            return movies;
        }
    }
}
