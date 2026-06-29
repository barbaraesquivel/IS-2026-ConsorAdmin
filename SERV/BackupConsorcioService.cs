using BE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace SERV
{
    public static class BackupConsorcioService
    {
        // Directorio = carpeta del ejecutable; cada backup tiene su propio archivo con timestamp.
        // Nunca se sobreescribe un backup anterior: cada llamada a GuardarBackup crea un archivo nuevo.
        private static readonly string Directorio =
            AppDomain.CurrentDomain.BaseDirectory;

        private const string Prefijo  = "backup_consorcio_";
        private const string Sufijo   = ".json";
        private const string Patron   = "backup_consorcio_*.json";

        // Guarda el estado VERIFICADO como íntegro. Crea un nuevo archivo con timestamp;
        // los backups anteriores quedan intactos como historial de puntos de restauración.
        // Retorna el nombre del archivo generado (para logging).
        public static string GuardarBackup(List<ConsorcioBE> consorcios)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string nombre    = $"{Prefijo}{timestamp}{Sufijo}";
            string ruta      = Path.Combine(Directorio, nombre);

            var dto = consorcios.Select(c => new BackupConsorcioDto
            {
                IdConsorcio  = c.Id_Consorcio ?? string.Empty,
                Nombre       = c.Nombre       ?? string.Empty,
                Direccion    = c.Direccion    ?? string.Empty,
                CantUnidades = c.CantUnidades,
                DVH          = c.DVH
            }).ToList();

            var json = JsonSerializer.Serialize(dto, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ruta, json, Encoding.UTF8);

            return nombre;
        }

        // Carga el backup más reciente (el de mayor timestamp en el nombre).
        // Retorna null si no existe ningún backup.
        public static List<ConsorcioBE>? CargarUltimoBackup()
        {
            string? ruta = ObtenerRutaMasReciente();
            if (ruta == null) return null;

            var json = File.ReadAllText(ruta, Encoding.UTF8);
            var dto  = JsonSerializer.Deserialize<List<BackupConsorcioDto>>(json);

            return dto?.Select(d => new ConsorcioBE
            {
                Id_Consorcio = d.IdConsorcio,
                Nombre       = d.Nombre,
                Direccion    = d.Direccion,
                CantUnidades = d.CantUnidades,
                DVH          = d.DVH
            }).ToList();
        }

        public static bool ExisteBackup() => ObtenerRutaMasReciente() != null;

        // Devuelve el nombre del archivo de backup más reciente (sin ruta), o null si no hay.
        public static string? NombreUltimoBackup()
        {
            string? ruta = ObtenerRutaMasReciente();
            return ruta == null ? null : Path.GetFileName(ruta);
        }

        // Los archivos se ordenan por nombre descendente: el patrón YYYYMMDD_HHmmss hace que
        // el más reciente quede último alfabéticamente → OrderByDescending da el más nuevo.
        private static string? ObtenerRutaMasReciente()
        {
            var archivos = Directory.GetFiles(Directorio, Patron);
            return archivos.Length == 0
                ? null
                : archivos.OrderByDescending(f => f).First();
        }
    }

    // DTO de serialización — solo los campos que el backup necesita guardar
    public class BackupConsorcioDto
    {
        public string IdConsorcio  { get; set; } = string.Empty;
        public string Nombre       { get; set; } = string.Empty;
        public string Direccion    { get; set; } = string.Empty;
        public int    CantUnidades { get; set; }
        public int    DVH          { get; set; }
    }
}
