FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Client2/Client2.csproj", "Client2/"]
RUN dotnet restore "Client2/Client2.csproj"
COPY . .
WORKDIR "/src/Client2"
RUN dotnet build "Client2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Client2.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Client2.dll"]
