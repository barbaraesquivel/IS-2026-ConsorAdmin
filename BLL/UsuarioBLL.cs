using BE;
using DAL.Repositorio;
using SERV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class UsuarioBLL : IUsuarioBLL
    {
        private readonly IUsuarioRepositorio _usuarioRepo;
        private readonly ILogBitacoraBLL _log;

        public UsuarioBLL()
        {
            _usuarioRepo = new UsuarioRepositorio();
            _log         = new LogBitacoraBLL();
        }

        public IUsuario Login(string nombreUsuario, string password)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario))
                throw new ArgumentException("El usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("La contraseña es obligatoria.");

            string passwordHash = Hashear(password);
            UsuarioBE usuario;
            try
            {
                usuario = _usuarioRepo.ObtenerPorCredenciales(nombreUsuario, passwordHash);
            }
            catch (Exception ex)
            {
                // Error de infraestructura: no registrar LOGIN_FALLIDO, relanzar tal cual
                throw;
            }

            if (usuario == null)
            {
                _log.Registrar(Guid.Empty, AccionesBitacora.LoginFallido, ModulosBitacora.Seguridad,
                    $"Intento fallido: {nombreUsuario}");
                throw new Exception("Usuario o contraseña incorrectos.");
            }

            if (usuario.Baja)
            {
                _log.Registrar(usuario.Id, AccionesBitacora.LoginFallido, ModulosBitacora.Seguridad,
                    $"Intento de login con usuario dado de baja: {nombreUsuario}");
                throw new Exception("El usuario se encuentra dado de baja.");
            }

            if (usuario.Bloqueado)
            {
                _log.Registrar(usuario.Id, AccionesBitacora.LoginFallido, ModulosBitacora.Seguridad,
                    $"Intento de login con usuario bloqueado: {nombreUsuario}");
                throw new Exception("El usuario se encuentra bloqueado. Contacte al administrador.");
            }

            _log.Registrar(usuario.Id, AccionesBitacora.Login, ModulosBitacora.Seguridad,
                $"Inicio de sesión: {nombreUsuario}");
            return usuario;
        }

        public void Logout()
        {
            try
            {
                var username = SessionManager.SesionActiva()
                    ? SessionManager.ObtenerInstancia.Usuario?.Usuario ?? string.Empty
                    : string.Empty;
                var idUsuario = SessionManager.SesionActiva()
                    ? SessionManager.ObtenerInstancia.Usuario.Id
                    : Guid.Empty;

                SessionManager.Logout();
                _log.Registrar(idUsuario, AccionesBitacora.Logout, ModulosBitacora.Seguridad,
                    $"Cierre de sesión: {username}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        // ── CU03 ──────────────────────────────────────────────────────────────

        public List<UsuarioBE> ObtenerTodos()
        {
            return _usuarioRepo.ObtenerTodos();
        }

        public void Registrar(UsuarioBE usuario, List<int> permisosIds)
        {
            if (string.IsNullOrWhiteSpace(usuario.Usuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");

            var existente = _usuarioRepo.ObtenerPorNombre(usuario.Usuario);
            if (existente != null)
                throw new InvalidOperationException($"El nombre de usuario '{usuario.Usuario}' ya está en uso.");

            if (string.IsNullOrWhiteSpace(usuario.Contraseña))
                throw new ArgumentException("La contraseña es obligatoria en el alta.");

            usuario.Contraseña = Hashear(usuario.Contraseña);
            usuario.Id = Guid.NewGuid();
            usuario.Baja = false;

            _usuarioRepo.Crear(usuario);
            if (permisosIds != null && permisosIds.Count > 0)
                _usuarioRepo.ActualizarPermisosDeUsuario(usuario.Id, permisosIds);

            _log.Registrar(AccionesBitacora.AltaUsuario, ModulosBitacora.Usuarios,
                $"Usuario creado: {usuario.Usuario}");
        }

        public void Modificar(UsuarioBE usuario, List<int> permisosIds)
        {
            if (string.IsNullOrWhiteSpace(usuario.Usuario))
                throw new ArgumentException("El nombre de usuario es obligatorio.");

            var existente = _usuarioRepo.ObtenerPorNombre(usuario.Usuario);
            if (existente != null && existente.Id != usuario.Id)
                throw new InvalidOperationException($"El nombre de usuario '{usuario.Usuario}' ya está en uso por otro usuario.");

            if (string.IsNullOrWhiteSpace(usuario.Contraseña))
            {
                var actual = _usuarioRepo.ObtenerPorNombre(usuario.Usuario);
                usuario.Contraseña = actual?.Contraseña ?? string.Empty;
            }
            else
            {
                usuario.Contraseña = Hashear(usuario.Contraseña);
            }

            _usuarioRepo.Actualizar(usuario);
            _usuarioRepo.ActualizarPermisosDeUsuario(usuario.Id, permisosIds ?? new List<int>());

            _log.Registrar(AccionesBitacora.ModificarUsuario, ModulosBitacora.Usuarios,
                $"Usuario modificado: {usuario.Usuario}");
        }

        public void Inactivar(Guid idUsuario)
        {
            _usuarioRepo.Inactivar(idUsuario);
            _log.Registrar(AccionesBitacora.InactivarUsuario, ModulosBitacora.Usuarios,
                $"Usuario inactivado: {idUsuario}");
        }

        public List<ComponentePermisoBE> ObtenerArbolPermisos()
        {
            var todos = _usuarioRepo.ObtenerTodosPermisos();
            var resultado = new List<ComponentePermisoBE>();

            foreach (var p in todos.OrderBy(x => x.Tipo).ThenBy(x => x.Nombre))
            {
                if (p.Tipo == "F")
                    resultado.Add(new FamiliaBE { Id_Permiso = p.Id_Permiso, Codigo = p.Codigo, Nombre = p.Nombre, Tipo = p.Tipo });
                else
                    resultado.Add(new PatenteBE { Id_Permiso = p.Id_Permiso, Codigo = p.Codigo, Nombre = p.Nombre, Tipo = p.Tipo });
            }

            return resultado;
        }

        // ── Helpers ───────────────────────────────────────────────────────────

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
