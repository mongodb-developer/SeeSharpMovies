using SeeSharpMovies.Models;
using MongoDB.Driver;

namespace SeeSharpMovies.Services;

public class MongoDBService : IMongoDBService
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _mongoDatabase;
    private readonly IMongoCollection<Movie> _movies;

    public MongoDBService(MongoDBSettings settings)
    {
        _client = new MongoClient(settings.AtlasURI);
        _mongoDatabase = _client.GetDatabase(settings.DatabaseName);
        _movies = _mongoDatabase.GetCollection<Movie>("movies");
    }

    public MongoDBService()
    {
           
    }
    public IEnumerable<Movie> GetAllMovies()
    {
        var movies = _movies.Find(movie => true).ToList();

        return movies;
    }

    public IEnumerable<Movie> GetMoviesPerPage(int pageNumber, int pageSize)
    {
        var movies = _movies.Find(movie => true)
            .Skip((pageNumber - 1) * pageSize)
            .Limit(pageSize).ToList();

        return movies;
    }

    public Movie? GetMovieById(string id)
    {
        var movie = _movies.Find(restaurant => restaurant.Id == id).FirstOrDefault();

        return movie;
    }       
}
