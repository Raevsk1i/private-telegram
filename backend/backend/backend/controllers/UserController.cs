using Microsoft.AspNetCore.Mvc;

namespace backend.controllers
{
    [Route("/api")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public int get1()
        {
            return 1;
        }

    }
}
