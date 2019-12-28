FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["IABoardGameEngine.WebApp/IABoardGameEngine.WebApp.csproj", "IABoardGameEngine.WebApp/"]
RUN dotnet restore "IABoardGameEngine.WebApp/IABoardGameEngine.WebApp.csproj"
COPY . .
WORKDIR "/src/IABoardGameEngine.WebApp"
RUN dotnet build "IABoardGameEngine.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IABoardGameEngine.WebApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IABoardGameEngine.WebApp.dll"]