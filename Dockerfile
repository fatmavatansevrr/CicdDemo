# 1. AŞAMA: Uygulamayı derlemek için .NET SDK image'ı
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /src

# Önce proje dosyalarını kopyala.
# Bu yapı Docker layer cache kullanımını iyileştirir.
COPY ["CicdDemo.Api/CicdDemo.Api.csproj", "CicdDemo.Api/"]
COPY ["CicdDemo.Tests/CicdDemo.Tests.csproj", "CicdDemo.Tests/"]

# API projesinin bağımlılıklarını indir.
RUN dotnet restore "CicdDemo.Api/CicdDemo.Api.csproj"

# Kaynak kodun tamamını container build ortamına kopyala.
COPY . .

# API projesini publish et.
WORKDIR "/src/CicdDemo.Api"

RUN dotnet publish "CicdDemo.Api.csproj" \
    --configuration Release \
    --output /app/publish \
    --no-restore

# 2. AŞAMA: Uygulamayı çalıştırmak için daha küçük runtime image'ı
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime

WORKDIR /app

# API'nin container içinde 8080 portunu dinlemesini sağla.
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Development

EXPOSE 8080

# Build aşamasındaki publish dosyalarını runtime image'a al.
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "CicdDemo.Api.dll"]