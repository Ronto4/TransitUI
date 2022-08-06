FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TransitApi/TransitApi.csproj", "TransitApi/"]
RUN dotnet restore "TransitApi/TransitApi.csproj"
COPY . .
WORKDIR "/src/TransitApi"
RUN dotnet build "TransitApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TransitApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TransitApi.dll"]
