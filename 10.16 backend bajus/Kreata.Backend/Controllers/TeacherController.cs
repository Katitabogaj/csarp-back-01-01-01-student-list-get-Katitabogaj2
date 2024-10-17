using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController :ControllerBase
    {
        private ITeacherRepo _teacherRepo;

        public TeacherController(ITeacherRepo teacherRepo)
        {
            _teacherRepo = teacherRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllTeacher()
        {
            List<Teacher> teachers = new();
            if (_teacherRepo is not null)
            {
                teachers = await _teacherRepo.GetAll();
                return Ok(teachers);
            }
            return BadRequest("Az adaok elérése nem sikerült");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Teacher? teacher = new();
            if (_teacherRepo is not null)
            {
                teacher = await _teacherRepo.GetBy(id);
                if (teacher is not null)
                    return Ok(teacher);
            }
            return BadRequest("A tanár adat elérése nem sikerült.");
        }
    }
}
