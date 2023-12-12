using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace SeeSharpMovies.Models;

public class Movie
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("plot")]
    public string Plot { get; set; }

    [BsonElement("genres")]
    public List<string> Genres { get; set; }

    [BsonElement("runtime")]
    public int Runtime { get; set; }

    [BsonElement("cast")]
    public List<string> Cast { get; set; }

    [BsonElement("num_mflix_comments")]
    public int NumMflixComments { get; set; }

    [BsonElement("poster")]
    public string Poster { get; set; }

    [BsonElement("title")]
    public string Title { get; set; }

    [BsonElement("fullplot")]
    public string Fullplot { get; set; }

    [BsonElement("languages")]
    public List<string> Languages { get; set; }

    [BsonElement("released")]
    public DateTime Released { get; set; }

    [BsonElement("directors")]
    public List<string> Directors { get; set; }

    [BsonElement("writers")]
    public List<string> Writers { get; set; }

    [BsonElement("awards")]
    public Awards Awards { get; set; }

    [BsonElement("lastupdated")]
    public string Lastupdated { get; set; }

    [BsonElement("year")]
    public int Year { get; set; }

    [BsonElement("imdb")]
    public Imdb Imdb { get; set; }

    [BsonElement("countries")]
    public List<string> Countries { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("tomatoes")]
    public Tomatoes Tomatoes { get; set; }
}

public class Awards
{
    [BsonElement("wins")]
    public int Wins { get; set; }

    [BsonElement("nominations")]
    public int Nominations { get; set; }

    [BsonElement("text")]
    public string Text { get; set; }
}

public class Imdb
{
    [BsonElement("rating")]
    public double Rating { get; set; }

    [BsonElement("votes")]
    public int Votes { get; set; }

    [BsonElement("id")]
    public int Id { get; set; }
}

public class Tomatoes
{
    [BsonElement("viewer")]
    public Viewer Viewer { get; set; }

    [BsonElement("lastUpdated")]
    public DateTime LastUpdated { get; set; }
}

public class Viewer
{
    [BsonElement("rating")]
    public double Rating { get; set; }

    [BsonElement("numReviews")]
    public int NumReviews { get; set; }

    [BsonElement("meter")]
    public int Meter { get; set; }
}