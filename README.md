# SeeSharpMovies

This is a Blazor app which is intended to show how to use the [MongoDB C# Driver](https://mdb.link/csharp-driver-docs) with a full-stack C# app.

### Running the app locally

This app can be cloned and runned locally by anyone.

### Prerequisites

1. [.NET 8](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) - the current latest version of .NET.
2. MongoDB Atlas Account with the free-forever [M0 tier cluster](https://mdb.link/deploy-free-cluster) deployed.
3. The [sample data](https://mdb.link/load-sample-data) loaded into your cluster.
4. The [connection string](https://mdb.link/getting-your-connection-string) for your cluster.

### Running the app

1. Fork the repo and clone to your machine.
2. Add your connection string to ```appsettings.json``` and ```appsettings.Development.json```.

How you then run it is up to you, either through an IDE such as Visual Studio or from the .NET CLI using ```dotnet run```.

## Disclaimer

Use at your own risk; not a supported MongoDB product