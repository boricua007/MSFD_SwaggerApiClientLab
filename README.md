# MSFD Swagger API Client Lab

.NET 9.0 Console Application demonstrating Swagger API client generation, ASP.NET Core web API development, and NSwag code generation for the Microsoft Full Stack Developer certification.

## Quick Start

```bash
dotnet run
```

## Features

✅ **API Client Generation** - Automated strongly-typed client generation from Swagger/OpenAPI specs  
✅ **ASP.NET Core Integration** - Full web API with Swagger documentation  
✅ **NSwag Code Generation** - C# client generation using NSwag toolchain  
✅ **Type Safety** - Compile-time type checking for API calls  
✅ **Swagger UI** - Interactive API documentation and testing  
✅ **Educational Design** - Clear demonstration of API client best practices  

**Tech Stack:** .NET 9.0 • C# • ASP.NET Core • NSwag • Swagger/OpenAPI • HttpClient

## API Client Patterns

| Pattern | Purpose | Implementation | Benefit |
|---------|---------|----------------|---------|
| Code Generation | Automated client creation | NSwag toolchain | Type safety & productivity |
| Swagger Integration | API documentation | OpenAPI specification | Interactive testing |
| Async Operations | Non-blocking calls | async/await pattern | Better performance |
| HTTP Client Management | Connection handling | HttpClient injection | Resource efficiency |

## Usage Examples

### Generated API Client

```csharp
// Create the API client
var httpClient = new HttpClient();
var apiClient = new CustomApiClient("http://localhost:5000", httpClient);

// Make strongly-typed API calls
var user = await apiClient.UsersAsync(1, CancellationToken.None);
Console.WriteLine($"Retrieved user: ID={user.Id}, Name={user.Name}");
```

### Server Configuration

```csharp
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.Run();
```

### Client Generation

```csharp
var settings = new CSharpClientGeneratorSettings
{
    ClassName = "CustomApiClient",
    CSharpGeneratorSettings = { Namespace = "MyGeneratedApiClient" }
};

var generator = new CSharpClientGenerator(document, settings);
var code = generator.GenerateFile();
```

## Sample Output

```
Testing the generated API client...
Retrieved user: ID=1, Name=User1
API client demonstration completed!
```

**Note:** The API client provides strongly-typed access to all API endpoints with automatic JSON serialization.

## Data Model

```csharp
public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    public ActionResult<User> GetUser(int id) { /* Implementation */ }
}
```

## Code Structure Demonstrated

```csharp
// API Controller with attribute routing
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase

// Swagger configuration for documentation
builder.Services.AddSwaggerGen();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

// NSwag client generation settings
var settings = new CSharpClientGeneratorSettings
{
    ClassName = "CustomApiClient",
    CSharpGeneratorSettings = { Namespace = "MyGeneratedApiClient" }
};

// Async API client usage
var user = await apiClient.UsersAsync(1, CancellationToken.None);
```

## Learning Objectives

• **API Development:** Building RESTful APIs with ASP.NET Core  
• **Code Generation:** Understanding automated client generation from API specs  
• **OpenAPI Standards:** Working with Swagger/OpenAPI for API documentation  
• **Type Safety:** Leveraging strongly-typed clients for robust applications  
• **MSFD Certification:** Demonstrates full-stack API development competencies for Microsoft Full Stack Developer track

## Project Structure

```
MSFD_SwaggerApiClientLab/
├── Program.cs                    # Main application with server and client demo
├── ClientGenerator.cs                # NSwag client generation logic
├── Controllers/
│   └── UserController.cs               # Sample API controller
├── GeneratedApiClient.cs         # Auto-generated API client
├── MSFD_SwaggerApiClientLab.csproj    # Project configuration
├── MSFD_SwaggerApiClientLab.sln          # Solution file
├── bin/                          # Compiled binaries
├── obj/                          # Build artifacts
└── README.md            # This file
```

## Development Workflow

1. **Start the Application:** `dotnet run`
2. **Explore API Documentation:** 
   • Visit `http://localhost:5000/swagger` for interactive API docs
   • Test endpoints directly in Swagger UI
   • Review OpenAPI JSON specification
3. **Study Generated Client:** 
   • Examine `GeneratedApiClient.cs` for generated code
   • Test strongly-typed API calls
   • Compare with manual HTTP requests

## Getting Started

1. Clone or download the project
2. Navigate to project directory: `cd MSFD_SwaggerApiClientLab`
3. Restore dependencies: `dotnet restore`
4. Build the application: `dotnet build`
5. Run the application: `dotnet run`
6. Explore the implementation:
   • Check generated client code in `GeneratedApiClient.cs`
   • Visit Swagger UI at `http://localhost:5000/swagger`
   • Study the client generation process in `ClientGenerator.cs`

## Key Concepts Demonstrated

• **Contract-First Development:** Using OpenAPI specs to define API contracts  
• **Code Generation:** Automating client creation for consistency and productivity  
• **API Documentation:** Providing interactive documentation with Swagger UI  
• **Type Safety:** Compile-time checking for API interactions  
• **Separation of Concerns:** Clear separation between API server and client code

.NET 9.0 Console Application built for the Microsoft Back-End Development course as part of the Full-Stack Certification track. This app demonstrates modern API development patterns with automated client generation - essential skills for full-stack developers building scalable web applications.

## API Endpoints

| Method | Endpoint | Description | Response |
|--------|----------|-------------|----------|
| GET | `/api/users/{id}` | Get user by ID | User object |
| GET | `/swagger` | Swagger UI | Interactive documentation |
| GET | `/swagger/v1/swagger.json` | OpenAPI spec | JSON specification |

## About

.NET 9.0 Console Application demonstrating Swagger API client generation, ASP.NET Core web API development, and NSwag code generation for the Microsoft Full Stack Developer certification.