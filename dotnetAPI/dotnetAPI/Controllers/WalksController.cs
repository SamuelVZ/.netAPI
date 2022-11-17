using dotnetAPI.model;
using dotnetAPI.Service;
using Microsoft.AspNetCore.Mvc;

namespace dotnetAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class WalksController : Controller {
        private readonly WalkService walkService;

        public WalksController(WalkService walkService) {
            this.walkService = walkService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() {
            var walks = await walkService.GetAll();

            return Ok(walks);
        }
    }
}
