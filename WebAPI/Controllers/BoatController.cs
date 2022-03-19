using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoatController : ControllerBase
    {
        IBoatService _boatService;

        public BoatController(IBoatService boatService)
        {
            _boatService = boatService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _boatService.GetAllBoatDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByCategory(string color)
        {
            var result = _boatService.GetAllByColor(color);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }
    }
}
