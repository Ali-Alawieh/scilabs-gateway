# STAGE 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /source


# Copy and restore as distinct layers
COPY Scilabs.Gateway.Api/*.csproj Scilabs.Gateway.Api/
COPY Scilabs.Gateway.Core/*.csproj Scilabs.Gateway.Core/
COPY Scilabs.Gateway.Application/*.csproj Scilabs.Gateway.Application/
COPY Scilabs.Gateway.Identity/*.csproj Scilabs.Gateway.Identity/
COPY Scilabs.Gateway.Infrastructure/*.csproj Scilabs.Gateway.Infrastructure/
COPY Scilabs.Gateway.Persistence/*.csproj Scilabs.Gateway.Persistence/
RUN dotnet restore Scilabs.Gateway.Api/Scilabs.Gateway.Api.csproj

# Copy everything else and build
COPY . .
WORKDIR /source/Scilabs.Gateway.Api
RUN dotnet restore # Ensure all packages are restored
RUN dotnet publish -c Release -o /app/publish --no-restore

# STAGE 2: Run
FROM  mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .
RUN apt-get update --allow-insecure-repositories && apt-get install -y curl
ENTRYPOINT ["dotnet", "Scilabs.Gateway.Api.dll"]