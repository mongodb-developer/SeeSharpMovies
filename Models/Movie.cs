using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SeeSharpMovies.Models;


public class Movie
{
   [BsonId]
   [BsonElement("_id")]
   public ObjectId Id { get; set; }
   
   [BsonElement("plot")]
   public string Plot { get; set; }

   [BsonElement("genres")]  
   public string[] Genres { get; set; }

   [BsonElement("runtime")]
   public int Runtime { get; set; }

   [BsonElement("cast")]
   public string[] Cast { get; set; }

   [BsonElement("num_mflix_comments")]
   public int NumMflixComments { get; set; }

   [BsonElement("poster")]
   public string Poster { get; set; }

   [BsonElement("title")]
   public string Title { get; set; }

   [BsonElement("fullplot")]
   public string FullPlot { get; set; }

   [BsonElement("languages")]
   public string[] Languages { get; set; }

   [BsonElement("directors")]
   public string[] Directors { get; set; }

   [BsonElement("writers")]
   public string[] Writers { get; set; }

   [BsonElement("awards")]
   public Awards Awards { get; set; }
   
   [BsonElement("year")]
   public string Year { get; set; }

   [BsonElement("imdb")]
   public Imdb Imdb { get; set; }

   [BsonElement("countries")]
   public string[] Countries { get; set; }

   [BsonElement("type")]
   public string Type { get; set; }

   [BsonElement("plot_embedding")]
   public float[] PlotEmbedding { get; set; }

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
   public float Rating { get; set; }
   
   [BsonElement("votes")]
   public int Votes { get; set; }
   
   [BsonElement("id")]
   public int Id { get; set; }
}


