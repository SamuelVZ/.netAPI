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
        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetWalkById(int id) {

            var result = await walkService.GetWalkById(id);

            if(result == null) { return NotFound(); }

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteWalkById(int id) {
            var deleted = await walkService.DelelteWalk(id);
            return deleted ? Ok() : NotFound("Walk does not exist");
        }
    }
}
