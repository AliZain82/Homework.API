using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Database_with_LINQ.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var entities = _context.YourEntities.ToList();
            return Ok(entities);
        }
        [HttpPost]
        public IActionResult Post([FromBody] YourEntity entity)
        {
            _context.YourEntities.Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] YourEntity entity)
        {
            var existingEntity = _context.YourEntities.Find(id);
            if (existingEntity == null)
            {
                return NotFound();
            }

        }
        existingEntity.Property1 = entity.Property1; 
        _context.SaveChanges();

        return Ok(existingEntity);


    }
