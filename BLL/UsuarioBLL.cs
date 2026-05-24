using ABSTRAC;
using System.Security.Cryptography;
using BE;
using DAL.Repositorio;
using System.Text;
using SERV;

namespace BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private readonly IUsuarioRepositorio _usuarioRepo;

        public UsuarioBLL()
        {
            _usuarioRepo = new UsuarioRepositorio();
        }

        public IUsuario Login(string nombreUsuario, string password)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña es obligatoria.");

            string passwordHash = Hashear(password);
            UsuarioBE usuario = _usuarioRepo.ObtenerPorCredenciales(nombreUsuario, passwordHash);

            if (usuario == null)
                throw new Exception("Usuario o contraseña incorrectos.");

            if (usuario.Baja)
                throw new Exception("El usuario se encuentra dado de baja.");

            if (usuario.Bloqueado)
                throw new Exception("El usuario se encuentra bloqueado. Contacte al administrador.");

            return usuario;
        }

        public void Logout()
        {

            try { SessionManager.Logout(); }
            catch { throw new Exception(""); }
        }

        public static string Hashear(string texto)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}
