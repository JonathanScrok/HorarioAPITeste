FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://+:5000

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HorarioAPI.csproj", "./"]
RUN dotnet restore "HorarioAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "HorarioAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HorarioAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# ENTRYPOINT ["dotnet", "HorarioAPI.dll"]

RUN useradd -m myappuser
USER myappuser

CMD ASPNETCORE_URLS=http://*:$PORT dotnet HorarioAPI.dll