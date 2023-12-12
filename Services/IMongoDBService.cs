using SeeSharpMovies.Models;
using MongoDB.Driver;

namespace SeeSharpMovies.Services
{
    public interface IMongoDBService
    {      
        public IEnumerable<Movie> GetAllMovies();

        public Movie? GetMovieById(string id);
        
    }
}
