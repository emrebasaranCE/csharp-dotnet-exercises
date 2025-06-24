# Patika Middleware Practice

ASP.NET Core middleware exercises demonstrating custom request logging, exception handling, and response transformation.

## Middleware Components

- **RequestLoggingMiddleware**: Logs path, method, and headers.
- **ErrorHandlingMiddleware**: Catches exceptions and returns JSON error payload.
- **CustomHeaderMiddleware**: Adds or modifies response headers.

## Usage

1. Open `Startup.cs` (or `Program.cs`).
2. Register middleware in the pipeline.
3. Run with:
   ```bash
    dotnet run --project Patika_Middleware_Practice_Repo.csproj
