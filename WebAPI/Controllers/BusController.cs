using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        IBusService _busService;

        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _busService.GetAllBusDto();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolor")]
        public IActionResult GetByCategory(string color)
        {
            var result = _busService.GetAllByColor(color);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }
    }
}
