# Étape de construction de l'application
FROM mcr.microsoft.com/dotnet/sdk AS build
WORKDIR /src
COPY ["DemoBlazor01.csproj", "."]
RUN dotnet restore "DemoBlazor01.csproj"
COPY . .
RUN dotnet publish "DemoBlazor01.csproj" -c Release -o /app/publish

# Serveur Web Nginx
FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=build /app/publish/wwwroot .
