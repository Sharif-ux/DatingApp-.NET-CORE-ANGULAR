using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API.Data;

namespace API.Controllers
{
    [Route("api/[controller]")] //localhost:5000/api/members
    [ApiController]
    public class MembersController(AppDbContext context) : ControllerBase
    {
     
    }
}