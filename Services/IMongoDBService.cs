using SeeSharpMovies.Models;
using MongoDB.Driver;

namespace SeeSharpMovies.Services
{
    public interface IMongoDBService
    {      
        public IEnumerable<Movie> GetAllMovies();

        public IEnumerable<Movie> GetMoviesPerPage(int pageNumber, int pageSize);

        public Movie? GetMovieById(string id);

        public IEnumerable<Movie> MovieSearchByText (string textToSearch);
    }
}
