FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Install ImageMagick (see https://askubuntu.com/a/648245)
RUN apt update
RUN apt install imagemagick -y
RUN mkdir /tmp/pngs

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TransitWeb/TransitWeb.csproj", "TransitWeb/"]
RUN dotnet restore "TransitWeb/TransitWeb.csproj"
COPY . .
WORKDIR "/src/TransitWeb"
RUN dotnet build "TransitWeb.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TransitWeb.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
# FOR DEBUGGING ONLY
ENV ASPNETCORE_ENVIRONMENT=Development
ENTRYPOINT ["dotnet", "TransitWeb.dll"]
