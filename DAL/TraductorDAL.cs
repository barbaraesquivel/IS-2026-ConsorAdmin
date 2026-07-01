using BE;
using BE.Models;
using DAL.Models;
using DAL.Repositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TraductorDAL
    {
        public List<IdiomaBE> ObtenerIdiomas()
        {
            using var ctx = new AppDbContext();
            return ctx.Idiomas.Select(i => IdiomaMapper.Map(i)).ToList();
        }

        public IdiomaBE ObtenerIdiomaDefault()
        {
            using var ctx = new AppDbContext();
            var i = ctx.Idiomas.FirstOrDefault(x => x.EsDefault);
            return IdiomaMapper.Map(i);
        }

        public IdiomaBE ObtenerIdiomaPorId(int idIdioma)
        {
            using var ctx = new AppDbContext();
            var i = ctx.Idiomas.Find(idIdioma);
            return IdiomaMapper.Map(i);
        }

        public IdiomaBE AgregarIdioma(string nombre)
        {
            using var ctx = new AppDbContext();
            var model = new Idioma { Nombre = nombre, EsDefault = false };
            ctx.Idiomas.Add(model);
            ctx.SaveChanges();
            return IdiomaMapper.Map(model);
        }

        public List<string> ObtenerClavesPorFormulario(string formulario)
        {
            using var ctx = new AppDbContext();
            return ctx.Etiquetas
                .Where(e => e.Formulario == formulario)
                .Select(e => e.Clave)
                .ToList();
        }

        public int ObtenerOCrearEtiqueta(string clave, string formulario)
        {
            using var ctx = new AppDbContext();
            var existente = ctx.Etiquetas.FirstOrDefault(e => e.Clave == clave);
            if (existente != null) return existente.IdEtiqueta;

            var nueva = new Etiqueta { Clave = clave, Formulario = formulario };
            ctx.Etiquetas.Add(nueva);
            ctx.SaveChanges();
            return nueva.IdEtiqueta;
        }

        public void GuardarTraduccion(int idIdioma, int idEtiqueta, string texto)
        {
            using var ctx = new AppDbContext();
            var existente = ctx.Traducciones
                .FirstOrDefault(t => t.IdIdioma == idIdioma && t.IdEtiqueta == idEtiqueta);

            if (existente != null)
                existente.Texto = texto;
            else
                ctx.Traducciones.Add(new Traduccion { IdIdioma = idIdioma, IdEtiqueta = idEtiqueta, Texto = texto });

            ctx.SaveChanges();
        }

        // Dictionary clave->texto, usado por Traducir() en cada Form
        public Dictionary<string, string> ObtenerTraducciones(int idIdioma)
        {
            using var ctx = new AppDbContext();
            return ctx.Traducciones
                .Where(t => t.IdIdioma == idIdioma)
                .Include(t => t.IdEtiquetaNavigation)
                .Select(t => TraduccionMapper.Map(t))
                .ToDictionary(t => t.Clave, t => t.Texto);
        }

        // Lista de TraduccionBE (clave + texto) para llenar el grid de formIdiomasA
        public List<TraduccionBE> ObtenerTraduccionesConClave(int idIdioma)
        {
            using var ctx = new AppDbContext();
            return ctx.Traducciones
                .Where(t => t.IdIdioma == idIdioma)
                .Include(t => t.IdEtiquetaNavigation)
                .Select(t => TraduccionMapper.Map(t))
                .ToList();
        }

        // Retorna lista de (clave, textoEspañol, textoTraducido) para un idioma, usado por el DataGridView de formIdiomasA
        public List<(string Clave, string Original, string Traduccion)> ObtenerParaEdicion(int idIdioma)
        {
            using var ctx = new AppDbContext();
            var etiquetas = ctx.Etiquetas.ToList();
            var tradEspañol = ctx.Traducciones.Where(t => t.IdIdioma == 1)
                .ToDictionary(t => t.IdEtiqueta, t => t.Texto);
            var tradIdioma = ctx.Traducciones.Where(t => t.IdIdioma == idIdioma)
                .ToDictionary(t => t.IdEtiqueta, t => t.Texto);

            return etiquetas.Select(e => (
                e.Clave,
                tradEspañol.GetValueOrDefault(e.IdEtiqueta, ""),
                tradIdioma.GetValueOrDefault(e.IdEtiqueta, "")
            )).ToList();
        }

    }
}
