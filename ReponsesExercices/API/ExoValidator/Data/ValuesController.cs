using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoValidator.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppDbContext : ADbContext
    {
    }
}
