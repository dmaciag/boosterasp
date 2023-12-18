using BoosterWebApp.Interfaces;
using BoosterWebApp.Models.Args;
using BoosterWebApp.Models;
using BoosterWebApp.Enums;

namespace BoosterWebApp.Repositories
{
    public class MoviesRepository : IMoviesRepository
    {
        public MoviesRepository() { }

        public IList<Movie> GetMoviesFromDb(MovieDbArgs args)
        {
            var movies = new List<Movie>
            {
                new Movie()
                {
                    Title = "Superman",
                    VoteCount = 123123,
                    Rating = 9.2M,
                    Genres = new List<string>() { Genre.SciFi, Genre.Action },
                    Description = "cos tam o supermenie",
                    Id = 0,
                    ImdbId = "imdb-0"
                },
                new Movie()
                {
                    Title = "Batman",
                    VoteCount = 225465,
                    Rating = 5.9M,
                    Genres = new List<string>() { Genre.SciFi, Genre.Action, Genre.Thriller },
                    Description = "cos tam o batmanie",
                    Id = 1,
                    ImdbId = "imdb-1"
                },
                new Movie()
                {
                    Title = "Inception",
                    VoteCount = 708945,
                    Rating = 8.5M,
                    Genres = new List<string>() { Genre.Thriller, Genre.Action },
                    Description = "jakis fajny film",
                    Id = 2,
                    ImdbId = "imdb-2"
                },
                new Movie()
                {
                    Title = "Barnie",
                    VoteCount = 649210,
                    Rating = 7.6M,
                    Genres = new List<string>() { Genre.Comedy, Genre.Kids },
                    Description = "film dla dzieci",
                    Id = 3,
                    ImdbId = "imdb-3"
                }
            };

            return movies;
        }

        public void SaveMovieSearch(MovieSearchArgs args)
        {
            //todo trzeba wpisac do databasy
        }
    }
}
