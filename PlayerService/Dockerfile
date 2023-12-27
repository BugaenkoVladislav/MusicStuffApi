FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["PlayerService/PlayerService.csproj", "PlayerService/"]
RUN dotnet restore "PlayerService/PlayerService.csproj"
COPY . .
WORKDIR "/src/PlayerService"
RUN dotnet build "PlayerService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PlayerService.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PlayerService.dll"]
