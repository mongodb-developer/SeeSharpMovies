namespace SeeSharpMovies.Models
{
    public class EmbeddingResponse
    { 
        public string @object { get; set; }
        public List<Data> data { get; set; }
        public string model { get; set; }
        public Usage usage { get; set; }
    }

    public class Data
    {
        public string @object { get; set; }
        public int index { get; set; }
        public List<double> embedding { get; set; }
    }

    public class Usage
    {
        public int prompt_tokens { get; set; }
        public int total_tokens { get; set; }
    }
}