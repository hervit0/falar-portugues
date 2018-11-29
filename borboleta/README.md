# Borboleta

A [Giraffe](https://github.com/giraffe-fsharp/Giraffe) web application, which has been created via the `dotnet new giraffe` command.

## Build and test the application

### Windows

Run the `build.bat` script in order to restore, build and test (if you've selected to include tests) the application:

```
> ./build.bat
```

### Linux/macOS

Run the `build.sh` script in order to restore, build and test (if you've selected to include tests) the application:

```
$ ./build.sh
```

## Run the application

After a successful build you can start the web application by executing the following command in your terminal:

```
dotnet run src/Borboleta
```

After the application has started visit [http://localhost:5000](http://localhost:5000) in your preferred browser.

## Notes

- containerization: https://docs.microsoft.com/en-us/dotnet/core/docker/docker-basics-dotnet-core

## Postgres

- Specific Posgres: https://fsprojects.github.io/SQLProvider/core/postgresql.html
- SQL Provider: http://fsprojects.github.io/SQLProvider/
- SQL Querying: http://fsprojects.github.io/SQLProvider/core/querying.html
