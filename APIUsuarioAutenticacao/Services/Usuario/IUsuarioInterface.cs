using APIUsuarioAutenticacao.Dto.Usuario;
using APIUsuarioAutenticacao.Models;

namespace APIUsuarioAutenticacao.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<UsuarioModel>> RegistrarUsuario(UsuarioCriacaoDto usuarioCriacaoDto);
    }
}
