using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using ThirdParty.Json.LitJson;

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

    [BsonElement("rated")]
    public string? Rated { get; set; }

    [BsonElement("lastupdated")]
    public string Lastupdated { get; set; }


    [BsonElement("year")]
    // There is an inconsistent typing of data in the documents so setting as object and will require parsing at use.
    public object Year { get; set; }

    [BsonElement("imdb")]
    public Imdb Imdb { get; set; }

    [BsonElement("countries")]
    public List<string> Countries { get; set; }

    [BsonElement("type")]
    public string Type { get; set; }

    [BsonElement("tomatoes")]
    public Tomatoes Tomatoes { get; set; }

    [BsonElement("metacritic")]
    public int? Metacritic { get; set; }

    [BsonElement("awesome")]
    public bool? Awesome { get; set; }
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
    [BsonElement("id")]    
    public object ImdbId { get; set; }

    [BsonElement("votes")]
    public object Votes { get; set; }

    [BsonElement("rating")]
    public object Rating { get; set; }
}

public class Tomatoes
{
    [BsonElement("viewer")]
    public Viewer Viewer { get; set; }

    [BsonElement("lastUpdated")]
    public DateTime LastUpdated { get; set; }

    [BsonElement("dvd")]
    public DateTime? DVD { get; set; }

    [BsonElement("website")]
    public string? Website { get; set; }

    [BsonElement("production")]
    public string? Production { get; set; }

    [BsonElement("critic")]
    public Critic? Critic { get; set; }

    [BsonElement("rotten")]
    public int? Rotten { get; set; }

    [BsonElement("fresh")]
    public int? Fresh { get; set; }

    [BsonElement("boxOffice")]
    public string? BoxOffice { get; set; }

    [BsonElement("consensus")]
    public string? Consensus { get; set; }

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

public class Critic
{
    [BsonElement("rating")]
    public double Rating { get; set; }

    [BsonElement("numReviews")]
    public int NumReviews { get; set; }

    [BsonElement("meter")]
    public int Meter { get; set; }
}