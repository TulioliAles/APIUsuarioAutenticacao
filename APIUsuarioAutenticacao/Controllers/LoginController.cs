﻿using APIUsuarioAutenticacao.Dto.Usuario;
using APIUsuarioAutenticacao.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace APIUsuarioAutenticacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public LoginController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            var usuario = await _usuarioInterface.RegistrarUsuario(usuarioCriacaoDto);

            return Ok(usuario);
        }
    }
}
