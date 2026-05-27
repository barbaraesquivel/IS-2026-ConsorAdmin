using System.Collections.Generic;

namespace BE
{
    // Hereda de ComponentePermisoBE para mantener compatibilidad con mappers y UsuarioPermisoBE.
    public class PermisoBE : ComponentePermisoBE
    {
        public List<UsuarioPermisoBE> usuarioPermisos { get; set; } = new();
    }
}
