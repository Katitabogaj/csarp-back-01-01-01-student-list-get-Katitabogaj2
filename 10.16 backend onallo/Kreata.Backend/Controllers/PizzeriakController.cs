using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PizzeriakController : ControllerBase
    {
        private IPizzeriakRepo _pizzeriakRepo;

        public PizzeriakController(IPizzeriakRepo pizzeriakRepo)
        {
            _pizzeriakRepo = pizzeriakRepo;
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllPizzeria()
        {
            List<Pizzeriak> pizzeriak = new();
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
            Pizzeriak? pizzeria = new();
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
