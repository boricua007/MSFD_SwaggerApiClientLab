using Microsoft.AspNetCore.Mvc;


// Step 3: Define the API Specification 
// UserController with an endpoint to get user details


// User model
public class User
{
    public int Id { get; set; }
    public string Name { get; set; } 
}


[ApiController]
[Route("api/[controller]")] 
public class UserController : ControllerBase
{
    [HttpGet("{id}")]
    [Produces("application/json")]
    public ActionResult<User> GetUser(int id)
    {
        var user = new User
        {
            Id = id,
            Name = $"User{id}"
        };
        return Ok(user);
    }
}   