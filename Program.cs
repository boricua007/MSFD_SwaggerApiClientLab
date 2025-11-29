using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.DependencyInjection;
using MyGeneratedApiClient;



// STEP 2: Configure Swagger in the Application
public class Program
{
    public static async Task Main(string[] args)
    {
        // Create a WebApplication builder
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));
        app.MapControllers();

        // Start the API server 
        // NOTE: Uncomment the following lines to run the server and regenerate the API client
        // var serverTask = Task.Run(() => app.RunAsync());
        // await Task.Delay(3000); // Wait for the server to start

        // try
        // {
        //     // Create the API client
        //     var httpClient = new HttpClient();
        //     var apiClient = new CustomApiClient("http://localhost:5000", httpClient);

        //     // Use the generated client to call the API
        //     Console.WriteLine("Testing the generated API client...");
            
        //     // Call the Users endpoint with ID 1
        //     var user = await apiClient.UsersAsync(1, CancellationToken.None);
        //     Console.WriteLine($"Retrieved user: ID={user.Id}, Name={user.Name}");
        // }
        // catch (Exception ex)
        // {
        //     Console.WriteLine($"Error calling API: {ex.Message}");
        // }

        Console.WriteLine("API client demonstration completed!");
        Environment.Exit(0);
    }

}