
# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy the .csproj and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the rest of the application files
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Use the .NET Runtime image to run the application
FROM mcr.microsoft.com/dotnet/runtime:5.0
WORKDIR /app

# Copy the build output from the build stage
COPY --from=build-env /app/out .

# Set the entry point for the application
ENTRYPOINT ["dotnet", "AdvancedDesktopApp.dll"]
