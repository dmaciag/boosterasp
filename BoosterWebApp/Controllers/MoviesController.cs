using BoosterWebApp.Interfaces;
using BoosterWebApp.Models;
using BoosterWebApp.Models.Args;
using Microsoft.AspNetCore.Mvc;

namespace BoosterWebApp.Controllers
{
    [Route("movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMoviesService _moviesService;
        private IMoviesRepository _moviesRepository;
        public MoviesController(IMoviesService moviesService, IMoviesRepository moviesRepository) {
            _moviesService = moviesService;
            _moviesRepository = moviesRepository;
        }

        [HttpGet("search")]
        public IList<Movie> SearchMovies([FromQuery] MovieSearchArgs args)
        {
            var movies = _moviesService.SearchMovies(args);

            return movies;
        }

        [HttpGet("save-search")]
        public ActionResult SaveMovies(MovieSearchArgs args)
        {
            _moviesRepository.SaveMovieSearch(args);
            return Ok(200);
        }
    }
}
