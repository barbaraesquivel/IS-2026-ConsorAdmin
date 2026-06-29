using BE;
using DAL.Models;

namespace DAL
{
    public class VerificadorVerticalDAL
    {
        public VerificadorVerticalBE ObtenerPorTabla(string nombreTabla)
        {
            using var ctx = new AppDbContext();
            var model = ctx.VerificadorVerticales.Find(nombreTabla);
            if (model == null) return null;
            return new VerificadorVerticalBE { NombreTabla = model.NombreTabla, DVV = model.Dvv };
        }

        public void GuardarOActualizar(string nombreTabla, int dvv)
        {
            using var ctx = new AppDbContext();
            var existing = ctx.VerificadorVerticales.Find(nombreTabla);
            if (existing == null)
                ctx.VerificadorVerticales.Add(new VerificadorVertical { NombreTabla = nombreTabla, Dvv = dvv });
            else
                existing.Dvv = dvv;
            ctx.SaveChanges();
        }
    }
}
