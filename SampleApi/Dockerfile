# syntax=docker/dockerfile:1
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY . SampleApi
# Copy all other dependecies as well before restoring and building.
RUN dotnet restore ./SampleApi/SampleApi.csproj

# Copy everything else and build
RUN dotnet publish -c Release -o out ./SampleApi/SampleApi.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "SampleApi.dll"]
