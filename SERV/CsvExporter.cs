using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SERV
{
    public static class CsvExporter
    {
        public static void Exportar<T>(IEnumerable<T> datos, string rutaArchivo)
        {
            var propiedades = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // UTF-8 con BOM para que Excel en Windows abra bien las tildes
            using var writer = new StreamWriter(rutaArchivo, false, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));

            writer.WriteLine(string.Join(",", propiedades.Select(p => Escapar(p.Name))));

            foreach (var item in datos)
            {
                var valores = propiedades.Select(p => Escapar(p.GetValue(item)?.ToString() ?? string.Empty));
                writer.WriteLine(string.Join(",", valores));
            }
        }

        // RFC 4180 simplificado: envuelve en comillas si contiene coma, comilla o salto de línea
        private static string Escapar(string valor)
        {
            if (valor.Contains(',') || valor.Contains('"') || valor.Contains('\n'))
                return "\"" + valor.Replace("\"", "\"\"") + "\"";
            return valor;
        }
    }
}
