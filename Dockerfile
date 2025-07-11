# Stage 1: Build the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy source code into container
COPY . .

# Publish the application
RUN dotnet publish "FIrstApplication/FIrstApplication.csproj" -c Release -o /app/publish

# Stage 2: Run the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

# Copy the build output to the runtime image
COPY --from=build /app/publish .

# Run the app
ENTRYPOINT ["dotnet", "FIrstApplication.dll"]
