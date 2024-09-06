using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cafe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        CafeDbContext _cafeDbContext;
        public ReservationsController(CafeDbContext cafeDbContext)
        {
            _cafeDbContext = cafeDbContext;
        }
        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _cafeDbContext.Reservations.Add(reservation);
            _cafeDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
