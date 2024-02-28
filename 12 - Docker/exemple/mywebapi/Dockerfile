FROM mcr.microsoft.com/dotnet/aspnet AS base
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk AS build
WORKDIR /src
COPY ["mywebapi.csproj","."]
RUN dotnet restore "mywebapi.csproj"
COPY . .

RUN dotnet build "mywebapi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "mywebapi.csproj" -c Release -o /app/publish 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet","mywebapi.dll"]
