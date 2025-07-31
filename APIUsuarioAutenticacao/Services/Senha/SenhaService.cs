using System.Security.Cryptography;

namespace APIUsuarioAutenticacao.Services.Senha
{
    public class SenhaService : ISenhaInterface
    {
        public void CriarSenhaHash(string senha, out byte[] senhaHash, out byte[] senhaSalt)
        {
            using (var hMac = new HMACSHA512()) 
            {
                senhaSalt = hMac.Key;
                senhaHash = hMac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha));
            }
        }
    }
}
