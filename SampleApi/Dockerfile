# syntax=docker/dockerfile:1

# This is the first layer, which is used to compile the binaries.
# We call that layer build-env.
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /src

# Copy the csproj and restore the referenced Nugets
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o /app/publish --no-restore

# This is the second layer, which represents the runtime container.
# We copy over the build-result of the build-env layer into this container.
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build-env /app/publish .

ENTRYPOINT ["dotnet", "SampleApi.dll"]
