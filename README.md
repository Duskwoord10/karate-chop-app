<p align="center">
    <img alt="Project Karate Logo" src="./karate_icon.png" width="200" height="200" />
</p>

# KarateChop Solution

This solution provides a binary search implementation (`KarateChop` class) and demonstrates its usage through a console application and an API. It also includes unit tests for validating the functionality.

## Projects

### 1. KarateChopDomain

The `KarateChopDomain` project contains the core logic of the binary search implementation.

#### Files:
- **KarateChop.cs**: Implements the `KarateChop` class with the binary search method.
- **karate_icon.png**: A placeholder image file.

### 2. KarateChopApp

The `KarateChopApp` project is a console application that demonstrates the usage of the `KarateChop` class.

#### Files:
- **Program.cs**: Contains the main method demonstrating the binary search on a sample array.

### 3. KarateChopApi

The `KarateChopApi` project is a minimal API that exposes the `KarateChop` class functionality via a RESTful API.

#### Files:
- **Program.cs**: Sets up the API endpoints and handles HTTP requests.
- **appsettings.json**: Configuration file for the API.
- **Dockerfile**: Instructions for building a Docker image for the API.
- **.dockerignore**: Specifies files and directories to be ignored by Docker.

### 4. KarateChopDomain.Tests

The `KarateChopDomain.Tests` project contains unit tests for the `KarateChop` class.

#### Files:
- **GlobalUsings.cs**: Contains global using directives for the test project.
- **KarateChopTests.cs**: Implements unit tests for the `KarateChop` class.

## Installation and Usage

### Console Application (KarateChopApp)

To run the console application:

1. Open a terminal and navigate to the `KarateChopApp` directory.
2. Run the following commands:

    ```sh
    dotnet build
    dotnet run
    ```

The console application will demonstrate the binary search on a sample array.

### API (KarateChopApi)

To run the API using Docker:

1. Build the Docker image:

    ```sh
    docker build -t karatechopapi:latest .
    ```

2. Run the Docker container:

    ```sh
    docker run -d -p 8080:8080 -p 8081:8081 --name karatechopapi karatechopapi:latest
    ```

#### Endpoints

- **Welcome Endpoint**: Check if the API is running by navigating to `http://localhost:8080/`.
- **Search Endpoint**: Perform a binary search by navigating to `http://localhost:8080/search?target=7&array=1,3,5,7,9,11,13,15`.

### Tests (KarateChopDomain.Tests)

To run the unit tests:

1. Open a terminal and navigate to the `KarateChopDomain.Tests` directory.
2. Run the following command:

    ```sh
    dotnet test
    ```

The test project will execute unit tests to validate the functionality of the `KarateChop` class.

## KarateChopDomain - NuGet Package

The project has a NuGet package uploaded - see the [KarateChopDomain package](https://www.nuget.org/packages/KarateChopDomain) file for details.

## Contributing

Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.
