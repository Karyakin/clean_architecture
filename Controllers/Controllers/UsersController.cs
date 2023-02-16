using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UseCaseInterfaces.UsersInterfaces;

namespace Controllers.Controllers;

[Route("api/[controller]")]
[Produces("application/json")]
public class UsersController : ControllerBase
{
    private readonly IUsersInterfaces _usersInterfaces;

    public UsersController(IUsersInterfaces usersInterfaces)
    {
        _usersInterfaces = usersInterfaces;
    }

    [HttpGet("getUsers")]
    public async Task<IActionResult> GetUsers()
    {
        var temp = _usersInterfaces.GetUsers();
        return Ok(temp);
    }
}