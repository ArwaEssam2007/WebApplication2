using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectContraller : ControllerBase
    {
        private readonly AppDbContext _context;
        public SubjectContraller(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var s = _context.subjects.FirstOrDefault(x => x.Id == id);

            if (s != null)
            {
                return Ok(s);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(StudentDTO dto)
        {
            var u = new Subject
            {

                Name = dto.Name,
               
            };
            _context.subjects.Add(u);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(int id, SubjectDTO dto)
        {
            var s = _context.subjects.FirstOrDefault(x => x.Id == id);
            if (s == null)
            {
                return NotFound();
            }

            s.Name = dto.Name;
            _context.subjects.Update(s);
            _context.SaveChanges();
            return Ok(s);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var s = _context.subjects.FirstOrDefault(x => x.Id == id);
            if (s == null)
            {
                return NotFound();
            }
            _context.subjects.Remove(s);
            _context.SaveChanges();
            return Ok(s);
        }
    }

}
