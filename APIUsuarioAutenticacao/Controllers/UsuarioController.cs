using APIUsuarioAutenticacao.Dto.Usuario;
using APIUsuarioAutenticacao.Services.Usuario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIUsuarioAutenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;    
        }

        [HttpGet]
        public async Task<IActionResult> BuscarUsuarios()
        {
            var usuarios = await _usuarioInterface.ListarUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("id")]
        public async Task<IActionResult> BuscarUsuarioPorId(int id) 
        {
            var usuario = await _usuarioInterface.BuscarUsuarioPorId(id);
            return Ok(usuario);
        }

        [HttpPut]
        public async Task<IActionResult> EditarUsuario(UsuarioEdicaoDto usuarioEdicaoDto)
        {
            var usuario = await _usuarioInterface.EditarUsuario(usuarioEdicaoDto);
            return Ok(usuario);
        }

        [HttpDelete]
        public async Task<IActionResult> RemoverUsuario(int id)
        {
            var usuario = await _usuarioInterface.RemoverUsuario(id);
            return Ok(usuario);
        }
    }
}
