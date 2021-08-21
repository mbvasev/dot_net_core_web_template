using Movies.Domain.Data.Managers;
using Movies.Domain.Enums;
using Movies.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Domain.Data.Managers
{
    internal sealed class DataFacade
    {
        private readonly string _dbConnectionString;
        private MovieDataManager _movieDataManager;

        private MovieDataManager MovieDataManager { get { return _movieDataManager ?? (_movieDataManager = new MovieDataManager(_dbConnectionString)); } }

        public DataFacade(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
        }

        public Task<int> CreateMovie(Movie movie)
        {
            return MovieDataManager.CreateMovie(movie);
        }

        public Task<Movie> GetMovieById(int id)
        {
            return MovieDataManager.GetMovieById(id);
        }

        public Task<IEnumerable<Movie>> GetMovieByGenre(Genre genre)
        {
            return MovieDataManager.GetMovieByGenre(genre);
        }

        public Task<IEnumerable<Movie>> GetAllMovies()
        {
            return MovieDataManager.GetAllMovies();
        }
    }
}
