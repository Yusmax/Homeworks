FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Servet/Servet.csproj", "Servet/"]
RUN dotnet restore "Servet/Servet.csproj"
COPY . .
WORKDIR "/src/Servet"
RUN dotnet build "Servet.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Servet.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Servet.dll"]
