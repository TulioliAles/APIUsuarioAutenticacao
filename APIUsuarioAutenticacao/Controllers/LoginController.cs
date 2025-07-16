using APIUsuarioAutenticacao.Dto.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace APIUsuarioAutenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegistrarUsuario(UsuarioCriacaoDto usuario)
        {
            return Ok();
        }
    }
}
