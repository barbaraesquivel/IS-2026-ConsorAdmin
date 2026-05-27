using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GestorConsorcioBLL
    {
        private readonly GestorConsorcioDAL gestorConsorcioDAL = new GestorConsorcioDAL();

        public void CrearGestor(string idUsuario, string idConsorcio)
        {
            try
            {
                
                if (idUsuario == null || idConsorcio == null)
                {
                    throw new Exception("Campos Invalidos");
                }
                foreach (var item in ObtenerTodos())
                {
                    if (item.Id_Usuario == Guid.Parse(idUsuario) && item.Id_Consorcio == idConsorcio)
                    {
                        throw new Exception("Gestor ya Asociado");
                    }
                }
                GestorConsorcioBE gestorConsorcioBE = new GestorConsorcioBE();
                gestorConsorcioBE.FechaAsignacion = DateTime.Now;

                gestorConsorcioDAL.Crear(gestorConsorcioBE);
            }
            catch { throw; }
        }

        public void Eliminar(GestorConsorcioBE gestor) 
        {
            try
            {
                if(gestor == null)
                {
                    throw new Exception("Gestor invalido");
                }
                gestorConsorcioDAL.Eliminar(gestor);
            }
            catch { throw; }
        }
        public List<GestorConsorcioBE> ObtenerTodos()
        {
            try
            {
                return gestorConsorcioDAL.ObtenerTodos();
            }
            catch { throw; }
        }
        public List<GestorConsorcioBE> ObtenerPorConsorcio(string idConsorcio)
        {
            try
            {
                if(idConsorcio == null)
                {
                    throw new Exception("Consorcio Invalido");
                }
                return gestorConsorcioDAL.ObtenerPorConsorcio(idConsorcio);
            }
            catch { throw; }
        }

    }
}
