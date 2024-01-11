using Common.NetForemost;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.NetForemost;

namespace TestApi.NetForemost.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {

        private readonly IUserService _userService;
        public UsuariosController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("/api/usuario")]
        public async Task<IActionResult> Get()
            => Ok(await _userService.Get());

        [HttpGet("/api/usuario/{userId}")]
        public async Task<IActionResult> Get(int userId)
            => Ok(await _userService.Get(userId));

        [HttpPost("/api/usuario")]
        public async Task<IActionResult> Post(Usuarios usuario)
            => Ok(await _userService.Create(usuario));

    }
}
