using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SERV
{
    public static class ServicioBackupConsorcio
    {
        private static readonly string Directorio = AppDomain.CurrentDomain.BaseDirectory;

        private const string Prefijo = "backup_consorcio_";
        private const string Sufijo = ".json";
        private const string Patron = "backup_consorcio_*.json";

        public static string GuardarCopiaSeguridad(List<ConsorcioBE> consorcios)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombre = $"{Prefijo}{timestamp}{Sufijo}";
            string ruta = Path.Combine(Directorio, nombre);

            var datos = consorcios.Select(c => new DatosBackupConsorcio
            {
                IdConsorcio = c.Id_Consorcio ?? string.Empty,
                Nombre = c.Nombre ?? string.Empty,
                Direccion = c.Direccion ?? string.Empty,
                CantUnidades = c.CantUnidades,
                DVH = c.DVH
            }).ToList();

            var json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json, Encoding.UTF8);

            return nombre;
        }

        public static List<ConsorcioBE>? CargarUltimaCopiaSeguridad()
        {
            string? ruta = ObtenerRutaMasReciente();
            if (ruta == null) return null;

            var json = File.ReadAllText(ruta, Encoding.UTF8);
            var datos = JsonSerializer.Deserialize<List<DatosBackupConsorcio>>(json);

            return datos?.Select(d => new ConsorcioBE
            {
                Id_Consorcio = d.IdConsorcio,
                Nombre = d.Nombre,
                Direccion = d.Direccion,
                CantUnidades = d.CantUnidades,
                DVH = d.DVH
            }).ToList();
        }

        public static bool ExisteCopiaSeguridad() => ObtenerRutaMasReciente() != null;

        public static string? NombreUltimaCopiaSeguridad()
        {
            string? ruta = ObtenerRutaMasReciente();
            return ruta == null ? null : Path.GetFileName(ruta);
        }

        private static string? ObtenerRutaMasReciente()
        {
            var archivos = Directory.GetFiles(Directorio, Patron);
            return archivos.Length == 0 ? null : archivos.OrderByDescending(f => f).First();
        }
    }

    public class DatosBackupConsorcio
    {
        public string IdConsorcio { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public int CantUnidades { get; set; }
        public int DVH { get; set; }
    }
}
