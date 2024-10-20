using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentContraller : ControllerBase
    {
        private readonly AppDbContext _context;
        public StudentContraller(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var s = _context.students.FirstOrDefault(x => x.Id == id);

            if (s != null)
            {
                return Ok(s);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post(StudentDTO dto)
        {
            var u = new Student
            {

                Name = dto.Name,
                Grad = dto.Grad,
            };
            _context.students.Add(u);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        public IActionResult Put(int id, StudentDTO dto)
        {
            var user = _context.students.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
           
            user.Name = dto.Name;
            user.Grad = dto.Grad;
            _context.students.Update(user);
            _context.SaveChanges();
            return Ok(user);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var user = _context.students.FirstOrDefault(x => x.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            _context.students.Remove(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }

}
