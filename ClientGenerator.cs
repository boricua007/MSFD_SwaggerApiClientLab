using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using NSwag;
using NSwag.CodeGeneration.CSharp;

// UTILITY FILE
// Step 4: Generate API Client Code from the Swagger Specification with NSwag

public class ClientGenerator
{
    public async Task GenerateClient()
    {
        using var httpClient = new HttpClient();
        var swaggerJson = await httpClient.GetStringAsync("http://localhost:5000/swagger/v1/swagger.json");
        
        // Load the OpenAPI/Swagger document
        var document = await OpenApiDocument.FromJsonAsync(swaggerJson);

        // Configure the C# client generator settings
        var settings = new CSharpClientGeneratorSettings
        {
            ClassName = "CustomApiClient",
            CSharpGeneratorSettings =
            {
                Namespace = "MyGeneratedApiClient"
            }
        };


        // Create the C# client generator
        var generator = new CSharpClientGenerator(document, settings);

        // Generate the C# client code
        var code = generator.GenerateFile();

        // Save the generated code to a file
        await File.WriteAllTextAsync("GeneratedApiClient.cs", code);

        // Output a confirmation message
        Console.WriteLine("Client code generated successfully.");
    }
}