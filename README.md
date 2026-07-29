# CicdDemo

CI/CD öğrenmek için hazırlanmış temel bir .NET 9 Web API projesidir.

## Proje yapısı

- `CicdDemo.Api`: ASP.NET Core Web API
- `CicdDemo.Tests`: MSTest unit test projesi

## Çalıştırma

```powershell
dotnet restore .\CicdDemo.sln
dotnet build .\CicdDemo.sln --no-restore
dotnet test .\CicdDemo.sln --no-build
dotnet run --project .\CicdDemo.Api\CicdDemo.Api.csproj
```

Swagger:

- `http://localhost:5080/swagger`

## Endpointler

```http
GET /health
GET /api/calculator/add?firstNumber=5&secondNumber=3
GET /api/calculator/subtract?firstNumber=10&secondNumber=4
```

## Beklenen cevaplar

- Toplama endpointi: `8`
- Çıkarma endpointi: `6`
- Health endpointi: `{ "status": "healthy", ... }`
