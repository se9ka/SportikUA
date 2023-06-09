#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sportik_API/Sportik_API.csproj", "Sportik_API/"]
RUN dotnet restore "Sportik_API/Sportik_API.csproj"
COPY . .
WORKDIR "/src/Sportik_API"
RUN dotnet build "Sportik_API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sportik_API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sportik_API.dll"]