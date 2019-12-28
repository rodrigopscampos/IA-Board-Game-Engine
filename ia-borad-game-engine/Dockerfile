FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["ia-borad-game-engine/ia-borad-game-engine.csproj", "ia-borad-game-engine/"]
RUN dotnet restore "ia-borad-game-engine/ia-borad-game-engine.csproj"
COPY . .
WORKDIR "/src/ia-borad-game-engine"
RUN dotnet build "ia-borad-game-engine.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ia-borad-game-engine.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ia-borad-game-engine.dll"]