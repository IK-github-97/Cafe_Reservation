using Cafe.Data;
using Cafe.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cafe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        CafeDbContext _cafeDbContext;
        public MenusController(CafeDbContext cafeDbContext)
        {
            _cafeDbContext = cafeDbContext;
        }
        [HttpGet]
        public IActionResult GetMenus()
        {
            //var menus = _cafeDbContext.Menus.Include("SubMenus");
            var menus = _cafeDbContext.Menus.Include(m => m.SubMenus).ToList();
            return Ok(menus);
        }
        [HttpGet("{id}")]
        public IActionResult GetMenus(int id)
        {
            var menus = _cafeDbContext.Menus.Include(m => m.SubMenus).ToList().FirstOrDefault(m=>m.Id==id);
            if (menus == null)
            {
                return NotFound();
            }
            return Ok(menus);
        }
    }
}
