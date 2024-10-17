using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;

namespace Kreata.Backend.Controllers
{
    public class ParentController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class ParentControllers : ControllerBase
        {
            private IParentRepo _parentRepo;

            public ParentControllers(IParentRepo parentRepo)
            {
                _parentRepo = parentRepo;
            }

            [HttpGet]
            public async Task<IActionResult> SelectAllTeacher()
            {
                List<Parent> parents = new();
                if (_parentRepo is not null)
                {
                    parents = await _parentRepo.GetAll();
                    return Ok(parents);
                }
                return BadRequest("Az adaok elérése nem sikerült");
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetBy(Guid id)
            {
                Parent? parent = new();
                if (_parentRepo is not null)
                {
                    parent = await _parentRepo.GetBy(id);
                    if (parent is not null)
                        return Ok(parent);
                }
                return BadRequest("A szülő adat elérése nem sikerült.");
            }
        }
    }
}
