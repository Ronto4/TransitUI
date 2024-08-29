FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["TransitApi/TransitApi.csproj", "TransitApi/"]
RUN dotnet restore "TransitApi/TransitApi.csproj"
COPY . .
WORKDIR "/src/TransitApi"
RUN dotnet build "TransitApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TransitApi.csproj" -c Release -o /app/publish

FROM base AS final
# Set time zone to Berlin (see https://serverfault.com/a/683651)
ARG TZ=Europe/Berlin
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TransitApi.dll"]
