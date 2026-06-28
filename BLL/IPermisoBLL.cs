using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public interface IPermisoBLL
    {
        // Devuelve el árbol expandido de permisos del usuario (Familias con sus Patentes incluidas)
        List<ComponentePermisoBE> ObtenerArbolDeUsuario(Guid idUsuario);

        // True si el usuario tiene esa patente (directamente o vía una Familia asignada)
        bool TienePatente(Guid idUsuario, string codigoPatente);

        // True si el usuario tiene al menos una patente de la familia indicada
        bool TieneAlgunaPatenteDeFamilia(Guid idUsuario, string codigoFamilia);

        List<ComponentePermisoBE> ObtenerArbolCompleto();
        // Devuelve todas las familias (con o sin padre) para llenar combos
        List<ComponentePermisoBE> ObtenerTodasLasFamilias();
        // Devuelve todas las patentes para llenar combos
        List<ComponentePermisoBE> ObtenerTodasLasPatentes();
        void CrearFamilia(string codigo, string nombre);
        void AgregarPatenteAFamilia(int idFamilia, int idPatente);
        // Retorna true si aAgregar puede ser contenida en contenedor.
        // La única restricción: la familia Administrador (GE100) no puede anidarse en ninguna otra.
        bool PuedeContener(FamiliaBE contenedor, FamiliaBE aAgregar);
        void AgregarFamiliaAFamilia(int idContenedor, int idAgregar);
    }
}
