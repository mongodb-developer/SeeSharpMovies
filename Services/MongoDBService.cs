using MongoDB.Driver;
using SeeSharpMovies.Models;
using System.Text;
using System.Text.Json;

namespace SeeSharpMovies.Services;

public class MongoDBService : IMongoDBService
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _mongoDatabase;
    private readonly IMongoCollection<Movie> _movies;
    private readonly string _openAPIKey;

    private readonly HttpClient _httpClient = new HttpClient();

    public MongoDBService(MongoDBSettings settings, string openAPIKey)
    {
        _client = new MongoClient(settings.AtlasURI);
        _mongoDatabase = _client.GetDatabase(settings.DatabaseName);
        _movies = _mongoDatabase.GetCollection<Movie>("embedded_movies");
        _openAPIKey = openAPIKey;

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
        var movie = _movies.Find(restaurant => restaurant.Id.ToString() == id).FirstOrDefault();

        return movie;
    }

    public IEnumerable<Movie> MovieSearch(string textToSearch)
    {

        var vector = GetEmbeddingsFromText(textToSearch).Result.ToArray();

        var vectorOptions = new VectorSearchOptions<Movie>()
        {
            IndexName = "vector_index",
            NumberOfCandidates = 150
        };

        var movies = _movies.Aggregate()
            .VectorSearch(movie => movie.PlotEmbedding, vector, 150, vectorOptions)
            .Project<Movie>(Builders<Movie>.Projection
            .Include(m => m.Title)
            .Include(m => m.Plot))
            .ToList();

        return movies;
    }

    private async Task<List<double>> GetEmbeddingsFromText(string text)
    {


        Dictionary<string, object> body = new Dictionary<string, object>
        {
            { "model", "text-embedding-ada-002" },
            { "input", text }
        };


        _httpClient.BaseAddress = new Uri("https://api.openai.com");
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {_openAPIKey}");

        string requestBody = JsonSerializer.Serialize(body);
        StringContent requestContent =
            new StringContent(requestBody, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("/v1/embeddings", requestContent)
            .ConfigureAwait(false);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            EmbeddingResponse embeddingResponse = JsonSerializer.Deserialize<EmbeddingResponse>(responseBody);
            return embeddingResponse.data[0].embedding;
        }

        return new List<double>();
    }
}
