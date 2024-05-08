# See Sharp Movies

This repo is a Blazor application, used as a basis to show using the MongoDB C# driver with a full-stack .NET application. It uses the MongODB sample data's Sample_Mflix database and Movies collection.

It is made up of multiple branches that show a different feature.

## Main Branch
This is the base branch that displays the movies with pagination. It is most commonly used as the base branch for starting from when following tutorials written by me for the [MongoDB Developer Center](https://www.mongodb.com/developer/search/?s=luce+carter&sortMode=0).

## Full-Text-Search
This branch is an example of using Atlas Search, which is available as an aggregation stage in the C# driver. It searches against the title field of a movie, with fuzzy matching support for a difference of 1 character.

It is the end result of following the tutorial on [MongoDB Atlas Search with .NET Blazor for Full-Text Search](https://www.mongodb.com/developer/languages/csharp/atlas-search-with-csharp/).

## Vector-Search
This branch is an example of using Atlas Vector Search, which is also available as an aggregation stage in the C# driver. It uses the embedded_movies collection inside of Sample_Mflix, which contains a plot_embeddings field of vectors, generated against the plot field. This can be then be used as part of a vector search, to find movies who's plot is similar to the searched term.

It is the end result of following the tutorial on [Adding MongoDB Atlas Vector Search to a .NET Blazor C# Application](https://www.mongodb.com/developer/languages/csharp/vector-search-with-csharp-driver/).


## Running the application

You will need the following to run the application: 
* A MongoDB Atlas Cluster with the sample dataset loaded
* Your Connection String
* .NET 8

This app relies on settings added to application.json and application.development.json so you will need to add the following to your files:

```json
"MongoDBSettings": {
  "AtlasURI": "mongodb+srv://<username>:<password>@<cluster-url>/",
  "DatabaseName": "sample_mflix"
}
```

You can then start the application with

```bash
dotnet run
```

