using Common.NetForemost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.NetForemost;

namespace TestApi.NetForemost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareaController : ControllerBase
    {
        private readonly ITareaService _service;
        public TareaController(ITareaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _service.Get());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
           => Ok(await _service.GetById(id));

        [HttpGet("byuser/{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
           => Ok(await _service.GetbyUser(userId));

        [HttpPost]
        public async Task<IActionResult> Post(TareaRequest tarea)
            => Ok(_service.Crteate(tarea));

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Tareas tarea)
            => Ok(_service.Update(id, tarea));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(_service.Delete(id));

    }
}
