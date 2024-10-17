using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    public class PizzeriakController
    {
            [ApiController]
            [Route("api/[controller]")]
            public class PizzeriakControllers : ControllerBase
            {
                private IPizzeriakRepo _pizzeriakRepo;

                public PizzeriakControllers(IPizzeriakRepo pizzeriakRepo)
                {
                    _pizzeriakRepo = pizzeriakRepo;
                }

                [HttpGet]
                public async Task<IActionResult> SelectAllTeacher()
                {
                    List<Pizza> pizzeriak = new();
                    if (_pizzeriakRepo is not null)
                    {
                    pizzeriak = await _pizzeriakRepo.GetAll();
                        return Ok(pizzeriak);
                    }
                    return BadRequest("Az adaok elérése nem sikerült");
                }

                [HttpGet("{id}")]
                public async Task<IActionResult> GetBy(Guid id)
                {
                    Pizza? pizzeria = new();
                    if (_pizzeriakRepo is not null)
                    {
                        pizzeria = await _pizzeriakRepo.GetBy(id);
                        if (pizzeria is not null)
                            return Ok(pizzeria);
                    }
                    return BadRequest("A pizzéria adat elérése nem sikerült.");
                }
            }
    }
}
