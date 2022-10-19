#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.Cine.Api/Api.Cine.Api.csproj", "Api.Cine.Api/"]
RUN dotnet restore "Api.Cine.Api/Api.Cine.Api.csproj"
COPY . .
WORKDIR "/src/Api.Cine.Api"
RUN dotnet build "Api.Cine.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.Cine.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.Cine.Api.dll"]