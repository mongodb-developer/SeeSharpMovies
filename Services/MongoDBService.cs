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
        return _movies.Find(movie => true).ToList();
    }

    public Movie? GetMovieById(string id)
    {
        return _movies.Find(restaurant => restaurant.Id == id).FirstOrDefault();
    }       
}
