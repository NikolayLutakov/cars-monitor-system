using CarsAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CarsAPI.Controllers
{
    [Route("api/[controller]/[action]/")]
    public class CarsController : Controller
    {
        public async Task<IActionResult> Test()
        {
            
            return Ok();
        }
    }
}
